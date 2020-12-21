# ConnectorpackUpgradeImpactAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connectorpack.UpgradeImpact"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connectorpack.UpgradeImpact"]
**ConnectorPack** | [**ConnectorpackConnectorPackUpdate[]**](ConnectorpackConnectorPackUpdate.md) |  | [optional] 
**IsEligibleForUpgrade** | **Boolean** | States whether the UCS Director is eligible for an upgrade. Set to true if connector packs are available for upgrade, else set to false. | [optional] [readonly] 
**IsUpdateDownloaded** | **Boolean** | States whether all the requisite updates have been downloaded to the target UCS Director. Set to true if all connector packs required to upgrade UCS Director to the next iteration have been downloaded, else set to false. | [optional] [readonly] 
**UcsdInfo** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorpackUpgradeImpactAllOf = Initialize-IntersightConnectorpackUpgradeImpactAllOf  -ClassId null `
 -ObjectType null `
 -ConnectorPack null `
 -IsEligibleForUpgrade null `
 -IsUpdateDownloaded null `
 -UcsdInfo null
```

- Convert the resource to JSON
```powershell
$ConnectorpackUpgradeImpactAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

