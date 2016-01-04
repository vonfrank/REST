using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [DataContract]
    class Post
    {
        [DataMember]
        int userId { get; set; }
        [DataMember]
        int id { get; set; }
        [DataMember]
        string title { get; set; }
        [DataMember]
        string body { get; set; }

        public string ToString()
        {
            return "User ID: " + userId.ToString() + "\nID: " + id.ToString() + "\nTitle: " + title + "\nBody: " + body;
        }
    }
}
