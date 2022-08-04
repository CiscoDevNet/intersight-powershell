#Get the FirmwareBoardControllerDescriptor by Name
$FirmwareBoardControllerDescriptorByName = Get-IntersightFirmwareBoardControllerDescriptor -Name FirmwareBoardControllerDescriptorName

#Get the List of ServerProfiles
$FirmwareBoardControllerDescriptorList = Get-IntersightFirmwareBoardControllerDescriptor

#Get the list of FirmwareBoardControllerDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FirmwareBoardControllerDescriptorByOrg = Get-IntersightFirmwareBoardControllerDescriptor -Organization $org

#Get the FirmwareBoardControllerDescriptor based on query Parameter
$FirmwareBoardControllerDescriptorByQueryParam = Get-IntersightFirmwareBoardControllerDescriptor -Filter Name eq FirmwareBoardControllerDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .