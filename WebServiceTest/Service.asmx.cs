using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceTest
{    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class Service : System.Web.Services.WebService
    {
        public Service()
        {
            //So remember this .asmx file defines the sourcecode and type of the service
            //.cs file will define the service class and it should inherit from System.Web.Services.WebService
            // All public methods should include the [WebMethod] attribute.

            //Webservices consist of 3 basic parts: 
            //The Provider (HTTP server where the services are hosted)
            //The Registry/Descriptor (where the UDDI is published in WSDL)
            //The Requestor (Client that requests to the WebService by SOAP calls)
        }

        [WebMethod]
        public string Ping()
        {
            return "Pong";
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello Web Service";
        }

        [WebMethod]
        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            return (a + b);
        }

        [WebMethod]
        public System.Single Subtract(System.Single A, System.Single B)
        {
            return (A - B);
        }

        [WebMethod]
        public System.Single Multiply(System.Single A, System.Single B)
        {
            return A * B;
        }

        [WebMethod]
        public System.Single Divide(System.Single A, System.Single B)
        {
            if (B == 0) return -1;
            return Convert.ToSingle(A / B);
        }

        // For more info, you can review this url link: https://www.c-sharpcorner.com/UploadFile/1d42da/web-service-basics/
    }
}