using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Author @ Abhijith

namespace csharpRestClient1
{
    public enum httpverb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RestClient
    {
        public string endpoint { get; set; } //property to store the URI
        public httpverb httpmethod { get; set; }

        public RestClient() //constructor class
        {
            endpoint = string.Empty;
            httpmethod = httpverb.GET;

        }
        public string makeRequest() //make request method
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);

            request.Method = httpmethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

            {
                if (response.StatusCode != HttpStatusCode.OK)

                {
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());

                }

                //Process the response stream... (could be JSON,XML or HTML)
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();

                        }

                    }//End of StreamReader
                    return strResponseValue;
                }
            }

        }
    }
}
