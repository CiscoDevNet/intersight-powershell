#Get the CapabilityPsuManufacturingDef by Name
$CapabilityPsuManufacturingDefByName = Get-IntersightCapabilityPsuManufacturingDef -Name CapabilityPsuManufacturingDefName

#Get the List of ServerProfiles
$CapabilityPsuManufacturingDefList = Get-IntersightCapabilityPsuManufacturingDef

#Get the list of CapabilityPsuManufacturingDef under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilityPsuManufacturingDefByOrg = Get-IntersightCapabilityPsuManufacturingDef -Organization $org

#Get the CapabilityPsuManufacturingDef based on query Parameter
$CapabilityPsuManufacturingDefByQueryParam = Get-IntersightCapabilityPsuManufacturingDef -Filter Name eq CapabilityPsuManufacturingDefName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .