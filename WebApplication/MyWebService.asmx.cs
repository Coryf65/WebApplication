using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication
{
    /// <summary>
    /// Practicing using SOAP and creating a webservice!
    /// This is the Web Server side
    /// </summary>
    /// 

    // Reccomended to use your domain name in URI Namespace="Cory.com"
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double addNumbers(double value1, double value2)
        {
            return value1 + value2;

        }
    }
}
