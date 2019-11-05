# IO.Swagger.Api.UserApi

All URIs are relative to *http://dev-colorphone-service.appcloudbox.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserProfile**](UserApi.md#getuserprofile) | **GET** /user/{user_id}/profile | UserProfile
[**PutUserProfile**](UserApi.md#putuserprofile) | **PUT** /user/{user_id}/profile | UserProfile
[**Userlogin**](UserApi.md#userlogin) | **POST** /user/login | UserLogin


<a name="getuserprofile"></a>
# **GetUserProfile**
> LoginResponse GetUserProfile (string xColorPhoneSessionToken, string xColorPhoneSignature, string userId)

UserProfile

UserProfile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserProfileExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var xColorPhoneSessionToken = xColorPhoneSessionToken_example;  // string | Token
            var xColorPhoneSignature = xColorPhoneSignature_example;  // string | Signature
            var userId = userId_example;  // string | 

            try
            {
                // UserProfile
                LoginResponse result = apiInstance.GetUserProfile(xColorPhoneSessionToken, xColorPhoneSignature, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetUserProfile: " + e.Message );
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

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putuserprofile"></a>
# **PutUserProfile**
> string PutUserProfile (string userId, string name, string gender, string birthday, string signature, System.IO.Stream headImage, string xColorPhoneSessionToken = null, string xColorPhoneSignature = null)

UserProfile

UserProfile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutUserProfileExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var userId = userId_example;  // string | 
            var name = name_example;  // string | user login ,only support wechat
            var gender = gender_example;  // string | user login ,only support wechat
            var birthday = birthday_example;  // string | user login ,only support wechat
            var signature = signature_example;  // string | user login ,only support wechat
            var headImage = new System.IO.Stream(); // System.IO.Stream | user login ,only support wechat
            var xColorPhoneSessionToken = xColorPhoneSessionToken_example;  // string | Token (optional) 
            var xColorPhoneSignature = xColorPhoneSignature_example;  // string | Signature (optional) 

            try
            {
                // UserProfile
                string result = apiInstance.PutUserProfile(userId, name, gender, birthday, signature, headImage, xColorPhoneSessionToken, xColorPhoneSignature);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.PutUserProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **name** | **string**| user login ,only support wechat | 
 **gender** | **string**| user login ,only support wechat | 
 **birthday** | **string**| user login ,only support wechat | 
 **signature** | **string**| user login ,only support wechat | 
 **headImage** | **System.IO.Stream**| user login ,only support wechat | 
 **xColorPhoneSessionToken** | **string**| Token | [optional] 
 **xColorPhoneSignature** | **string**| Signature | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userlogin"></a>
# **Userlogin**
> LoginResponse Userlogin (string xColorPhoneSignature, LoginRequest body)

UserLogin

user login

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UserloginExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var xColorPhoneSignature = xColorPhoneSignature_example;  // string | Signature
            var body = new LoginRequest(); // LoginRequest | user login ,only support wechat

            try
            {
                // UserLogin
                LoginResponse result = apiInstance.Userlogin(xColorPhoneSignature, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.Userlogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xColorPhoneSignature** | **string**| Signature | 
 **body** | [**LoginRequest**](LoginRequest.md)| user login ,only support wechat | 

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

