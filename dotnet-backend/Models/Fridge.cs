using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_backend.Models
{
    public class Fridge
    {
        public long Id { get; set; }
        public string Admin { get; set; }
        public string FridgeName { get; set; }
        public IList<PostIt> PostIts { get; set; }
        public string Users { get; set; }

        public Fridge(long Id, string Admin, string FridgeName, IList<PostIt> PostIts, string Users)
        {
            this.Id = Id;
            this.Admin = Admin;
            this.FridgeName = FridgeName;
            this.PostIts = PostIts;
            this.Users = Users;
        }
    }
}
