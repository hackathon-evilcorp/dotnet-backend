using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_backend.Models
{
    public class PostIt
    {
        public long Id { get; set; }
        public string Creator { get; set; }
        public string Type { get; set; }
        public string Body { get; set; }
        public Fridge Fridge { get; set; }

        public PostIt(long Id, string Type, string Body)
        {
            Creator = null;
            Fridge = null;

            this.Id = Id;
            this.Type = Type;
            this.Body = Body;
        }
    }
}
