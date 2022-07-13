#Get the CapabilitySiocModuleDescriptor by Name
$CapabilitySiocModuleDescriptorByName = Get-IntersightCapabilitySiocModuleDescriptor -Name CapabilitySiocModuleDescriptorName

#Get the List of ServerProfiles
$CapabilitySiocModuleDescriptorList = Get-IntersightCapabilitySiocModuleDescriptor

#Get the list of CapabilitySiocModuleDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilitySiocModuleDescriptorByOrg = Get-IntersightCapabilitySiocModuleDescriptor -Organization $org

#Get the CapabilitySiocModuleDescriptor based on query Parameter
$CapabilitySiocModuleDescriptorByQueryParam = Get-IntersightCapabilitySiocModuleDescriptor -Filter Name eq CapabilitySiocModuleDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .