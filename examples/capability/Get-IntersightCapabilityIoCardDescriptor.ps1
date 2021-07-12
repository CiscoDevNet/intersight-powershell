#Get the CapabilityIoCardDescriptor by Name
$CapabilityIoCardDescriptorByName = Get-IntersightCapabilityIoCardDescriptor -Name CapabilityIoCardDescriptorName

#Get the List of ServerProfiles
$CapabilityIoCardDescriptorList = Get-IntersightCapabilityIoCardDescriptor

#Get the list of CapabilityIoCardDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilityIoCardDescriptorByOrg = Get-IntersightCapabilityIoCardDescriptor -Organization $org

#Get the CapabilityIoCardDescriptor based on query Parameter
$CapabilityIoCardDescriptorByQueryParam = Get-IntersightCapabilityIoCardDescriptor -Filter Name eq CapabilityIoCardDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .