#Get the CapabilityPsuDescriptor by Name
$CapabilityPsuDescriptorByName = Get-IntersightCapabilityPsuDescriptor -Name CapabilityPsuDescriptorName

#Get the List of ServerProfiles
$CapabilityPsuDescriptorList = Get-IntersightCapabilityPsuDescriptor

#Get the list of CapabilityPsuDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilityPsuDescriptorByOrg = Get-IntersightCapabilityPsuDescriptor -Organization $org

#Get the CapabilityPsuDescriptor based on query Parameter
$CapabilityPsuDescriptorByQueryParam = Get-IntersightCapabilityPsuDescriptor -Filter Name eq CapabilityPsuDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .