--1. Write a query to list the invoice number and the 
--  vendor name for all invoices.
USE AP;

SELECT InvoiceNumber, VendorName
FROM Vendors v
    INNER JOIN Invoices i
        ON v.VendorID = i.VendorID;

--2. Write a query to list the invoice number, the vendor name, and the invoice total for all invoices.
SELECT InvoiceNumber, VendorName, InvoiceTotal
FROM Vendors v
    INNER JOIN Invoices i
        ON v.VendorID = i.VendorID;

--3. Change query 2 to only diplay invoice totals greater than $500.
SELECT InvoiceNumber, VendorName, InvoiceTotal
FROM Vendors 
    INNER JOIN Invoices
        ON Vendors.VendorID = Invoices.VendorID
WHERE InvoiceTotal > 500;

--4. Change above query to display invoice total greater than $500 and less than $1000.
SELECT InvoiceNumber, VendorName, InvoiceTotal
FROM Vendors 
    INNER JOIN Invoices
        on Vendors.VendorID = Invoices.VendorID
where InvoiceTotal > 500 and InvoiceTotal < 1000;

--5. Write a query to list the invoice number, the vendor name, and the invoice total for showing 
--all vendors and their invoices, including those vendors that do not have any invoices. 
--Sort results by vendor name.
SELECT VendorName, InvoiceNumber, InvoiceTotal
FROM Vendors v
    LEFT OUTER JOIN Invoices i 
        ON v.VendorID = i.VendorID 
ORDER BY VendorName; 

--6. Write a query to list the invoice number, the vendor name, and the invoice total for showing all invoices, 
--including invoices that do not have a vendor association. Sort the results by vendor name.
SELECT VendorName, InvoiceNumber, InvoiceTotal
FROM Vendors v
    RIGHT OUTER JOIN Invoices i 
        ON v.VendorID = i.VendorID 
ORDER BY VendorName; --all invoices have a related vendor which is why you don't see any null values in the VendorName column.

--7. Write a query to list the invoice number, the vendor name, and the invoice total to show
--each row in the Vendors table in the result set, along with each row in the Invoices table. 
--Sort the results by vendor name.
--HINT: Use a FULL OUTER JOIN to include all rows from both tables
SELECT VendorName, InvoiceNumber, InvoiceTotal
FROM Vendors v
    FULL OUTER JOIN Invoices i 
        ON v.VendorID = i.VendorID 
ORDER BY VendorName;

--8. Write an SQL query that uses a UNION operator to combine the results of two separate queries, 
--one for active invoices and one for paid invoices.
--The query should categorize invoices as 'Active' if the balance is greater than zero and 'Paid' if the balance is zero or less.
--THe result set should have 4 columns: Source (with a value of 'Active' or 'Paid'), InvoiceNumber, InvoiceDate, and Balance.
--The balance is calculated as the invoice total minus the payment total minus the credit total. 
--Sort the results by balance in descending order.

SELECT 'Active' AS Source, InvoiceNumber, InvoiceDate, InvoiceTotal - PaymentTotal - CreditTotal AS Balance
    FROM Invoices
    WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0
UNION
    SELECT 'Paid' AS Source, InvoiceNumber, InvoiceDate, InvoiceTotal - PaymentTotal - CreditTotal AS Balance
    FROM Invoices
    WHERE InvoiceTotal - PaymentTotal - CreditTotal <= 0
ORDER BY Balance DESC;

--9. Convert the InvoiceDate column in the above query to a different date format (e.g., 'MM/DD/YYYY') in the result set of the previous query.
SELECT 'Active' AS Source, InvoiceNumber, CONVERT(varchar(20), InvoiceDate, 107) AS InvoiceDate, InvoiceTotal - PaymentTotal - CreditTotal AS Balance
    FROM Invoices
    WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0
UNION
    SELECT 'Paid' AS Source, InvoiceNumber, CONVERT(varchar(20), InvoiceDate, 107) AS InvoiceDate, InvoiceTotal - PaymentTotal - CreditTotal AS Balance
    FROM Invoices
    WHERE InvoiceTotal - PaymentTotal - CreditTotal <= 0
ORDER BY Balance DESC;


--Equivalent query using a CASE statement instead of UNION
SELECT 
    CASE 
        WHEN InvoiceTotal - PaymentTotal - CreditTotal > 0 THEN 'Active'
        ELSE 'Paid'
    END AS Source,
    InvoiceNumber,
    InvoiceDate,
    InvoiceTotal - PaymentTotal - CreditTotal AS Balance
FROM Invoices
ORDER BY Balance DESC;
