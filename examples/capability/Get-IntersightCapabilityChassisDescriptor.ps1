#Get the CapabilityChassisDescriptor by Name
$CapabilityChassisDescriptorByName = Get-IntersightCapabilityChassisDescriptor -Name CapabilityChassisDescriptorName

#Get the List of ServerProfiles
$CapabilityChassisDescriptorList = Get-IntersightCapabilityChassisDescriptor

#Get the list of CapabilityChassisDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilityChassisDescriptorByOrg = Get-IntersightCapabilityChassisDescriptor -Organization $org

#Get the CapabilityChassisDescriptor based on query Parameter
$CapabilityChassisDescriptorByQueryParam = Get-IntersightCapabilityChassisDescriptor -Filter Name eq CapabilityChassisDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .