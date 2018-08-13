using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestSharp;
using RestSharp.Authenticators;
using PhotoSearchApplication.Models;
using PhotoSearchApplication.Proxys;

namespace PhotoSearchApplication.Controllers
{
    //unit test this controller
    [RoutePrefix(Constants.FlickrConstants.PhotosApiV1)]
    public class FlickrPhotosController : ApiController
    {
        private IFlickrApiProxy _flickrProxy { get; }

        public FlickrPhotosController(IFlickrApiProxy flickrProxy)
        {
            _flickrProxy = flickrProxy;
        }
        // GET api/values
        public string Get(string q)
        {
            JsonFlickrFeed flickrFeedModel = new JsonFlickrFeed();
            flickrFeedModel = _flickrProxy.GetTagFeed(q);
            //Need to serve up the model now for front end rendering
            //Also, need to have a list of the error codes / ok codes from our response packet
            //Then we can output relevant info to user to let them know if the server is up or not
            //We can make an asynchronous call so that it will either wait and load or hypothetically go do other stuff in the "app"
            return "";
        }
    }
}
