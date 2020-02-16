using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
   
    public class Service1 : IService1
    {
        public int login(string username, string password)
        {
            return 1;
        }
        public int register(string usernama, string email, string password)
        {
            return 2;
        }
    }
}
