using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using StockService;

namespace StockService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataSet GetStocks();

        [OperationContract]
        Stock GetStock(int id);
        [OperationContract]
        Boolean AddStock(Stock s);

        [OperationContract]
        Boolean updateStock(Stock s,int id);

        [OperationContract]
        Boolean DeleteStock(int id);
    }
}
