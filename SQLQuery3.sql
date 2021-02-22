Declare @JSON varchar(max)
SELECT @JSON=BulkColumn
FROM OPENROWSET (BULK 'C:\Users\Brijesh\Documents\GitHub\Stock-Market-System\server\fundastock.json', SINGLE_CLOB) import
SELECT *
FROM OPENJSON (@JSON)