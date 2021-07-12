#Get the FirmwareDriveDescriptor by Name
$FirmwareDriveDescriptorByName = Get-IntersightFirmwareDriveDescriptor -Name FirmwareDriveDescriptorName

#Get the List of ServerProfiles
$FirmwareDriveDescriptorList = Get-IntersightFirmwareDriveDescriptor

#Get the list of FirmwareDriveDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareDriveDescriptorByOrg = Get-IntersightFirmwareDriveDescriptor -Organization $org

#Get the FirmwareDriveDescriptor based on query Parameter
$FirmwareDriveDescriptorByQueryParam = Get-IntersightFirmwareDriveDescriptor -Filter Name eq FirmwareDriveDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .