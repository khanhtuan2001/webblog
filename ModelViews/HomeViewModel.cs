using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webblog.Models;

namespace Webblog.ModelViews
{
    public class HomeViewModel
    {
        public List<Post> Populars { get; set; }
        public List<Post> Inspiration { get; set; }
        public List<Post> Recents { get; set; }
        public List<Post> Trending { get; set; }
        public List<Post> LatestPosts { get; set; }
        public Post Fetured { get; set; }
    }
}
