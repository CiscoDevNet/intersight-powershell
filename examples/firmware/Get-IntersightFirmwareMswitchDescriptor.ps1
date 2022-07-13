#Get the FirmwareMswitchDescriptor by Name
$FirmwareMswitchDescriptorByName = Get-IntersightFirmwareMswitchDescriptor -Name FirmwareMswitchDescriptorName

#Get the List of ServerProfiles
$FirmwareMswitchDescriptorList = Get-IntersightFirmwareMswitchDescriptor

#Get the list of FirmwareMswitchDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FirmwareMswitchDescriptorByOrg = Get-IntersightFirmwareMswitchDescriptor -Organization $org

#Get the FirmwareMswitchDescriptor based on query Parameter
$FirmwareMswitchDescriptorByQueryParam = Get-IntersightFirmwareMswitchDescriptor -Filter Name eq FirmwareMswitchDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .