#Get the CapabilitySiocModuleCapabilityDef by Name
$CapabilitySiocModuleCapabilityDefByName = Get-IntersightCapabilitySiocModuleCapabilityDef -Name CapabilitySiocModuleCapabilityDefName

#Get the List of ServerProfiles
$CapabilitySiocModuleCapabilityDefList = Get-IntersightCapabilitySiocModuleCapabilityDef

#Get the list of CapabilitySiocModuleCapabilityDef under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilitySiocModuleCapabilityDefByOrg = Get-IntersightCapabilitySiocModuleCapabilityDef -Organization $org

#Get the CapabilitySiocModuleCapabilityDef based on query Parameter
$CapabilitySiocModuleCapabilityDefByQueryParam = Get-IntersightCapabilitySiocModuleCapabilityDef -Filter Name eq CapabilitySiocModuleCapabilityDefName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .