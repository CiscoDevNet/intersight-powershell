# IaasConnectorPackAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.ConnectorPack"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.ConnectorPack"]
**CompleteVersion** | **String** | Complete version of the connector pack including build number. | [optional] [readonly] 
**DependencyNames** | **String[]** |  | [optional] 
**DownloadedVersion** | **String** | Version of the connector pack that is last downloaded successfully to UCSD. | [optional] [readonly] 
**Name** | **String** | Name of the connector pack running on the UCSD. | [optional] [readonly] 
**State** | **String** | State of the connector pack whether it is enabled or disabled. | [optional] [readonly] 
**Version** | **String** | Version of the connector pack. | [optional] [readonly] 
**Guid** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IaasConnectorPackAllOf = Initialize-IntersightIaasConnectorPackAllOf  -ClassId null `
 -ObjectType null `
 -CompleteVersion null `
 -DependencyNames null `
 -DownloadedVersion null `
 -Name null `
 -State null `
 -Version null `
 -Guid null
```

- Convert the resource to JSON
```powershell
$IaasConnectorPackAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

