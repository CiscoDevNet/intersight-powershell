#Get the CapabilityCimcFirmwareDescriptor by Name
$CapabilityCimcFirmwareDescriptorByName = Get-IntersightCapabilityCimcFirmwareDescriptor -Name CapabilityCimcFirmwareDescriptorName

#Get the List of ServerProfiles
$CapabilityCimcFirmwareDescriptorList = Get-IntersightCapabilityCimcFirmwareDescriptor

#Get the list of CapabilityCimcFirmwareDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilityCimcFirmwareDescriptorByOrg = Get-IntersightCapabilityCimcFirmwareDescriptor -Organization $org

#Get the CapabilityCimcFirmwareDescriptor based on query Parameter
$CapabilityCimcFirmwareDescriptorByQueryParam = Get-IntersightCapabilityCimcFirmwareDescriptor -Filter Name eq CapabilityCimcFirmwareDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .