-- CONVERT and FORMAT:
SELECT 'Active' AS Source, InvoiceNumber
, CONVERT(varchar(20), InvoiceDate, 107) AS InvoiceDate
, InvoiceTotal - PaymentTotal - CreditTotal AS Balance
    FROM Invoices
    WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0
UNION
    SELECT 'Paid' AS Source, InvoiceNumber
    , CONVERT(varchar(20), InvoiceDate, 107) AS InvoiceDate
    , InvoiceTotal - PaymentTotal - CreditTotal AS Balance
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal <= 0
ORDER BY Balance DESC;

-- FORMAT Only (avail in SQL Server 2012 and later)
SELECT 'Active' AS Source, InvoiceNumber
    , FORMAT(InvoiceDate, 'dddd, MMMM dd yyyy') AS InvoiceDate
    , InvoiceTotal - PaymentTotal - CreditTotal AS Balance
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0
UNION
SELECT 'Paid' AS Source, InvoiceNumber
     , FORMAT(InvoiceDate, 'dddd, mmmm dd yyyy') AS InvoiceDate
     , InvoiceTotal - PaymentTotal - CreditTotal AS Balance
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal <= 0
ORDER BY Balance DESC;

