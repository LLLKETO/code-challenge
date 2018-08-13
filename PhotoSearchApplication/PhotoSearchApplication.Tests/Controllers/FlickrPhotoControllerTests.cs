using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhotoSearchApplication;
using PhotoSearchApplication.Controllers;

namespace PhotoSearchApplication.Tests.Controllers
{
    [TestClass]
    public class FlickrPhotoControllerTests
    {

        //Ideally test all of the different return values from our HTTP get
        //Since we are using a proxy pattern and it is interfaces we can mock it out and create our own return values
        //We would just need a helper method in this test class that constructs our jsonflickrfeed and flickrphoto models for testing
        //Then in our controller we should be validating our responses so we know if missing info, how many items, etc.
        [TestInitialize]
        public void TestInitialize()
        {

        }
        [TestMethod]
        public void TestGetTags()
        {

        }
    }
}
