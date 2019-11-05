# IO.Swagger.Api.ShowsApi

All URIs are relative to *http://dev-colorphone-service.appcloudbox.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUploadShows**](ShowsApi.md#deleteuploadshows) | **DELETE** /user/{user_id}/uploaded_shows | get shows
[**GetReviewedUploadShows**](ShowsApi.md#getrevieweduploadshows) | **GET** /user/{user_id}/reviewed_shows | get review shows
[**GetShows**](ShowsApi.md#getshows) | **GET** /shows | shows
[**GetUploadShows**](ShowsApi.md#getuploadshows) | **GET** /user/{user_id}/uploaded_shows | get shows
[**UploadShows**](ShowsApi.md#uploadshows) | **POST** /user/{user_id}/uploaded_shows | upload shows


<a name="deleteuploadshows"></a>
# **DeleteUploadShows**
> string DeleteUploadShows (string xColorPhoneSessionToken, string xColorPhoneSignature, string userId, ShowIdLists showIdLists)

get shows

get shows

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUploadShowsExample
    {
        public void main()
        {
            var apiInstance = new ShowsApi();
            var xColorPhoneSessionToken = xColorPhoneSessionToken_example;  // string | Token
            var xColorPhoneSignature = xColorPhoneSignature_example;  // string | Signature
            var userId = userId_example;  // string | 
            var showIdLists = new ShowIdLists(); // ShowIdLists | 

            try
            {
                // get shows
                string result = apiInstance.DeleteUploadShows(xColorPhoneSessionToken, xColorPhoneSignature, userId, showIdLists);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShowsApi.DeleteUploadShows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xColorPhoneSessionToken** | **string**| Token | 
 **xColorPhoneSignature** | **string**| Signature | 
 **userId** | **string**|  | 
 **showIdLists** | [**ShowIdLists**](ShowIdLists.md)|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrevieweduploadshows"></a>
# **GetReviewedUploadShows**
> InlineResponse200 GetReviewedUploadShows (string xColorPhoneSessionToken, string xColorPhoneSignature, string userId, Requestbody2 requestbody)

get review shows

get review shows

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReviewedUploadShowsExample
    {
        public void main()
        {
            var apiInstance = new ShowsApi();
            var xColorPhoneSessionToken = xColorPhoneSessionToken_example;  // string | Token
            var xColorPhoneSignature = xColorPhoneSignature_example;  // string | Signature
            var userId = userId_example;  // string | 
            var requestbody = new Requestbody2(); // Requestbody2 | 

            try
            {
                // get review shows
                InlineResponse200 result = apiInstance.GetReviewedUploadShows(xColorPhoneSessionToken, xColorPhoneSignature, userId, requestbody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShowsApi.GetReviewedUploadShows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xColorPhoneSessionToken** | **string**| Token | 
 **xColorPhoneSignature** | **string**| Signature | 
 **userId** | **string**|  | 
 **requestbody** | [**Requestbody2**](Requestbody2.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getshows"></a>
# **GetShows**
> ShowListResponse GetShows (string xColorPhoneSignature, Requestbody requestbody)

shows

shows

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetShowsExample
    {
        public void main()
        {
            var apiInstance = new ShowsApi();
            var xColorPhoneSignature = xColorPhoneSignature_example;  // string | Signature
            var requestbody = new Requestbody(); // Requestbody | 

            try
            {
                // shows
                ShowListResponse result = apiInstance.GetShows(xColorPhoneSignature, requestbody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShowsApi.GetShows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xColorPhoneSignature** | **string**| Signature | 
 **requestbody** | [**Requestbody**](Requestbody.md)|  | 

### Return type

[**ShowListResponse**](ShowListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuploadshows"></a>
# **GetUploadShows**
> InlineResponse200 GetUploadShows (string xColorPhoneSessionToken, string xColorPhoneSignature, string userId, Requestbody1 requestbody)

get shows

get shows

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUploadShowsExample
    {
        public void main()
        {
            var apiInstance = new ShowsApi();
            var xColorPhoneSessionToken = xColorPhoneSessionToken_example;  // string | Token
            var xColorPhoneSignature = xColorPhoneSignature_example;  // string | Signature
            var userId = userId_example;  // string | 
            var requestbody = new Requestbody1(); // Requestbody1 | 

            try
            {
                // get shows
                InlineResponse200 result = apiInstance.GetUploadShows(xColorPhoneSessionToken, xColorPhoneSignature, userId, requestbody);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShowsApi.GetUploadShows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xColorPhoneSessionToken** | **string**| Token | 
 **xColorPhoneSignature** | **string**| Signature | 
 **userId** | **string**|  | 
 **requestbody** | [**Requestbody1**](Requestbody1.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadshows"></a>
# **UploadShows**
> string UploadShows (string xColorPhoneSessionToken, string xColorPhoneSignature, string userId, string fileName, System.IO.Stream videoFile, System.IO.Stream audioFile, System.IO.Stream imageFile)

upload shows

upload shows

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadShowsExample
    {
        public void main()
        {
            var apiInstance = new ShowsApi();
            var xColorPhoneSessionToken = xColorPhoneSessionToken_example;  // string | Token
            var xColorPhoneSignature = xColorPhoneSignature_example;  // string | Signature
            var userId = userId_example;  // string | 
            var fileName = fileName_example;  // string | user login ,only support wechat
            var videoFile = new System.IO.Stream(); // System.IO.Stream | user login ,only support wechat
            var audioFile = new System.IO.Stream(); // System.IO.Stream | user login ,only support wechat
            var imageFile = new System.IO.Stream(); // System.IO.Stream | user login ,only support wechat

            try
            {
                // upload shows
                string result = apiInstance.UploadShows(xColorPhoneSessionToken, xColorPhoneSignature, userId, fileName, videoFile, audioFile, imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShowsApi.UploadShows: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xColorPhoneSessionToken** | **string**| Token | 
 **xColorPhoneSignature** | **string**| Signature | 
 **userId** | **string**|  | 
 **fileName** | **string**| user login ,only support wechat | 
 **videoFile** | **System.IO.Stream**| user login ,only support wechat | 
 **audioFile** | **System.IO.Stream**| user login ,only support wechat | 
 **imageFile** | **System.IO.Stream**| user login ,only support wechat | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

