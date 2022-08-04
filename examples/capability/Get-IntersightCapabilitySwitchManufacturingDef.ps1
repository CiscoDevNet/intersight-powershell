#Get the CapabilitySwitchManufacturingDef by Name
$CapabilitySwitchManufacturingDefByName = Get-IntersightCapabilitySwitchManufacturingDef -Name CapabilitySwitchManufacturingDefName

#Get the List of ServerProfiles
$CapabilitySwitchManufacturingDefList = Get-IntersightCapabilitySwitchManufacturingDef

#Get the list of CapabilitySwitchManufacturingDef under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilitySwitchManufacturingDefByOrg = Get-IntersightCapabilitySwitchManufacturingDef -Organization $org

#Get the CapabilitySwitchManufacturingDef based on query Parameter
$CapabilitySwitchManufacturingDefByQueryParam = Get-IntersightCapabilitySwitchManufacturingDef -Filter Name eq CapabilitySwitchManufacturingDefName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .