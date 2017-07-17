using System;
using System.IO;
using System.Net;
using System.Text;

namespace SYW.GB
{
    public class CallsInvoker
    {
        /// <summary>
        /// Invoke a /products/search call for the given uri
        /// </summary>
        /// <param name="uri">the cpmplete call's syntax</param>
        /// <returns>The calls' response (string)</returns>
        public string Invoke(string uri)
        {
            WebRequest request = WebRequest.Create(uri);
            var response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String responseString = reader.ReadToEnd();
                return (responseString);
            }

        }
    }
}