using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSearchApplication.Models
{
    public class FlickrPhoto
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Media { get; set; }
        public string Date_Taken { get; set; }
        public string Description { get; set; }
        public string Published { get; set; }
        public string Author { get; set; }
        public string Author_Id { get; set; }
        public string Tags { get; set; }
    }
}