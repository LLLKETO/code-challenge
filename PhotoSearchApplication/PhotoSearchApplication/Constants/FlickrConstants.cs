using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoSearchApplication.Constants
{
    public class FlickrConstants
    {
        public const string PhotosApiV1 = "api/v1/FlickrPhotos";
        public const string Uri = "https://api.flickr.com/services/feeds/photos_public.gne?";
        public const string Tags = "tags";
        public const string Id = "id";
        public const string Ids = "ids";
        public const string TagMode = "tagmode";
        public const string Lang = "lang";
        public const string Formatjson = "format=json";
        public const string rootElement = "jsonFlickrApi";
    }
}