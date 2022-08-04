#Get the FirmwareNxosDescriptor by Name
$FirmwareNxosDescriptorByName = Get-IntersightFirmwareNxosDescriptor -Name FirmwareNxosDescriptorName

#Get the List of ServerProfiles
$FirmwareNxosDescriptorList = Get-IntersightFirmwareNxosDescriptor

#Get the list of FirmwareNxosDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FirmwareNxosDescriptorByOrg = Get-IntersightFirmwareNxosDescriptor -Organization $org

#Get the FirmwareNxosDescriptor based on query Parameter
$FirmwareNxosDescriptorByQueryParam = Get-IntersightFirmwareNxosDescriptor -Filter Name eq FirmwareNxosDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .