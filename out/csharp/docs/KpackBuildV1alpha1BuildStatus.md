
# Org.OpenAPITools.Model.KpackBuildV1alpha1BuildStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BuildMetadata** | [**List&lt;KpackBuildV1alpha1BuildpackMetadata&gt;**](KpackBuildV1alpha1BuildpackMetadata.md) |  | [optional] 
**Conditions** | [**List&lt;KpackCoreV1alpha1Condition&gt;**](KpackCoreV1alpha1Condition.md) | Conditions the latest available observations of a resource&#39;s current state. | [optional] 
**LatestImage** | **string** |  | [optional] 
**ObservedGeneration** | **long** | ObservedGeneration is the &#39;Generation&#39; of the Service that was last processed by the controller. | [optional] 
**PodName** | **string** |  | [optional] 
**Stack** | [**KpackBuildV1alpha1BuildStack**](KpackBuildV1alpha1BuildStack.md) |  | [optional] 
**StepStates** | [**List&lt;IoK8sApiCoreV1ContainerState&gt;**](IoK8sApiCoreV1ContainerState.md) |  | [optional] 
**StepsCompleted** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

