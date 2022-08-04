#Get the CapabilityFanModuleDescriptor by Name
$CapabilityFanModuleDescriptorByName = Get-IntersightCapabilityFanModuleDescriptor -Name CapabilityFanModuleDescriptorName

#Get the List of ServerProfiles
$CapabilityFanModuleDescriptorList = Get-IntersightCapabilityFanModuleDescriptor

#Get the list of CapabilityFanModuleDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilityFanModuleDescriptorByOrg = Get-IntersightCapabilityFanModuleDescriptor -Organization $org

#Get the CapabilityFanModuleDescriptor based on query Parameter
$CapabilityFanModuleDescriptorByQueryParam = Get-IntersightCapabilityFanModuleDescriptor -Filter Name eq CapabilityFanModuleDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .