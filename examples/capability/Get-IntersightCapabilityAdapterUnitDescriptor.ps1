#Get the CapabilityAdapterUnitDescriptor by Name
$CapabilityAdapterUnitDescriptorByName = Get-IntersightCapabilityAdapterUnitDescriptor -Name CapabilityAdapterUnitDescriptorName

#Get the List of ServerProfiles
$CapabilityAdapterUnitDescriptorList = Get-IntersightCapabilityAdapterUnitDescriptor

#Get the list of CapabilityAdapterUnitDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CapabilityAdapterUnitDescriptorByOrg = Get-IntersightCapabilityAdapterUnitDescriptor -Organization $org

#Get the CapabilityAdapterUnitDescriptor based on query Parameter
$CapabilityAdapterUnitDescriptorByQueryParam = Get-IntersightCapabilityAdapterUnitDescriptor -Filter Name eq CapabilityAdapterUnitDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .