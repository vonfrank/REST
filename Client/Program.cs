using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        public static Post GetData()
        {
            Post jsonPost;
            var url = "http://jsonplaceholder.typicode.com/posts/1";

            //Syncronious consumption
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

            //Create JSON serializer and parse the response
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Post));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                jsonPost = (Post)serializer.ReadObject(ms);
            }
            return jsonPost;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Fetching JSON from http://jsonplaceholder.typicode.com/posts/1...\n");
            Console.WriteLine(GetData().ToString());
            Console.ReadLine();
        }
    }
}
