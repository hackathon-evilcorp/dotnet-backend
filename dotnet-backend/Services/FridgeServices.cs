using dotnet_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_backend.Services
{
    public class FridgeServices
    {
        public static IList<PostIt> MockedPostIts()
        {
            IList<PostIt> mockedPosts = new List<PostIt>();
            PostIt p1 = new PostIt(1, "shopItem", "Buy 8 onions");
            PostIt p2 = new PostIt(1, "message", "Wash the dishes");
            PostIt p3 = new PostIt(1, "shopItem", "Buy a new laptop");
            PostIt p4 = new PostIt(1, "shopItem", "Buy everything");
            mockedPosts.Add(p1);
            mockedPosts.Add(p2);
            mockedPosts.Add(p3);
            mockedPosts.Add(p4);
            return mockedPosts;
        }

        public static IList<Fridge> MockedFridges()
        {
            IList<Fridge> mockedFridges = new List<Fridge>();
            Fridge f1 = new Fridge(1, "én", "Cucleee fridge", MockedPostIts(), null);
            Fridge f2 = new Fridge(2, "Adél", "Whatever fridge", MockedPostIts(), null);
            mockedFridges.Add(f1);
            mockedFridges.Add(f2);
            return mockedFridges;
        }

        public IEnumerable<Fridge> GetAllFridges()
        {
            return MockedFridges();
        }
    }
}
