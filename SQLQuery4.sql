Declare @JSON varchar(max)
SELECT @JSON=BulkColumn
FROM OPENROWSET (BULK 'C:\Users\Brijesh\Documents\GitHub\Stock-Market-System\server\fundastock.json', SINGLE_CLOB) import
SELECT * INTO Stock
FROM OPENJSON (@JSON)
WITH 
(
    [logo] varchar(max), 
    [listdate] varchar(max), 
    [country] varchar(max), 
    [industry] varchar(max), 
    [sector] varchar(max), 
    [marketcap] varchar(max), 
    [employees] varchar(max), 
    [phone] varchar(max),
    [ceo] varchar(max),
    [url] varchar(max),
    [description] varchar(max),
    [exchange] varchar(max),
    [name] varchar(max),
    [symbol] varchar(max),
    [hq_address] varchar(max)
)