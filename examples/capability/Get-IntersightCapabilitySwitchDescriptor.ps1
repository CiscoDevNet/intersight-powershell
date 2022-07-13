#Get the CapabilitySwitchDescriptor by Name
$CapabilitySwitchDescriptorByName = Get-IntersightCapabilitySwitchDescriptor -Name CapabilitySwitchDescriptorName

#Get the List of ServerProfiles
$CapabilitySwitchDescriptorList = Get-IntersightCapabilitySwitchDescriptor

#Get the list of CapabilitySwitchDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilitySwitchDescriptorByOrg = Get-IntersightCapabilitySwitchDescriptor -Organization $org

#Get the CapabilitySwitchDescriptor based on query Parameter
$CapabilitySwitchDescriptorByQueryParam = Get-IntersightCapabilitySwitchDescriptor -Filter Name eq CapabilitySwitchDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .