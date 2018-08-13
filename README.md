# code-challenge
Project was written under the ASP.NET MVC and Web API Frameworks
Unfortunately, just not enough time due to work, but here was the plan:
Simple html grid view that initially allows the user to search phrases, etc. (the tags), and then passes that value into the local api as the parameter q. The controller then consumes it as a "get" and utilizes the apiproxy in order to do an asynchronous call and return a JSON formatted object from Flickr. Then the data would be deserialized into our data model (flickphoto, feed). Also, I wanted to do validation based on codes returned back in the controller to display to the user, and this is where I would have been doing most of the unit test cases. Of course, wrap the actual http get calls with try/catch or try/catch/finally if disposing of service... It would have been really cool to do the actual thread pooling to for each http get. 

Thank you for your time
