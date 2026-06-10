SELECT 'Active' AS Source
    , InvoiceNumber
    , InvoiceDate AS InvoiceDate
    , InvoiceTotal - PaymentTotal - CreditTotal AS Balance
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0
UNION
    SELECT 'Paid' AS Source
    , InvoiceNumber, InvoiceDate AS InvoiceDate
    , InvoiceTotal - PaymentTotal - CreditTotal AS Balance
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal <= 0
ORDER BY Balance DESC;


SELECT 
    CASE 
        WHEN InvoiceTotal - PaymentTotal - CreditTotal > 0 THEN 'Active'
        ELSE 'Paid'
    END AS Source
        ,  InvoiceNumber
        ,  InvoiceDate AS InvoiceDate
        ,  InvoiceTotal - PaymentTotal - CreditTotal AS Balance
FROM Invoices
ORDER BY Balance DESC;
