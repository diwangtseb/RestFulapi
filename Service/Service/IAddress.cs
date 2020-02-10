using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;

namespace Service.Interface
{
    [ServiceContract]
    public interface IAddress
    {
        [WebGet(UriTemplate = "ip={ip}",ResponseFormat =WebMessageFormat.Json)]
        Address Get(string ip);
    }

    [DataContract]
    public class Address
    {
        [DataMember]
        public string IPAddress { get; set; }

        [DataMember]
        public string Province { get; set; }

        [DataMember]
        public string City { get; set; }
    }
}