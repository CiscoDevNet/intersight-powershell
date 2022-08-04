#Get the CapabilityFanModuleManufacturingDef by Name
$CapabilityFanModuleManufacturingDefByName = Get-IntersightCapabilityFanModuleManufacturingDef -Name CapabilityFanModuleManufacturingDefName

#Get the List of ServerProfiles
$CapabilityFanModuleManufacturingDefList = Get-IntersightCapabilityFanModuleManufacturingDef

#Get the list of CapabilityFanModuleManufacturingDef under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilityFanModuleManufacturingDefByOrg = Get-IntersightCapabilityFanModuleManufacturingDef -Organization $org

#Get the CapabilityFanModuleManufacturingDef based on query Parameter
$CapabilityFanModuleManufacturingDefByQueryParam = Get-IntersightCapabilityFanModuleManufacturingDef -Filter Name eq CapabilityFanModuleManufacturingDefName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .