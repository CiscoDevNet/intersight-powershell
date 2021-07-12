#Get the FirmwareCimcDescriptor by Name
$FirmwareCimcDescriptorByName = Get-IntersightFirmwareCimcDescriptor -Name FirmwareCimcDescriptorName

#Get the List of ServerProfiles
$FirmwareCimcDescriptorList = Get-IntersightFirmwareCimcDescriptor

#Get the list of FirmwareCimcDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareCimcDescriptorByOrg = Get-IntersightFirmwareCimcDescriptor -Organization $org

#Get the FirmwareCimcDescriptor based on query Parameter
$FirmwareCimcDescriptorByQueryParam = Get-IntersightFirmwareCimcDescriptor -Filter Name eq FirmwareCimcDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .