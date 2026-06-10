USE AP
-- 1.
-- Create a query that counts unpaid invoices 
-- and calculates the average of all invoices,
-- and the total due for all invoices that have a balance.
SELECT COUNT(*) AS NumberOfInvoices
	, AVG(InvoiceTotal)
	, SUM(InvoiceTotal) AS TotalDue 
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0;

-- 2.
-- Create a query that counts the number of invoices, 
-- and finds the highest and lowest invoice totals 
-- for invoices dated and after 7/1/2022. 
SELECT COUNT(*) AS NumberOfInvoices
	, MAX(InvoiceTotal) AS HighestInvoiceTotal
	, MIN(InvoiceTotal) AS LowestInvoiceTotal
FROM Invoices WHERE InvoiceDate > '2022-07-01'

-- 3.
-- Create a query that counts the number of 
-- invoices by vendor 
SELECT VendorID
	, COUNT(*) AS InvoiceQty 
FROM Invoices 
GROUP BY VendorID

-- 4.
-- Create a query that counts the total number of invoices
-- and calculates the average invoice total, grouping by 
-- vendor name. Only display vendors with an average invoice
-- total greater than $2000. Sort the results by the number 
-- of invoices in descending order.
-- HINT: This query requires a join to the Vendors table
-- to get the VendorName.
SELECT VendorName
	, COUNT(*) AS InvoiceQty
	, AVG(InvoiceTotal) AS InvoiceAvg 
FROM Vendors v
	INNER JOIN Invoices i
		ON v.VendorID = i.VendorID 
GROUP BY VendorName 
HAVING AVG(InvoiceTotal) > 2000
ORDER BY InvoiceQty DESC



