#Get the CapabilitySiocModuleManufacturingDef by Name
$CapabilitySiocModuleManufacturingDefByName = Get-IntersightCapabilitySiocModuleManufacturingDef -Name CapabilitySiocModuleManufacturingDefName

#Get the List of ServerProfiles
$CapabilitySiocModuleManufacturingDefList = Get-IntersightCapabilitySiocModuleManufacturingDef

#Get the list of CapabilitySiocModuleManufacturingDef under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilitySiocModuleManufacturingDefByOrg = Get-IntersightCapabilitySiocModuleManufacturingDef -Organization $org

#Get the CapabilitySiocModuleManufacturingDef based on query Parameter
$CapabilitySiocModuleManufacturingDefByQueryParam = Get-IntersightCapabilitySiocModuleManufacturingDef -Filter Name eq CapabilitySiocModuleManufacturingDefName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .