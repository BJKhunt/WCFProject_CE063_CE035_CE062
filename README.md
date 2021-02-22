# WCFProject_CE063_CE035_CE062


we have two solution folder: SocProject for WCFService

                             StockClient for client


as client we have use windows form to use service..


In WcfServiceLibrary we implemented IService1 and its implementations Service1, which contains CRUD OperationContract method...
Database1.mdf(StockService) is our database file.


In client we have 3 forms and 1st form represent all the stocks in listbox and buttons for doing operation on particular selected stock.
2nd form represent the stock info(like its profile page)
3rd form represent create and update related form...




Configuration for Starting Project :


-> firstof download zip file of the project and extract it...

-> you required visual stdio for opening .sln file.

-> you need two visual stdio tab for (1.service 2.client)

-> in service you have to need new databse connection and browse database file as SocProject/StockService/Database1.mdf

-> after that run the service as administration and our service listening at address "http://localhost:8733/Design_Time_Addresses/StockService/Service1/"

-> you can verify by enter address in your browser and also check WSDL file

-> in client side you have to just open StockClient.sln in visual stdio and just run it..



-> our service uses basicHttpBinding...

  ->This binding uses HTTP as the transport and text/XML as the default message encoding.
  
  ->Security is disabled by default.
  
