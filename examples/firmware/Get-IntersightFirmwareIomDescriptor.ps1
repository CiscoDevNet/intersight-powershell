#Get the FirmwareIomDescriptor by Name
$FirmwareIomDescriptorByName = Get-IntersightFirmwareIomDescriptor -Name FirmwareIomDescriptorName

#Get the List of ServerProfiles
$FirmwareIomDescriptorList = Get-IntersightFirmwareIomDescriptor

#Get the list of FirmwareIomDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareIomDescriptorByOrg = Get-IntersightFirmwareIomDescriptor -Organization $org

#Get the FirmwareIomDescriptor based on query Parameter
$FirmwareIomDescriptorByQueryParam = Get-IntersightFirmwareIomDescriptor -Filter Name eq FirmwareIomDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .