#Get the FirmwareSasExpanderDescriptor by Name
$FirmwareSasExpanderDescriptorByName = Get-IntersightFirmwareSasExpanderDescriptor -Name FirmwareSasExpanderDescriptorName

#Get the List of ServerProfiles
$FirmwareSasExpanderDescriptorList = Get-IntersightFirmwareSasExpanderDescriptor

#Get the list of FirmwareSasExpanderDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FirmwareSasExpanderDescriptorByOrg = Get-IntersightFirmwareSasExpanderDescriptor -Organization $org

#Get the FirmwareSasExpanderDescriptor based on query Parameter
$FirmwareSasExpanderDescriptorByQueryParam = Get-IntersightFirmwareSasExpanderDescriptor -Filter Name eq FirmwareSasExpanderDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .