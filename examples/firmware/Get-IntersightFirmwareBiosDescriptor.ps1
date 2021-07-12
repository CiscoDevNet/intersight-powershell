#Get the FirmwareBiosDescriptor by Name
$FirmwareBiosDescriptorByName = Get-IntersightFirmwareBiosDescriptor -Name FirmwareBiosDescriptorName

#Get the List of ServerProfiles
$FirmwareBiosDescriptorList = Get-IntersightFirmwareBiosDescriptor

#Get the list of FirmwareBiosDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareBiosDescriptorByOrg = Get-IntersightFirmwareBiosDescriptor -Organization $org

#Get the FirmwareBiosDescriptor based on query Parameter
$FirmwareBiosDescriptorByQueryParam = Get-IntersightFirmwareBiosDescriptor -Filter Name eq FirmwareBiosDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .