#Get the FirmwareHbaDescriptor by Name
$FirmwareHbaDescriptorByName = Get-IntersightFirmwareHbaDescriptor -Name FirmwareHbaDescriptorName

#Get the List of ServerProfiles
$FirmwareHbaDescriptorList = Get-IntersightFirmwareHbaDescriptor

#Get the list of FirmwareHbaDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareHbaDescriptorByOrg = Get-IntersightFirmwareHbaDescriptor -Organization $org

#Get the FirmwareHbaDescriptor based on query Parameter
$FirmwareHbaDescriptorByQueryParam = Get-IntersightFirmwareHbaDescriptor -Filter Name eq FirmwareHbaDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .