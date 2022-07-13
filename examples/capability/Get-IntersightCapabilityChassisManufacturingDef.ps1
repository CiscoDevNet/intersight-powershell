#Get the CapabilityChassisManufacturingDef by Name
$CapabilityChassisManufacturingDefByName = Get-IntersightCapabilityChassisManufacturingDef -Name CapabilityChassisManufacturingDefName

#Get the List of ServerProfiles
$CapabilityChassisManufacturingDefList = Get-IntersightCapabilityChassisManufacturingDef

#Get the list of CapabilityChassisManufacturingDef under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilityChassisManufacturingDefByOrg = Get-IntersightCapabilityChassisManufacturingDef -Organization $org

#Get the CapabilityChassisManufacturingDef based on query Parameter
$CapabilityChassisManufacturingDefByQueryParam = Get-IntersightCapabilityChassisManufacturingDef -Filter Name eq CapabilityChassisManufacturingDefName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .