#Get the CapabilityIoCardCapabilityDef by Name
$CapabilityIoCardCapabilityDefByName = Get-IntersightCapabilityIoCardCapabilityDef -Name CapabilityIoCardCapabilityDefName

#Get the List of ServerProfiles
$CapabilityIoCardCapabilityDefList = Get-IntersightCapabilityIoCardCapabilityDef

#Get the list of CapabilityIoCardCapabilityDef under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilityIoCardCapabilityDefByOrg = Get-IntersightCapabilityIoCardCapabilityDef -Organization $org

#Get the CapabilityIoCardCapabilityDef based on query Parameter
$CapabilityIoCardCapabilityDefByQueryParam = Get-IntersightCapabilityIoCardCapabilityDef -Filter Name eq CapabilityIoCardCapabilityDefName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .