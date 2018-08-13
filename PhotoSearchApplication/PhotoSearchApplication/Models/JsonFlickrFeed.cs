using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSearchApplication.Models
{
    public class JsonFlickrFeed
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Modified { get; set; }
        public string Generator { get; set; }
        public FlickrPhoto[] Items { get; set; }
    }
}