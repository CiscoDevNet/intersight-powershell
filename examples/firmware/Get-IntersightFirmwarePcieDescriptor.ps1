#Get the FirmwarePcieDescriptor by Name
$FirmwarePcieDescriptorByName = Get-IntersightFirmwarePcieDescriptor -Name FirmwarePcieDescriptorName

#Get the List of ServerProfiles
$FirmwarePcieDescriptorList = Get-IntersightFirmwarePcieDescriptor

#Get the list of FirmwarePcieDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FirmwarePcieDescriptorByOrg = Get-IntersightFirmwarePcieDescriptor -Organization $org

#Get the FirmwarePcieDescriptor based on query Parameter
$FirmwarePcieDescriptorByQueryParam = Get-IntersightFirmwarePcieDescriptor -Filter Name eq FirmwarePcieDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .