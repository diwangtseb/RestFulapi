using Service.Interface;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Xml.Serialization;

namespace Service
{
    public class AddressService : IAddress
    {
        private static IList<Address> addresses = new List<Address>();

        static AddressService()
        {
            //这里可以准备一个IP地址库并放入到IP地址列表中，以提供数据服务  
            addresses.Add(new Address() { IPAddress = "210.75.225.254", Province = "上海市", City = "上海市" });
        }

        public Address Get(string ipAddress)
        {
            return addresses.FirstOrDefault(x => x.IPAddress == ipAddress);
        }
    }
}