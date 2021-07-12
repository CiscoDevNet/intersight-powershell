#Get the CapabilitySwitchCapability by Name
$CapabilitySwitchCapabilityByName = Get-IntersightCapabilitySwitchCapability -Name CapabilitySwitchCapabilityName

#Get the List of ServerProfiles
$CapabilitySwitchCapabilityList = Get-IntersightCapabilitySwitchCapability

#Get the list of CapabilitySwitchCapability under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilitySwitchCapabilityByOrg = Get-IntersightCapabilitySwitchCapability -Organization $org

#Get the CapabilitySwitchCapability based on query Parameter
$CapabilitySwitchCapabilityByQueryParam = Get-IntersightCapabilitySwitchCapability -Filter Name eq CapabilitySwitchCapabilityName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .