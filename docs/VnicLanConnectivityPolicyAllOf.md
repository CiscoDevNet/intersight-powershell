# VnicLanConnectivityPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.LanConnectivityPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.LanConnectivityPolicy"]
**IqnAllocationType** | **String** | Allocation Type of iSCSI Qualified Name - Static/Dynamic/None. * &#x60;None&#x60; - Type defines that property is not applicable for an interface. * &#x60;Auto&#x60; - The system selects an interface automatically - DHCP. * &#x60;Static&#x60; - Type represents that static information or properties are associated to an interface. * &#x60;Pool&#x60; - Type defines that property value will be fetched from an associated pool. | [optional] [default to "None"]
**PlacementMode** | **String** | The mode used for placement of vNICs on network adapters. It can either be Auto or Custom. * &#x60;custom&#x60; - The placement of the vNICs / vHBAs on network adapters is manually chosen by the user. * &#x60;auto&#x60; - The placement of the vNICs / vHBAs on network adapters is automatically determined by the system. | [optional] [default to "custom"]
**StaticIqnName** | **String** | User provided static iSCSI Qualified Name (IQN) for use as initiator identifiers by iSCSI vNICs in a Fabric Interconnect domain. | [optional] 
**TargetPlatform** | **String** | The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight. * &#x60;Standalone&#x60; - Servers which are operating in standalone mode i.e. not connected to a Fabric Interconnected. * &#x60;FIAttached&#x60; - Servers which are connected to a Fabric Interconnect that is managed by Intersight. | [optional] [default to "Standalone"]
**EthIfs** | [**VnicEthIfRelationship[]**](VnicEthIfRelationship.md) | An array of relationships to vnicEthIf resources. | [optional] 
**IqnPool** | [**IqnpoolPoolRelationship**](IqnpoolPoolRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicLanConnectivityPolicyAllOf = Initialize-IntersightVnicLanConnectivityPolicyAllOf  -ClassId null `
 -ObjectType null `
 -IqnAllocationType null `
 -PlacementMode null `
 -StaticIqnName null `
 -TargetPlatform null `
 -EthIfs null `
 -IqnPool null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$VnicLanConnectivityPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

