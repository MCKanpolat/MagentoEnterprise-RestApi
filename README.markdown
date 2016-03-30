# MagentoEnterprise.RestApi - An async C# Magento REST API client

[Magento](http://www.magentocommerce.com/) is an open source ecommerce platform that allows external applications to interact with it by a SOAP API or REST API. [The REST API](http://www.magentocommerce.com/api/rest/introduction.html) is only available from release 1.7 of Magento. The client only uses the REST API (= no SOAP calls). It also has not been tested with Magento Enterprise 2.x

MagentoEnterprise.RestApi was forked from the exelent project by @nickvane [nickvane/Magento-RestApi](https://github.com/nickvane/Magento-RestApi). The client is specifically targeted to be used in background processes. Magento REST API uses OAuth 1.0a to retrieve an access token. Because it is not very useful to pop up browser windows from a background process (like a windows service) for the user to enter username and password, the client uses an authentication method originally developed in on [nickvane/Magento-RestApi](https://github.com/nickvane/Magento-RestApi) that simulates the login process without opening browser windows.

A manager has been implemented on top of this to handle expiration or invalidation of the access tokens. When this happens, updated access token is obtained using the username and password.

[Available from nuget: MagentoEnterprise.RestApi](#) (Comming Soon)

### Usage
#### Authentication

For the following code to work the REST user and roles have to be configured in Magento (see http://www.magentocommerce.com/api/rest/permission_settings/roles_configuration.html ). To obtain the access token pair from Magento 1.x the oAuth workflow must be followed once with an Admin:

```csharp
var client = new MagentoApi(new ApiSettings(){
		Url = "http://www.yourmagentourl.com",
                UserName = "UserName",
                Password = "Password",
                ConsumerKey = "ConsumerKey",
                ConsumerSecret = "ConsumerSecret"
	});
```
Once you have authenticated you can save the OAuth access token pair via:

```csharp
var accessTokenKey = client.Settings.AccessKey;
var accessTokenSecret = client.Settings.AccessSecret;
```

The OAuth access token pair can then be provided to the client directly. 

```csharp
var clientManager = new MagentoApiManager(new ApiSettings()
            {
                Url = "http://www.yourmagentourl.com",
                AccessKey = "AccessTokenKey",
                AccessSecret = "AccessTokenSecret"
            });
```
The client can be used with a user that isn't an admin. However the authentication flow currently only works with admin users so you must get the oAuth access token pair seperately. Some have reported obvious limited functionality when not using an admin user.

#### Managed Client calls

Once you have an oAuth access token pair, the client can then be used like this:

```csharp
// refrence the instance
var client = clientManager.ApiClient;
// in an async method
var response = await client.GetProductBySku("123456");
// not async
response = client.GetProductBySku("123456").Result;
// The response contains the result or errors
if (!response.HasErrors)
{
    var product = response.Result;
}
```

### Features

* Can be used in multiple threads
* Keeps track of changed properties so only changed values are updated
* If OAuth token is rejected after some time, the client re-authenticates and executes the failed request again if you supplied username and password for a admin user.

Following Magento REST API features are currently implemented:

* Inventory
* Products
	* Product Categories
	* Product Images
	* Product Websites
* Customers
* Customer Addresses 
* Orders
	* Order Comments
	* Order Addresses
	* Order Items

For the supported features and usage of the library take a look at the integration tests.

### Troubleshooting
#### Authentication

If you are having issues with Authentication you may find the wiki page about [authentication steps](https://github.com/nickvane/Magento-RestApi/wiki/Authentication-steps) helpful for information about the different steps in the authentication process. You can then compare the steps from the page with your own requests you see in [Fiddler](http://fiddler2.com).*

If you are having trouble authenticating to an SSL-secured Magento instance, one failure reason may be the security policy setup on the web server. Many web servers may block SSLv3 because of vulnerabilities like POODLE. However, .NET defaults the `System.Net.ServicePointManager.SecurityProtocol` to be `System.Net.SecurityProtocolType.Ssl3`. To fix this, simply set your application's default to a matching protocol type for your web server instance. For instance, for web servers that require TLSv1.2 for the latest security recommendations, you would set your policy before your authentication call like:

```csharp
System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
```

### More info

The library is tested against Magento versions:

* 1.14.2.2
* 1.7.0.*: all actions tested
* 1.9.1.*: authentication tested

Support for .net framework 4.5 and higher due to usage of async/await keywords.
As of 13/05/2015 support for dnx451 target framework. dnxcore50 currently unavailable due to 

* dependencies not yet available for dnxcore50 (RestSharp, HtmlAgility)
* certain parts of BCL not yet ported to dnxcore50
