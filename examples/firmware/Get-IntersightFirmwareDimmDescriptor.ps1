#Get the FirmwareDimmDescriptor by Name
$FirmwareDimmDescriptorByName = Get-IntersightFirmwareDimmDescriptor -Name FirmwareDimmDescriptorName

#Get the List of ServerProfiles
$FirmwareDimmDescriptorList = Get-IntersightFirmwareDimmDescriptor

#Get the list of FirmwareDimmDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareDimmDescriptorByOrg = Get-IntersightFirmwareDimmDescriptor -Organization $org

#Get the FirmwareDimmDescriptor based on query Parameter
$FirmwareDimmDescriptorByQueryParam = Get-IntersightFirmwareDimmDescriptor -Filter Name eq FirmwareDimmDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .