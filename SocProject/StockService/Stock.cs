using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StockService
{
    [DataContract]
    public class Stock
    {
        private int intID;
        private string strLogo;
        private string strListdate;
        private string strCountry;
        private string strIndustry;
        private string strSector;
        private string strMarketcap;
        private string strEmployees;
        private string strPhone;
        private string strCeo;
        private string strUrl;
        private string strDescription;
        private string strExchange;
        private string strName;
        private string strSymbol;
        private string strHq_address;

        [DataMember]
        public int Id { get { return intID; } set { intID = value; } }

        [DataMember]
        public string Logo { get { return strLogo; } set { strLogo = value; } }

        [DataMember]
        public string Listdate { get { return strListdate; } set { strListdate = value; } }

        [DataMember]
        public string Country { get { return strCountry; } set { strCountry = value; } }

        [DataMember]
        public string Industry { get { return strIndustry; } set { strIndustry = value; } }

        [DataMember]
        public string Sector { get { return strSector; } set { strSector = value; } }

        [DataMember]
        public string Marketcap { get { return strMarketcap; } set { strMarketcap = value; } }

        [DataMember]
        public string Employees { get { return strEmployees; } set { strEmployees = value; } }

        [DataMember]
        public string Phone { get { return strPhone; } set { strPhone = value; } }

        [DataMember]
        public string Ceo { get { return strCeo; } set { strCeo = value; } }

        [DataMember]
        public string Url { get { return strUrl; } set { strUrl = value; } }

        [DataMember]
        public string Description { get { return strDescription; } set { strDescription = value; } }

        [DataMember]
        public string Exchange { get { return strExchange; } set { strExchange = value; } }

        [DataMember]
        public string Name { get { return strName; } set { strName = value; } }

        [DataMember]
        public string Symbol { get { return strSymbol; } set { strSymbol = value; } }

        [DataMember]
        public string Hq_address { get { return strHq_address; } set { strHq_address = value; } }
    }
}
