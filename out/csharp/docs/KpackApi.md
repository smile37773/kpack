# Org.OpenAPITools.Api.KpackApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBuild**](KpackApi.md#createbuild) | **POST** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builds | 
[**CreateBuilder**](KpackApi.md#createbuilder) | **POST** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builders | 
[**CreateClusterBuilder**](KpackApi.md#createclusterbuilder) | **POST** /apis/kpack.io/v1alpha1/clusterbuilders | 
[**CreateClusterStack**](KpackApi.md#createclusterstack) | **POST** /apis/kpack.io/v1alpha1/clusterstacks | 
[**CreateClusterStore**](KpackApi.md#createclusterstore) | **POST** /apis/kpack.io/v1alpha1/clusterstores | 
[**CreateImage**](KpackApi.md#createimage) | **POST** /apis/kpack.io/v1alpha1/namespaces/{namespace}/images | 
[**CreateSourceResolver**](KpackApi.md#createsourceresolver) | **POST** /apis/kpack.io/v1alpha1/namespaces/{namespace}/sourceresolvers | 
[**DeleteBuild**](KpackApi.md#deletebuild) | **DELETE** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builds/{name} | 
[**DeleteBuilder**](KpackApi.md#deletebuilder) | **DELETE** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builders/{name} | 
[**DeleteClusterBuilder**](KpackApi.md#deleteclusterbuilder) | **DELETE** /apis/kpack.io/v1alpha1/clusterbuilders/{name} | 
[**DeleteClusterStack**](KpackApi.md#deleteclusterstack) | **DELETE** /apis/kpack.io/v1alpha1/clusterstacks/{name} | 
[**DeleteClusterStore**](KpackApi.md#deleteclusterstore) | **DELETE** /apis/kpack.io/v1alpha1/clusterstores/{name} | 
[**DeleteImage**](KpackApi.md#deleteimage) | **DELETE** /apis/kpack.io/v1alpha1/namespaces/{namespace}/images/{name} | 
[**DeleteSourceResolver**](KpackApi.md#deletesourceresolver) | **DELETE** /apis/kpack.io/v1alpha1/namespaces/{namespace}/sourceresolvers/{name} | 
[**GetBuild**](KpackApi.md#getbuild) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builds/{name} | 
[**GetBuildStatus**](KpackApi.md#getbuildstatus) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builds/{name}/status | 
[**GetBuilder**](KpackApi.md#getbuilder) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builders/{name} | 
[**GetBuilderStatus**](KpackApi.md#getbuilderstatus) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builders/{name}/status | 
[**GetClusterBuilder**](KpackApi.md#getclusterbuilder) | **GET** /apis/kpack.io/v1alpha1/clusterbuilders/{name} | 
[**GetClusterBuilderStatus**](KpackApi.md#getclusterbuilderstatus) | **GET** /apis/kpack.io/v1alpha1/clusterbuilders/{name}/status | 
[**GetClusterStack**](KpackApi.md#getclusterstack) | **GET** /apis/kpack.io/v1alpha1/clusterstacks/{name} | 
[**GetClusterStackStatus**](KpackApi.md#getclusterstackstatus) | **GET** /apis/kpack.io/v1alpha1/clusterstacks/{name}/status | 
[**GetClusterStore**](KpackApi.md#getclusterstore) | **GET** /apis/kpack.io/v1alpha1/clusterstores/{name} | 
[**GetClusterStoreStatus**](KpackApi.md#getclusterstorestatus) | **GET** /apis/kpack.io/v1alpha1/clusterstores/{name}/status | 
[**GetImage**](KpackApi.md#getimage) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/images/{name} | 
[**GetImageStatus**](KpackApi.md#getimagestatus) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/images/{name}/status | 
[**GetSourceResolver**](KpackApi.md#getsourceresolver) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/sourceresolvers/{name} | 
[**GetSourceResolverStatus**](KpackApi.md#getsourceresolverstatus) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/sourceresolvers/{name}/status | 
[**ListAllBuilders**](KpackApi.md#listallbuilders) | **GET** /apis/kpack.io/v1alpha1/builders | 
[**ListAllBuilds**](KpackApi.md#listallbuilds) | **GET** /apis/kpack.io/v1alpha1/builds | 
[**ListAllClusterbuilders**](KpackApi.md#listallclusterbuilders) | **GET** /apis/kpack.io/v1alpha1/clusterbuilders | 
[**ListAllClusterstacks**](KpackApi.md#listallclusterstacks) | **GET** /apis/kpack.io/v1alpha1/clusterstacks | 
[**ListAllClusterstores**](KpackApi.md#listallclusterstores) | **GET** /apis/kpack.io/v1alpha1/clusterstores | 
[**ListAllImages**](KpackApi.md#listallimages) | **GET** /apis/kpack.io/v1alpha1/images | 
[**ListAllSourceresolvers**](KpackApi.md#listallsourceresolvers) | **GET** /apis/kpack.io/v1alpha1/sourceresolvers | 
[**ListNamespacedBuilders**](KpackApi.md#listnamespacedbuilders) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builders | 
[**ListNamespacedBuilds**](KpackApi.md#listnamespacedbuilds) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builds | 
[**ListNamespacedImages**](KpackApi.md#listnamespacedimages) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/images | 
[**ListNamespacedSourceresolvers**](KpackApi.md#listnamespacedsourceresolvers) | **GET** /apis/kpack.io/v1alpha1/namespaces/{namespace}/sourceresolvers | 
[**PatchBuild**](KpackApi.md#patchbuild) | **PATCH** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builds/{name} | 
[**PatchBuildStatus**](KpackApi.md#patchbuildstatus) | **PATCH** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builds/{name}/status | 
[**PatchBuilder**](KpackApi.md#patchbuilder) | **PATCH** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builders/{name} | 
[**PatchBuilderStatus**](KpackApi.md#patchbuilderstatus) | **PATCH** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builders/{name}/status | 
[**PatchClusterBuilder**](KpackApi.md#patchclusterbuilder) | **PATCH** /apis/kpack.io/v1alpha1/clusterbuilders/{name} | 
[**PatchClusterBuilderStatus**](KpackApi.md#patchclusterbuilderstatus) | **PATCH** /apis/kpack.io/v1alpha1/clusterbuilders/{name}/status | 
[**PatchClusterStack**](KpackApi.md#patchclusterstack) | **PATCH** /apis/kpack.io/v1alpha1/clusterstacks/{name} | 
[**PatchClusterStackStatus**](KpackApi.md#patchclusterstackstatus) | **PATCH** /apis/kpack.io/v1alpha1/clusterstacks/{name}/status | 
[**PatchClusterStore**](KpackApi.md#patchclusterstore) | **PATCH** /apis/kpack.io/v1alpha1/clusterstores/{name} | 
[**PatchClusterStoreStatus**](KpackApi.md#patchclusterstorestatus) | **PATCH** /apis/kpack.io/v1alpha1/clusterstores/{name}/status | 
[**PatchImage**](KpackApi.md#patchimage) | **PATCH** /apis/kpack.io/v1alpha1/namespaces/{namespace}/images/{name} | 
[**PatchImageStatus**](KpackApi.md#patchimagestatus) | **PATCH** /apis/kpack.io/v1alpha1/namespaces/{namespace}/images/{name}/status | 
[**PatchSourceResolver**](KpackApi.md#patchsourceresolver) | **PATCH** /apis/kpack.io/v1alpha1/namespaces/{namespace}/sourceresolvers/{name} | 
[**PatchSourceResolverStatus**](KpackApi.md#patchsourceresolverstatus) | **PATCH** /apis/kpack.io/v1alpha1/namespaces/{namespace}/sourceresolvers/{name}/status | 
[**ReplaceBuild**](KpackApi.md#replacebuild) | **PUT** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builds/{name} | 
[**ReplaceBuildStatus**](KpackApi.md#replacebuildstatus) | **PUT** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builds/{name}/status | 
[**ReplaceBuilder**](KpackApi.md#replacebuilder) | **PUT** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builders/{name} | 
[**ReplaceBuilderStatus**](KpackApi.md#replacebuilderstatus) | **PUT** /apis/kpack.io/v1alpha1/namespaces/{namespace}/builders/{name}/status | 
[**ReplaceClusterBuilder**](KpackApi.md#replaceclusterbuilder) | **PUT** /apis/kpack.io/v1alpha1/clusterbuilders/{name} | 
[**ReplaceClusterBuilderStatus**](KpackApi.md#replaceclusterbuilderstatus) | **PUT** /apis/kpack.io/v1alpha1/clusterbuilders/{name}/status | 
[**ReplaceClusterStack**](KpackApi.md#replaceclusterstack) | **PUT** /apis/kpack.io/v1alpha1/clusterstacks/{name} | 
[**ReplaceClusterStackStatus**](KpackApi.md#replaceclusterstackstatus) | **PUT** /apis/kpack.io/v1alpha1/clusterstacks/{name}/status | 
[**ReplaceClusterStore**](KpackApi.md#replaceclusterstore) | **PUT** /apis/kpack.io/v1alpha1/clusterstores/{name} | 
[**ReplaceClusterStoreStatus**](KpackApi.md#replaceclusterstorestatus) | **PUT** /apis/kpack.io/v1alpha1/clusterstores/{name}/status | 
[**ReplaceImage**](KpackApi.md#replaceimage) | **PUT** /apis/kpack.io/v1alpha1/namespaces/{namespace}/images/{name} | 
[**ReplaceImageStatus**](KpackApi.md#replaceimagestatus) | **PUT** /apis/kpack.io/v1alpha1/namespaces/{namespace}/images/{name}/status | 
[**ReplaceSourceResolver**](KpackApi.md#replacesourceresolver) | **PUT** /apis/kpack.io/v1alpha1/namespaces/{namespace}/sourceresolvers/{name} | 
[**ReplaceSourceResolverStatus**](KpackApi.md#replacesourceresolverstatus) | **PUT** /apis/kpack.io/v1alpha1/namespaces/{namespace}/sourceresolvers/{name}/status | 



## CreateBuild

> KpackBuildV1alpha1Build CreateBuild (string _namespace, KpackBuildV1alpha1Build body, string pretty = null)



Creates a namespace scoped Build

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBuildExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var body = new KpackBuildV1alpha1Build(); // KpackBuildV1alpha1Build | The JSON schema of the Resource to create.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                KpackBuildV1alpha1Build result = apiInstance.CreateBuild(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.CreateBuild: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **body** | [**KpackBuildV1alpha1Build**](KpackBuildV1alpha1Build.md)| The JSON schema of the Resource to create. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**KpackBuildV1alpha1Build**](KpackBuildV1alpha1Build.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateBuilder

> KpackBuildV1alpha1Builder CreateBuilder (string _namespace, KpackBuildV1alpha1Builder body, string pretty = null)



Creates a namespace scoped Builder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateBuilderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var body = new KpackBuildV1alpha1Builder(); // KpackBuildV1alpha1Builder | The JSON schema of the Resource to create.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                KpackBuildV1alpha1Builder result = apiInstance.CreateBuilder(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.CreateBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **body** | [**KpackBuildV1alpha1Builder**](KpackBuildV1alpha1Builder.md)| The JSON schema of the Resource to create. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**KpackBuildV1alpha1Builder**](KpackBuildV1alpha1Builder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateClusterBuilder

> KpackBuildV1alpha1ClusterBuilder CreateClusterBuilder (KpackBuildV1alpha1ClusterBuilder body, string pretty = null)



Creates a cluster scoped ClusterBuilder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateClusterBuilderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var body = new KpackBuildV1alpha1ClusterBuilder(); // KpackBuildV1alpha1ClusterBuilder | The JSON schema of the Resource to create.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                KpackBuildV1alpha1ClusterBuilder result = apiInstance.CreateClusterBuilder(body, pretty);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.CreateClusterBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**KpackBuildV1alpha1ClusterBuilder**](KpackBuildV1alpha1ClusterBuilder.md)| The JSON schema of the Resource to create. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**KpackBuildV1alpha1ClusterBuilder**](KpackBuildV1alpha1ClusterBuilder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateClusterStack

> KpackBuildV1alpha1ClusterStack CreateClusterStack (KpackBuildV1alpha1ClusterStack body, string pretty = null)



Creates a cluster scoped ClusterStack

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateClusterStackExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var body = new KpackBuildV1alpha1ClusterStack(); // KpackBuildV1alpha1ClusterStack | The JSON schema of the Resource to create.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                KpackBuildV1alpha1ClusterStack result = apiInstance.CreateClusterStack(body, pretty);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.CreateClusterStack: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**KpackBuildV1alpha1ClusterStack**](KpackBuildV1alpha1ClusterStack.md)| The JSON schema of the Resource to create. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**KpackBuildV1alpha1ClusterStack**](KpackBuildV1alpha1ClusterStack.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateClusterStore

> KpackBuildV1alpha1ClusterStore CreateClusterStore (KpackBuildV1alpha1ClusterStore body, string pretty = null)



Creates a cluster scoped ClusterStore

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateClusterStoreExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var body = new KpackBuildV1alpha1ClusterStore(); // KpackBuildV1alpha1ClusterStore | The JSON schema of the Resource to create.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                KpackBuildV1alpha1ClusterStore result = apiInstance.CreateClusterStore(body, pretty);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.CreateClusterStore: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**KpackBuildV1alpha1ClusterStore**](KpackBuildV1alpha1ClusterStore.md)| The JSON schema of the Resource to create. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**KpackBuildV1alpha1ClusterStore**](KpackBuildV1alpha1ClusterStore.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateImage

> KpackBuildV1alpha1Image CreateImage (string _namespace, KpackBuildV1alpha1Image body, string pretty = null)



Creates a namespace scoped Image

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var body = new KpackBuildV1alpha1Image(); // KpackBuildV1alpha1Image | The JSON schema of the Resource to create.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                KpackBuildV1alpha1Image result = apiInstance.CreateImage(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.CreateImage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **body** | [**KpackBuildV1alpha1Image**](KpackBuildV1alpha1Image.md)| The JSON schema of the Resource to create. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**KpackBuildV1alpha1Image**](KpackBuildV1alpha1Image.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateSourceResolver

> KpackBuildV1alpha1SourceResolver CreateSourceResolver (string _namespace, KpackBuildV1alpha1SourceResolver body, string pretty = null)



Creates a namespace scoped SourceResolver

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateSourceResolverExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var body = new KpackBuildV1alpha1SourceResolver(); // KpackBuildV1alpha1SourceResolver | The JSON schema of the Resource to create.
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                KpackBuildV1alpha1SourceResolver result = apiInstance.CreateSourceResolver(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.CreateSourceResolver: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **body** | [**KpackBuildV1alpha1SourceResolver**](KpackBuildV1alpha1SourceResolver.md)| The JSON schema of the Resource to create. | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**KpackBuildV1alpha1SourceResolver**](KpackBuildV1alpha1SourceResolver.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteBuild

> IoK8sApimachineryPkgApisMetaV1Status DeleteBuild (string _namespace, string name, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null, IoK8sApimachineryPkgApisMetaV1DeleteOptions body = null)



Deletes the specified namespace scoped Build

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteBuildExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 
            var body = new IoK8sApimachineryPkgApisMetaV1DeleteOptions(); // IoK8sApimachineryPkgApisMetaV1DeleteOptions |  (optional) 

            try
            {
                IoK8sApimachineryPkgApisMetaV1Status result = apiInstance.DeleteBuild(_namespace, name, gracePeriodSeconds, orphanDependents, propagationPolicy, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.DeleteBuild: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. | [optional] 
 **propagationPolicy** | **string**| Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. | [optional] 
 **body** | [**IoK8sApimachineryPkgApisMetaV1DeleteOptions**](IoK8sApimachineryPkgApisMetaV1DeleteOptions.md)|  | [optional] 

### Return type

[**IoK8sApimachineryPkgApisMetaV1Status**](IoK8sApimachineryPkgApisMetaV1Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteBuilder

> IoK8sApimachineryPkgApisMetaV1Status DeleteBuilder (string _namespace, string name, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null, IoK8sApimachineryPkgApisMetaV1DeleteOptions body = null)



Deletes the specified namespace scoped Builder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteBuilderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 
            var body = new IoK8sApimachineryPkgApisMetaV1DeleteOptions(); // IoK8sApimachineryPkgApisMetaV1DeleteOptions |  (optional) 

            try
            {
                IoK8sApimachineryPkgApisMetaV1Status result = apiInstance.DeleteBuilder(_namespace, name, gracePeriodSeconds, orphanDependents, propagationPolicy, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.DeleteBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. | [optional] 
 **propagationPolicy** | **string**| Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. | [optional] 
 **body** | [**IoK8sApimachineryPkgApisMetaV1DeleteOptions**](IoK8sApimachineryPkgApisMetaV1DeleteOptions.md)|  | [optional] 

### Return type

[**IoK8sApimachineryPkgApisMetaV1Status**](IoK8sApimachineryPkgApisMetaV1Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteClusterBuilder

> IoK8sApimachineryPkgApisMetaV1Status DeleteClusterBuilder (string name, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null, IoK8sApimachineryPkgApisMetaV1DeleteOptions body = null)



Deletes the specified cluster scoped ClusterBuilder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteClusterBuilderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 
            var body = new IoK8sApimachineryPkgApisMetaV1DeleteOptions(); // IoK8sApimachineryPkgApisMetaV1DeleteOptions |  (optional) 

            try
            {
                IoK8sApimachineryPkgApisMetaV1Status result = apiInstance.DeleteClusterBuilder(name, gracePeriodSeconds, orphanDependents, propagationPolicy, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.DeleteClusterBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. | [optional] 
 **propagationPolicy** | **string**| Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. | [optional] 
 **body** | [**IoK8sApimachineryPkgApisMetaV1DeleteOptions**](IoK8sApimachineryPkgApisMetaV1DeleteOptions.md)|  | [optional] 

### Return type

[**IoK8sApimachineryPkgApisMetaV1Status**](IoK8sApimachineryPkgApisMetaV1Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteClusterStack

> IoK8sApimachineryPkgApisMetaV1Status DeleteClusterStack (string name, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null, IoK8sApimachineryPkgApisMetaV1DeleteOptions body = null)



Deletes the specified cluster scoped ClusterStack

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteClusterStackExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 
            var body = new IoK8sApimachineryPkgApisMetaV1DeleteOptions(); // IoK8sApimachineryPkgApisMetaV1DeleteOptions |  (optional) 

            try
            {
                IoK8sApimachineryPkgApisMetaV1Status result = apiInstance.DeleteClusterStack(name, gracePeriodSeconds, orphanDependents, propagationPolicy, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.DeleteClusterStack: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. | [optional] 
 **propagationPolicy** | **string**| Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. | [optional] 
 **body** | [**IoK8sApimachineryPkgApisMetaV1DeleteOptions**](IoK8sApimachineryPkgApisMetaV1DeleteOptions.md)|  | [optional] 

### Return type

[**IoK8sApimachineryPkgApisMetaV1Status**](IoK8sApimachineryPkgApisMetaV1Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteClusterStore

> IoK8sApimachineryPkgApisMetaV1Status DeleteClusterStore (string name, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null, IoK8sApimachineryPkgApisMetaV1DeleteOptions body = null)



Deletes the specified cluster scoped ClusterStore

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteClusterStoreExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 
            var body = new IoK8sApimachineryPkgApisMetaV1DeleteOptions(); // IoK8sApimachineryPkgApisMetaV1DeleteOptions |  (optional) 

            try
            {
                IoK8sApimachineryPkgApisMetaV1Status result = apiInstance.DeleteClusterStore(name, gracePeriodSeconds, orphanDependents, propagationPolicy, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.DeleteClusterStore: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. | [optional] 
 **propagationPolicy** | **string**| Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. | [optional] 
 **body** | [**IoK8sApimachineryPkgApisMetaV1DeleteOptions**](IoK8sApimachineryPkgApisMetaV1DeleteOptions.md)|  | [optional] 

### Return type

[**IoK8sApimachineryPkgApisMetaV1Status**](IoK8sApimachineryPkgApisMetaV1Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteImage

> IoK8sApimachineryPkgApisMetaV1Status DeleteImage (string _namespace, string name, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null, IoK8sApimachineryPkgApisMetaV1DeleteOptions body = null)



Deletes the specified namespace scoped Image

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 
            var body = new IoK8sApimachineryPkgApisMetaV1DeleteOptions(); // IoK8sApimachineryPkgApisMetaV1DeleteOptions |  (optional) 

            try
            {
                IoK8sApimachineryPkgApisMetaV1Status result = apiInstance.DeleteImage(_namespace, name, gracePeriodSeconds, orphanDependents, propagationPolicy, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.DeleteImage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. | [optional] 
 **propagationPolicy** | **string**| Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. | [optional] 
 **body** | [**IoK8sApimachineryPkgApisMetaV1DeleteOptions**](IoK8sApimachineryPkgApisMetaV1DeleteOptions.md)|  | [optional] 

### Return type

[**IoK8sApimachineryPkgApisMetaV1Status**](IoK8sApimachineryPkgApisMetaV1Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSourceResolver

> IoK8sApimachineryPkgApisMetaV1Status DeleteSourceResolver (string _namespace, string name, int? gracePeriodSeconds = null, bool? orphanDependents = null, string propagationPolicy = null, IoK8sApimachineryPkgApisMetaV1DeleteOptions body = null)



Deletes the specified namespace scoped SourceResolver

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteSourceResolverExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both. (optional) 
            var propagationPolicy = propagationPolicy_example;  // string | Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. (optional) 
            var body = new IoK8sApimachineryPkgApisMetaV1DeleteOptions(); // IoK8sApimachineryPkgApisMetaV1DeleteOptions |  (optional) 

            try
            {
                IoK8sApimachineryPkgApisMetaV1Status result = apiInstance.DeleteSourceResolver(_namespace, name, gracePeriodSeconds, orphanDependents, propagationPolicy, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.DeleteSourceResolver: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. Either this field or PropagationPolicy may be set, but not both. | [optional] 
 **propagationPolicy** | **string**| Whether and how garbage collection will be performed. Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. | [optional] 
 **body** | [**IoK8sApimachineryPkgApisMetaV1DeleteOptions**](IoK8sApimachineryPkgApisMetaV1DeleteOptions.md)|  | [optional] 

### Return type

[**IoK8sApimachineryPkgApisMetaV1Status**](IoK8sApimachineryPkgApisMetaV1Status.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetBuild

> KpackBuildV1alpha1Build GetBuild (string _namespace, string name)



Returns a namespace scoped custom object

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBuildExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1Build result = apiInstance.GetBuild(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetBuild: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1Build**](KpackBuildV1alpha1Build.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A single Resource |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetBuildStatus

> KpackBuildV1alpha1Build GetBuildStatus (string _namespace, string name)



read status of the specified namespace scoped Build

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBuildStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1Build result = apiInstance.GetBuildStatus(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetBuildStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1Build**](KpackBuildV1alpha1Build.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetBuilder

> KpackBuildV1alpha1Builder GetBuilder (string _namespace, string name)



Returns a namespace scoped custom object

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBuilderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1Builder result = apiInstance.GetBuilder(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1Builder**](KpackBuildV1alpha1Builder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A single Resource |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetBuilderStatus

> KpackBuildV1alpha1Builder GetBuilderStatus (string _namespace, string name)



read status of the specified namespace scoped Builder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBuilderStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1Builder result = apiInstance.GetBuilderStatus(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetBuilderStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1Builder**](KpackBuildV1alpha1Builder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetClusterBuilder

> KpackBuildV1alpha1ClusterBuilder GetClusterBuilder (string name)



Returns a cluster scoped ClusterBuilder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetClusterBuilderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1ClusterBuilder result = apiInstance.GetClusterBuilder(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetClusterBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1ClusterBuilder**](KpackBuildV1alpha1ClusterBuilder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetClusterBuilderStatus

> KpackBuildV1alpha1ClusterBuilder GetClusterBuilderStatus (string name)



read status of the specified cluster scoped ClusterBuilder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetClusterBuilderStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1ClusterBuilder result = apiInstance.GetClusterBuilderStatus(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetClusterBuilderStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1ClusterBuilder**](KpackBuildV1alpha1ClusterBuilder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetClusterStack

> KpackBuildV1alpha1ClusterStack GetClusterStack (string name)



Returns a cluster scoped ClusterStack

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetClusterStackExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1ClusterStack result = apiInstance.GetClusterStack(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetClusterStack: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1ClusterStack**](KpackBuildV1alpha1ClusterStack.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetClusterStackStatus

> KpackBuildV1alpha1ClusterStack GetClusterStackStatus (string name)



read status of the specified cluster scoped ClusterStack

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetClusterStackStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1ClusterStack result = apiInstance.GetClusterStackStatus(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetClusterStackStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1ClusterStack**](KpackBuildV1alpha1ClusterStack.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetClusterStore

> KpackBuildV1alpha1ClusterStore GetClusterStore (string name)



Returns a cluster scoped ClusterStore

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetClusterStoreExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1ClusterStore result = apiInstance.GetClusterStore(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetClusterStore: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1ClusterStore**](KpackBuildV1alpha1ClusterStore.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetClusterStoreStatus

> KpackBuildV1alpha1ClusterStore GetClusterStoreStatus (string name)



read status of the specified cluster scoped ClusterStore

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetClusterStoreStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1ClusterStore result = apiInstance.GetClusterStoreStatus(name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetClusterStoreStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1ClusterStore**](KpackBuildV1alpha1ClusterStore.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetImage

> KpackBuildV1alpha1Image GetImage (string _namespace, string name)



Returns a namespace scoped custom object

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1Image result = apiInstance.GetImage(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetImage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1Image**](KpackBuildV1alpha1Image.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A single Resource |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetImageStatus

> KpackBuildV1alpha1Image GetImageStatus (string _namespace, string name)



read status of the specified namespace scoped Image

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetImageStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1Image result = apiInstance.GetImageStatus(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetImageStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1Image**](KpackBuildV1alpha1Image.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSourceResolver

> KpackBuildV1alpha1SourceResolver GetSourceResolver (string _namespace, string name)



Returns a namespace scoped custom object

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSourceResolverExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1SourceResolver result = apiInstance.GetSourceResolver(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetSourceResolver: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1SourceResolver**](KpackBuildV1alpha1SourceResolver.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A single Resource |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetSourceResolverStatus

> KpackBuildV1alpha1SourceResolver GetSourceResolverStatus (string _namespace, string name)



read status of the specified namespace scoped SourceResolver

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSourceResolverStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name

            try
            {
                KpackBuildV1alpha1SourceResolver result = apiInstance.GetSourceResolverStatus(_namespace, name);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.GetSourceResolverStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 

### Return type

[**KpackBuildV1alpha1SourceResolver**](KpackBuildV1alpha1SourceResolver.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAllBuilders

> KpackBuildV1alpha1BuilderList ListAllBuilders (string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch builders

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAllBuildersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1BuilderList result = apiInstance.ListAllBuilders(pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListAllBuilders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1BuilderList**](KpackBuildV1alpha1BuilderList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAllBuilds

> KpackBuildV1alpha1BuildList ListAllBuilds (string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch builds

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAllBuildsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1BuildList result = apiInstance.ListAllBuilds(pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListAllBuilds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1BuildList**](KpackBuildV1alpha1BuildList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAllClusterbuilders

> KpackBuildV1alpha1ClusterBuilderList ListAllClusterbuilders (string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch cluster scoped clusterbuilders

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAllClusterbuildersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1ClusterBuilderList result = apiInstance.ListAllClusterbuilders(pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListAllClusterbuilders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1ClusterBuilderList**](KpackBuildV1alpha1ClusterBuilderList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAllClusterstacks

> KpackBuildV1alpha1ClusterStackList ListAllClusterstacks (string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch cluster scoped clusterstacks

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAllClusterstacksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1ClusterStackList result = apiInstance.ListAllClusterstacks(pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListAllClusterstacks: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1ClusterStackList**](KpackBuildV1alpha1ClusterStackList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAllClusterstores

> KpackBuildV1alpha1ClusterStoreList ListAllClusterstores (string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch cluster scoped clusterstores

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAllClusterstoresExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1ClusterStoreList result = apiInstance.ListAllClusterstores(pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListAllClusterstores: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1ClusterStoreList**](KpackBuildV1alpha1ClusterStoreList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAllImages

> KpackBuildV1alpha1ImageList ListAllImages (string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch images

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAllImagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1ImageList result = apiInstance.ListAllImages(pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListAllImages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1ImageList**](KpackBuildV1alpha1ImageList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAllSourceresolvers

> KpackBuildV1alpha1SourceResolverList ListAllSourceresolvers (string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch sourceresolvers

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAllSourceresolversExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1SourceResolverList result = apiInstance.ListAllSourceresolvers(pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListAllSourceresolvers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1SourceResolverList**](KpackBuildV1alpha1SourceResolverList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListNamespacedBuilders

> KpackBuildV1alpha1BuilderList ListNamespacedBuilders (string _namespace, string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch namespace scoped builders

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListNamespacedBuildersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1BuilderList result = apiInstance.ListNamespacedBuilders(_namespace, pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListNamespacedBuilders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1BuilderList**](KpackBuildV1alpha1BuilderList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListNamespacedBuilds

> KpackBuildV1alpha1BuildList ListNamespacedBuilds (string _namespace, string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch namespace scoped builds

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListNamespacedBuildsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1BuildList result = apiInstance.ListNamespacedBuilds(_namespace, pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListNamespacedBuilds: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1BuildList**](KpackBuildV1alpha1BuildList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListNamespacedImages

> KpackBuildV1alpha1ImageList ListNamespacedImages (string _namespace, string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch namespace scoped images

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListNamespacedImagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1ImageList result = apiInstance.ListNamespacedImages(_namespace, pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListNamespacedImages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1ImageList**](KpackBuildV1alpha1ImageList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListNamespacedSourceresolvers

> KpackBuildV1alpha1SourceResolverList ListNamespacedSourceresolvers (string _namespace, string pretty = null, string _continue = null, string fieldSelector = null, string labelSelector = null, int? limit = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch namespace scoped sourceresolvers

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListNamespacedSourceresolversExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var _continue = _continue_example;  // string | The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \"next key\".  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var limit = 56;  // int? | limit is a maximum number of responses to return for a list call. If more items exist, the server will set the 'continue' field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it's 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. (optional) 

            try
            {
                KpackBuildV1alpha1SourceResolverList result = apiInstance.ListNamespacedSourceresolvers(_namespace, pretty, _continue, fieldSelector, labelSelector, limit, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ListNamespacedSourceresolvers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **_continue** | **string**| The continue option should be set when retrieving more results from the server. Since this value is server defined, clients may only use the continue value from a previous query result with identical query parameters (except for the value of continue) and the server may reject a continue value it does not recognize. If the specified continue value is no longer valid whether due to expiration (generally five to fifteen minutes) or a configuration change on the server, the server will respond with a 410 ResourceExpired error together with a continue token. If the client needs a consistent list, it must restart their list without the continue field. Otherwise, the client may send another list request with the token received with the 410 error, the server will respond with a list starting from the next key, but from the latest snapshot, which is inconsistent from the previous list results - objects that are created, modified, or deleted after the first list request will be included in the response, as long as their keys are after the \&quot;next key\&quot;.  This field is not supported when watch is true. Clients may start a watch from the last resourceVersion value returned by the server and not miss any modifications. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **limit** | **int?**| limit is a maximum number of responses to return for a list call. If more items exist, the server will set the &#39;continue&#39; field on the list metadata to a value that can be used with the same initial query to retrieve the next set of results. Setting a limit may return fewer than the requested amount of items (up to zero items) in the event all requested objects are filtered out and clients should only use the presence of the continue field to determine whether more results are available. Servers may choose not to support the limit argument and will return all of the available results. If limit is specified and the continue field is empty, clients may assume that no more results are available. This field is not supported if watch is true.  The server guarantees that the objects returned when using continue will be identical to issuing a single list call without a limit - that is, no objects created, modified, or deleted after the first request is issued will be included in any subsequent continued requests. This is sometimes referred to as a consistent snapshot, and ensures that a client that is using limit to receive smaller chunks of a very large result can ensure they see all possible objects. If objects are updated during a chunked list the version of the object that was present at the time the first list result was calculated is returned. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. When specified for list: - if unset, then the result is returned from remote storage based on quorum-read flag; - if it&#39;s 0, then we simply return what we currently have in cache, no guarantee; - if set to non zero, then the result is at least as fresh as given rv. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. This limits the duration of the call, regardless of any activity or inactivity. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. | [optional] 

### Return type

[**KpackBuildV1alpha1SourceResolverList**](KpackBuildV1alpha1SourceResolverList.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/json;stream=watch

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchBuild

> KpackBuildV1alpha1Build PatchBuild (string _namespace, string name, Object body)



patch the specified namespace scoped Build

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchBuildExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | The JSON schema of the Resource to patch.

            try
            {
                KpackBuildV1alpha1Build result = apiInstance.PatchBuild(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchBuild: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**| The JSON schema of the Resource to patch. | 

### Return type

[**KpackBuildV1alpha1Build**](KpackBuildV1alpha1Build.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchBuildStatus

> KpackBuildV1alpha1Build PatchBuildStatus (string _namespace, string name, Object body)



partially update status of the specified namespace scoped Build

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchBuildStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | 

            try
            {
                KpackBuildV1alpha1Build result = apiInstance.PatchBuildStatus(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchBuildStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**|  | 

### Return type

[**KpackBuildV1alpha1Build**](KpackBuildV1alpha1Build.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchBuilder

> KpackBuildV1alpha1Builder PatchBuilder (string _namespace, string name, Object body)



patch the specified namespace scoped Builder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchBuilderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | The JSON schema of the Resource to patch.

            try
            {
                KpackBuildV1alpha1Builder result = apiInstance.PatchBuilder(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**| The JSON schema of the Resource to patch. | 

### Return type

[**KpackBuildV1alpha1Builder**](KpackBuildV1alpha1Builder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchBuilderStatus

> KpackBuildV1alpha1Builder PatchBuilderStatus (string _namespace, string name, Object body)



partially update status of the specified namespace scoped Builder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchBuilderStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | 

            try
            {
                KpackBuildV1alpha1Builder result = apiInstance.PatchBuilderStatus(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchBuilderStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**|  | 

### Return type

[**KpackBuildV1alpha1Builder**](KpackBuildV1alpha1Builder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchClusterBuilder

> KpackBuildV1alpha1ClusterBuilder PatchClusterBuilder (string name, Object body)



patch the specified cluster scoped ClusterBuilder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchClusterBuilderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | The JSON schema of the Resource to patch.

            try
            {
                KpackBuildV1alpha1ClusterBuilder result = apiInstance.PatchClusterBuilder(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchClusterBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**| The JSON schema of the Resource to patch. | 

### Return type

[**KpackBuildV1alpha1ClusterBuilder**](KpackBuildV1alpha1ClusterBuilder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchClusterBuilderStatus

> KpackBuildV1alpha1ClusterBuilder PatchClusterBuilderStatus (string name, Object body)



partially update status of the specified cluster scoped ClusterBuilder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchClusterBuilderStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | 

            try
            {
                KpackBuildV1alpha1ClusterBuilder result = apiInstance.PatchClusterBuilderStatus(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchClusterBuilderStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**|  | 

### Return type

[**KpackBuildV1alpha1ClusterBuilder**](KpackBuildV1alpha1ClusterBuilder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchClusterStack

> KpackBuildV1alpha1ClusterStack PatchClusterStack (string name, Object body)



patch the specified cluster scoped ClusterStack

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchClusterStackExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | The JSON schema of the Resource to patch.

            try
            {
                KpackBuildV1alpha1ClusterStack result = apiInstance.PatchClusterStack(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchClusterStack: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**| The JSON schema of the Resource to patch. | 

### Return type

[**KpackBuildV1alpha1ClusterStack**](KpackBuildV1alpha1ClusterStack.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchClusterStackStatus

> KpackBuildV1alpha1ClusterStack PatchClusterStackStatus (string name, Object body)



partially update status of the specified cluster scoped ClusterStack

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchClusterStackStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | 

            try
            {
                KpackBuildV1alpha1ClusterStack result = apiInstance.PatchClusterStackStatus(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchClusterStackStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**|  | 

### Return type

[**KpackBuildV1alpha1ClusterStack**](KpackBuildV1alpha1ClusterStack.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchClusterStore

> KpackBuildV1alpha1ClusterStore PatchClusterStore (string name, Object body)



patch the specified cluster scoped ClusterStore

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchClusterStoreExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | The JSON schema of the Resource to patch.

            try
            {
                KpackBuildV1alpha1ClusterStore result = apiInstance.PatchClusterStore(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchClusterStore: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**| The JSON schema of the Resource to patch. | 

### Return type

[**KpackBuildV1alpha1ClusterStore**](KpackBuildV1alpha1ClusterStore.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchClusterStoreStatus

> KpackBuildV1alpha1ClusterStore PatchClusterStoreStatus (string name, Object body)



partially update status of the specified cluster scoped ClusterStore

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchClusterStoreStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | 

            try
            {
                KpackBuildV1alpha1ClusterStore result = apiInstance.PatchClusterStoreStatus(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchClusterStoreStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**|  | 

### Return type

[**KpackBuildV1alpha1ClusterStore**](KpackBuildV1alpha1ClusterStore.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchImage

> KpackBuildV1alpha1Image PatchImage (string _namespace, string name, Object body)



patch the specified namespace scoped Image

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | The JSON schema of the Resource to patch.

            try
            {
                KpackBuildV1alpha1Image result = apiInstance.PatchImage(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchImage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**| The JSON schema of the Resource to patch. | 

### Return type

[**KpackBuildV1alpha1Image**](KpackBuildV1alpha1Image.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchImageStatus

> KpackBuildV1alpha1Image PatchImageStatus (string _namespace, string name, Object body)



partially update status of the specified namespace scoped Image

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchImageStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | 

            try
            {
                KpackBuildV1alpha1Image result = apiInstance.PatchImageStatus(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchImageStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**|  | 

### Return type

[**KpackBuildV1alpha1Image**](KpackBuildV1alpha1Image.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchSourceResolver

> KpackBuildV1alpha1SourceResolver PatchSourceResolver (string _namespace, string name, Object body)



patch the specified namespace scoped SourceResolver

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchSourceResolverExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | The JSON schema of the Resource to patch.

            try
            {
                KpackBuildV1alpha1SourceResolver result = apiInstance.PatchSourceResolver(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchSourceResolver: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**| The JSON schema of the Resource to patch. | 

### Return type

[**KpackBuildV1alpha1SourceResolver**](KpackBuildV1alpha1SourceResolver.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchSourceResolverStatus

> KpackBuildV1alpha1SourceResolver PatchSourceResolverStatus (string _namespace, string name, Object body)



partially update status of the specified namespace scoped SourceResolver

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchSourceResolverStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = ;  // Object | 

            try
            {
                KpackBuildV1alpha1SourceResolver result = apiInstance.PatchSourceResolverStatus(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.PatchSourceResolverStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | **Object**|  | 

### Return type

[**KpackBuildV1alpha1SourceResolver**](KpackBuildV1alpha1SourceResolver.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/merge-patch+json
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceBuild

> KpackBuildV1alpha1Build ReplaceBuild (string _namespace, string name, KpackBuildV1alpha1Build body)



replace the specified namespace scoped custom object

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceBuildExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1Build(); // KpackBuildV1alpha1Build | The JSON schema of the Resource to replace.

            try
            {
                KpackBuildV1alpha1Build result = apiInstance.ReplaceBuild(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceBuild: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1Build**](KpackBuildV1alpha1Build.md)| The JSON schema of the Resource to replace. | 

### Return type

[**KpackBuildV1alpha1Build**](KpackBuildV1alpha1Build.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceBuildStatus

> KpackBuildV1alpha1Build ReplaceBuildStatus (string _namespace, string name, KpackBuildV1alpha1Build body)



replace status of the specified namespace scoped Build

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceBuildStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1Build(); // KpackBuildV1alpha1Build | 

            try
            {
                KpackBuildV1alpha1Build result = apiInstance.ReplaceBuildStatus(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceBuildStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1Build**](KpackBuildV1alpha1Build.md)|  | 

### Return type

[**KpackBuildV1alpha1Build**](KpackBuildV1alpha1Build.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceBuilder

> KpackBuildV1alpha1Builder ReplaceBuilder (string _namespace, string name, KpackBuildV1alpha1Builder body)



replace the specified namespace scoped custom object

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceBuilderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1Builder(); // KpackBuildV1alpha1Builder | The JSON schema of the Resource to replace.

            try
            {
                KpackBuildV1alpha1Builder result = apiInstance.ReplaceBuilder(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1Builder**](KpackBuildV1alpha1Builder.md)| The JSON schema of the Resource to replace. | 

### Return type

[**KpackBuildV1alpha1Builder**](KpackBuildV1alpha1Builder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceBuilderStatus

> KpackBuildV1alpha1Builder ReplaceBuilderStatus (string _namespace, string name, KpackBuildV1alpha1Builder body)



replace status of the specified namespace scoped Builder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceBuilderStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1Builder(); // KpackBuildV1alpha1Builder | 

            try
            {
                KpackBuildV1alpha1Builder result = apiInstance.ReplaceBuilderStatus(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceBuilderStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1Builder**](KpackBuildV1alpha1Builder.md)|  | 

### Return type

[**KpackBuildV1alpha1Builder**](KpackBuildV1alpha1Builder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceClusterBuilder

> KpackBuildV1alpha1ClusterBuilder ReplaceClusterBuilder (string name, KpackBuildV1alpha1ClusterBuilder body)



replace the specified cluster scoped ClusterBuilder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceClusterBuilderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1ClusterBuilder(); // KpackBuildV1alpha1ClusterBuilder | The JSON schema of the Resource to replace.

            try
            {
                KpackBuildV1alpha1ClusterBuilder result = apiInstance.ReplaceClusterBuilder(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceClusterBuilder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1ClusterBuilder**](KpackBuildV1alpha1ClusterBuilder.md)| The JSON schema of the Resource to replace. | 

### Return type

[**KpackBuildV1alpha1ClusterBuilder**](KpackBuildV1alpha1ClusterBuilder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceClusterBuilderStatus

> KpackBuildV1alpha1ClusterBuilder ReplaceClusterBuilderStatus (string name, KpackBuildV1alpha1ClusterBuilder body)



replace status of the specified cluster scoped ClusterBuilder

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceClusterBuilderStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1ClusterBuilder(); // KpackBuildV1alpha1ClusterBuilder | 

            try
            {
                KpackBuildV1alpha1ClusterBuilder result = apiInstance.ReplaceClusterBuilderStatus(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceClusterBuilderStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1ClusterBuilder**](KpackBuildV1alpha1ClusterBuilder.md)|  | 

### Return type

[**KpackBuildV1alpha1ClusterBuilder**](KpackBuildV1alpha1ClusterBuilder.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceClusterStack

> KpackBuildV1alpha1ClusterStack ReplaceClusterStack (string name, KpackBuildV1alpha1ClusterStack body)



replace the specified cluster scoped ClusterStack

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceClusterStackExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1ClusterStack(); // KpackBuildV1alpha1ClusterStack | The JSON schema of the Resource to replace.

            try
            {
                KpackBuildV1alpha1ClusterStack result = apiInstance.ReplaceClusterStack(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceClusterStack: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1ClusterStack**](KpackBuildV1alpha1ClusterStack.md)| The JSON schema of the Resource to replace. | 

### Return type

[**KpackBuildV1alpha1ClusterStack**](KpackBuildV1alpha1ClusterStack.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceClusterStackStatus

> KpackBuildV1alpha1ClusterStack ReplaceClusterStackStatus (string name, KpackBuildV1alpha1ClusterStack body)



replace status of the specified cluster scoped ClusterStack

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceClusterStackStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1ClusterStack(); // KpackBuildV1alpha1ClusterStack | 

            try
            {
                KpackBuildV1alpha1ClusterStack result = apiInstance.ReplaceClusterStackStatus(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceClusterStackStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1ClusterStack**](KpackBuildV1alpha1ClusterStack.md)|  | 

### Return type

[**KpackBuildV1alpha1ClusterStack**](KpackBuildV1alpha1ClusterStack.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceClusterStore

> KpackBuildV1alpha1ClusterStore ReplaceClusterStore (string name, KpackBuildV1alpha1ClusterStore body)



replace the specified cluster scoped ClusterStore

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceClusterStoreExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1ClusterStore(); // KpackBuildV1alpha1ClusterStore | The JSON schema of the Resource to replace.

            try
            {
                KpackBuildV1alpha1ClusterStore result = apiInstance.ReplaceClusterStore(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceClusterStore: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1ClusterStore**](KpackBuildV1alpha1ClusterStore.md)| The JSON schema of the Resource to replace. | 

### Return type

[**KpackBuildV1alpha1ClusterStore**](KpackBuildV1alpha1ClusterStore.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceClusterStoreStatus

> KpackBuildV1alpha1ClusterStore ReplaceClusterStoreStatus (string name, KpackBuildV1alpha1ClusterStore body)



replace status of the specified cluster scoped ClusterStore

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceClusterStoreStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1ClusterStore(); // KpackBuildV1alpha1ClusterStore | 

            try
            {
                KpackBuildV1alpha1ClusterStore result = apiInstance.ReplaceClusterStoreStatus(name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceClusterStoreStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1ClusterStore**](KpackBuildV1alpha1ClusterStore.md)|  | 

### Return type

[**KpackBuildV1alpha1ClusterStore**](KpackBuildV1alpha1ClusterStore.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceImage

> KpackBuildV1alpha1Image ReplaceImage (string _namespace, string name, KpackBuildV1alpha1Image body)



replace the specified namespace scoped custom object

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1Image(); // KpackBuildV1alpha1Image | The JSON schema of the Resource to replace.

            try
            {
                KpackBuildV1alpha1Image result = apiInstance.ReplaceImage(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceImage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1Image**](KpackBuildV1alpha1Image.md)| The JSON schema of the Resource to replace. | 

### Return type

[**KpackBuildV1alpha1Image**](KpackBuildV1alpha1Image.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceImageStatus

> KpackBuildV1alpha1Image ReplaceImageStatus (string _namespace, string name, KpackBuildV1alpha1Image body)



replace status of the specified namespace scoped Image

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceImageStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1Image(); // KpackBuildV1alpha1Image | 

            try
            {
                KpackBuildV1alpha1Image result = apiInstance.ReplaceImageStatus(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceImageStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1Image**](KpackBuildV1alpha1Image.md)|  | 

### Return type

[**KpackBuildV1alpha1Image**](KpackBuildV1alpha1Image.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceSourceResolver

> KpackBuildV1alpha1SourceResolver ReplaceSourceResolver (string _namespace, string name, KpackBuildV1alpha1SourceResolver body)



replace the specified namespace scoped custom object

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceSourceResolverExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1SourceResolver(); // KpackBuildV1alpha1SourceResolver | The JSON schema of the Resource to replace.

            try
            {
                KpackBuildV1alpha1SourceResolver result = apiInstance.ReplaceSourceResolver(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceSourceResolver: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1SourceResolver**](KpackBuildV1alpha1SourceResolver.md)| The JSON schema of the Resource to replace. | 

### Return type

[**KpackBuildV1alpha1SourceResolver**](KpackBuildV1alpha1SourceResolver.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplaceSourceResolverStatus

> KpackBuildV1alpha1SourceResolver ReplaceSourceResolverStatus (string _namespace, string name, KpackBuildV1alpha1SourceResolver body)



replace status of the specified namespace scoped SourceResolver

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplaceSourceResolverStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new KpackApi(Configuration.Default);
            var _namespace = _namespace_example;  // string | The custom resource's namespace
            var name = name_example;  // string | the custom object's name
            var body = new KpackBuildV1alpha1SourceResolver(); // KpackBuildV1alpha1SourceResolver | 

            try
            {
                KpackBuildV1alpha1SourceResolver result = apiInstance.ReplaceSourceResolverStatus(_namespace, name, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling KpackApi.ReplaceSourceResolverStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| The custom resource&#39;s namespace | 
 **name** | **string**| the custom object&#39;s name | 
 **body** | [**KpackBuildV1alpha1SourceResolver**](KpackBuildV1alpha1SourceResolver.md)|  | 

### Return type

[**KpackBuildV1alpha1SourceResolver**](KpackBuildV1alpha1SourceResolver.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

