
# Org.OpenAPITools.Model.IoK8sApiCoreV1ContainerStateTerminated

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContainerID** | **string** | Container&#39;s ID in the format &#39;docker://&lt;container_id&gt;&#39; | [optional] 
**ExitCode** | **int** | Exit status from the last termination of the container | 
**FinishedAt** | **DateTime** | Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers. | [optional] 
**Message** | **string** | Message regarding the last termination of the container | [optional] 
**Reason** | **string** | (brief) reason from the last termination of the container | [optional] 
**Signal** | **int** | Signal from the last termination of the container | [optional] 
**StartedAt** | **DateTime** | Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

