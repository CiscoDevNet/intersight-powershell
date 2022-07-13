#Get the FirmwarePsuDescriptor by Name
$FirmwarePsuDescriptorByName = Get-IntersightFirmwarePsuDescriptor -Name FirmwarePsuDescriptorName

#Get the List of ServerProfiles
$FirmwarePsuDescriptorList = Get-IntersightFirmwarePsuDescriptor

#Get the list of FirmwarePsuDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FirmwarePsuDescriptorByOrg = Get-IntersightFirmwarePsuDescriptor -Organization $org

#Get the FirmwarePsuDescriptor based on query Parameter
$FirmwarePsuDescriptorByQueryParam = Get-IntersightFirmwarePsuDescriptor -Filter Name eq FirmwarePsuDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .