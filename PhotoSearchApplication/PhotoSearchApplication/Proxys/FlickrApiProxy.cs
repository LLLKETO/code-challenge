using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using PhotoSearchApplication.Constants;
using PhotoSearchApplication.Models;
namespace PhotoSearchApplication.Proxys
{
    public class FlickrApiProxy : BaseApiProxy, IFlickrApiProxy
    {
        public JsonFlickrFeed GetTagFeed(string searchString)
        {
            var request = new RestRequest();
            //fix this to grab proper format via this object
            //request.AddParameter(FlickrConstants.Tags, searchString);
            //Fix currently grabbing xml and not proper json for deserializing and storing in model

            try
            {
                var tempurl = FlickrConstants.Uri + FlickrConstants.Tags + "=" + searchString + "&" + FlickrConstants.Formatjson;
                return Execute<JsonFlickrFeed>(request, tempurl);
            }
            catch (Exception e)
            {
                throw new Exception("proxy failed to retrieve data", e);
            }
        }
    }
}