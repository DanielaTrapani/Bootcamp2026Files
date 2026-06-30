using Microsoft.EntityFrameworkCore;

namespace EFCoreConsoleDemo1
{
    internal class Program
    {
        static AppDBContext context;

        static void Main(string[] args)
        {
            context = new AppDBContext();

            //AddOneProduct();
            //AddOneVendor();
            //AddManyProducts();
            //AddManyVendors();

            //RemoveFirstProduct();
            //RemoveLastProduct();

            //ChangeVendorName();
            //IncreasePriceForVendor();

            //GetAllProducts();
            //GetAllVendors();

            //GetProductsUnder100();
            //GetAllProductsUsingVendorId();
            //GetProductsWithNullPrices();
            //GetVendorByState();

            //SearchProductUsingContains();
            //CheckVendorHasProducts();

            Console.WriteLine();
            Console.WriteLine("Complete");
            Console.ReadLine();

        }

        private static void CheckVendorHasProducts()
        {
            bool hasProducts = context.Products
                .Any(p => p.VendorId == 1);


            Console.WriteLine($"Vendor ID 1 has products: {hasProducts}");
        }

        private static void GetAllProducts()
        {
            var allProducts = context.Products.ToList();

            foreach (var product in allProducts)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }
        }

        private static void GetAllVendors()
        {
            var allVendors = context.Vendors.ToList();

            foreach (var vendor in allVendors)
            {
                Console.WriteLine($"{vendor.Name} - {vendor.City}, {vendor.State}");
            }
        }

        private static void SearchProductUsingContains()
        {
            var matchingProducts = context.Products
                .Where(p => p.Name.Contains("Key"))
                .Include(p => p.Vendor)
                .ToList();

            Console.WriteLine($"Products containing {"Key"}:");
            foreach (var product in matchingProducts)
            {
                Console.WriteLine($"{product.Name} - ${product.Price} (Vendor: {product.Vendor?.Name})");
            }
        }

        private static void IncreasePriceForVendor()
        {
            var products = context.Products
               .Where(p => p.VendorId == 4)
               .ToList();

            Console.WriteLine($"Updated prices for {products.Count} products");
            foreach (var product in products)
            {
                product.Price += 10.00M;
                Console.WriteLine($"New price for {product.Name} will be  {product.Price}");
            }

            context.SaveChanges();
        }

        private static void GetVendorByState()
        {
            var vendors = context.Vendors
               .Where(v => v.State == "OH")
               .OrderBy(v => v.City)
               .ToList();

            Console.WriteLine($"Vendors in Ohio:");
            foreach (var vendor in vendors)
            {
                Console.WriteLine($"{vendor.Name} - {vendor.City}");
            }
        }

        private static void GetProductsWithNullPrices()
        {
            var productsWithoutPrice = context.Products
                .Where(p => p.Price == null)
                .ToList();

            Console.WriteLine($"Products without price: {productsWithoutPrice.Count}");

            foreach (var product in productsWithoutPrice)
            {
                Console.WriteLine($"- {product.Name}");
            }
        }

        private static void ChangeVendorName()
        {
            var vendor = context.Vendors
                .Where(p => p.Name == "FedEx")
                .FirstOrDefault();

            var currentName = vendor.Name;

            vendor.Name = "UPS";
            context.SaveChanges();

            Console.WriteLine($"{currentName} was changed to {vendor.Name}");
        }

        private static void GetProductsUnder100()
        {
            var allProductLessThan100 = context.Products
                .Where(p => p.Price < 100)
                .ToList();

            Console.WriteLine($"{allProductLessThan100.Count} Products under $100");
            foreach (var product in allProductLessThan100)
            {
                Console.WriteLine(product.Name);
            }
        }
        // NOTE about using Last(). Must use OrderBy() first because since SQL tables
        // are unordered by default, EF cannot define what 'last' means
        private static void RemoveLastProduct()
        {
            var lastProduct = context.Products.
                OrderBy(p => p.Id).Last(); //Ascending by default
            context.Products.Remove(lastProduct);

            context.SaveChanges();

            Console.WriteLine($"{lastProduct.Name} was removed");
        }

        private static void RemoveFirstProduct()
        {
            var firstProduct = context.Products.First();
            context.Products.Remove(firstProduct);

            context.SaveChanges();

            Console.WriteLine($"{firstProduct.Name} was removed");
        }

        private static void AddManyProducts()
        {
            var productsToAdd = new Product[]
            {
                    new Product { Name = "Chair", Price = 127.95M, VendorId = 1 },
                    new Product { Name = "Desk", Price = 99.99M, VendorId = 1 },
                    new Product { Name = "Lamp", Price = 50.00M, VendorId = 3 },
                    new Product { Name = "Printer", Price = 35.50M, VendorId = 4 },
                    new Product { Name = "Shredder", Price = 35.80M, VendorId = 4 }

            };
            context.Products.AddRange(productsToAdd);

            context.SaveChanges();

            Console.WriteLine($"{productsToAdd.Length} Products added");
        }
        private static void AddManyVendors()
        {
            var vendorsToAdd = new Vendor[]
            {
                    new Vendor { Name = "Walmart", City = "Cleveland", State = "OH" },
                    new Vendor { Name = "Sears", City = "Charleston", State ="SC" },
                    new Vendor { Name = "Micro Center", City = "Columbus", State = "OH" },
                    new Vendor { Name = "Cabellas", City = "Denver", State = "CO" }

            };
            context.Vendors.AddRange(vendorsToAdd);

            context.SaveChanges();

            Console.WriteLine($"{vendorsToAdd.Length} Vendors added");
        }
        private static void GetAllProductsUsingVendorId()
        {
            var vendorWithProducts = context.Products
                .Where(p => p.VendorId == 3)
                .Include(p => p.Vendor)
                .ToList();

            foreach (var product in vendorWithProducts)
            {
                Console.WriteLine($"{product.Name} - {product.Vendor.Name}");
            }
        }

        private static void AddOneProduct()
        {
            Product product = new Product
            {
                Name = "Guess Shoes",
                Price = 99.99m
            };

            context.Products.Add(product);
            context.SaveChanges();

            Console.WriteLine($"Product {product.Name} added successfully!");
        }

        private static void AddOneVendor()
        {
            Vendor vendor = new Vendor
            {
                Name = "Microsoft",
                City = "Redmond",
                State = "WA"
            };

            context.Vendors.Add(vendor);
            context.SaveChanges();

            Console.WriteLine($"Vendor {vendor.Name} added successfully!");
        }
    }
}

