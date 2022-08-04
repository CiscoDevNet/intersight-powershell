#Get the CapabilityIoCardManufacturingDef by Name
$CapabilityIoCardManufacturingDefByName = Get-IntersightCapabilityIoCardManufacturingDef -Name CapabilityIoCardManufacturingDefName

#Get the List of ServerProfiles
$CapabilityIoCardManufacturingDefList = Get-IntersightCapabilityIoCardManufacturingDef

#Get the list of CapabilityIoCardManufacturingDef under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilityIoCardManufacturingDefByOrg = Get-IntersightCapabilityIoCardManufacturingDef -Organization $org

#Get the CapabilityIoCardManufacturingDef based on query Parameter
$CapabilityIoCardManufacturingDefByQueryParam = Get-IntersightCapabilityIoCardManufacturingDef -Filter Name eq CapabilityIoCardManufacturingDefName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .