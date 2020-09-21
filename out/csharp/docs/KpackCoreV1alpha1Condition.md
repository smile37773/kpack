
# Org.OpenAPITools.Model.KpackCoreV1alpha1Condition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastTransitionTime** | **string** | LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant). | [optional] 
**Message** | **string** | A human readable message indicating details about the transition. | [optional] 
**Reason** | **string** | The reason for the condition&#39;s last transition. | [optional] 
**Severity** | **string** | Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error. | [optional] 
**Status** | **string** | Status of the condition, one of True, False, Unknown. | 
**Type** | **string** | Type of condition. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

