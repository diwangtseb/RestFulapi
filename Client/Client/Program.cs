using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<IAddress> channelFactory = new ChannelFactory<IAddress>("addressService"))
            {
                IAddress iAddress = channelFactory.CreateChannel();
                Address address = iAddress.Get("210.75.225.254");

                if (address != null)
                {
                    Console.WriteLine(string.Format("IP来自{0}，{1}", address.Province, address.City));
                }
            }
        }
    }
}
