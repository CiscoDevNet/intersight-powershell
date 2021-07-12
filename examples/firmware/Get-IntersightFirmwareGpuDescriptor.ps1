#Get the FirmwareGpuDescriptor by Name
$FirmwareGpuDescriptorByName = Get-IntersightFirmwareGpuDescriptor -Name FirmwareGpuDescriptorName

#Get the List of ServerProfiles
$FirmwareGpuDescriptorList = Get-IntersightFirmwareGpuDescriptor

#Get the list of FirmwareGpuDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareGpuDescriptorByOrg = Get-IntersightFirmwareGpuDescriptor -Organization $org

#Get the FirmwareGpuDescriptor based on query Parameter
$FirmwareGpuDescriptorByQueryParam = Get-IntersightFirmwareGpuDescriptor -Filter Name eq FirmwareGpuDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .