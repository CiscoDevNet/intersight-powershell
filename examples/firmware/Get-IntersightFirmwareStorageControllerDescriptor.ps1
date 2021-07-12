#Get the FirmwareStorageControllerDescriptor by Name
$FirmwareStorageControllerDescriptorByName = Get-IntersightFirmwareStorageControllerDescriptor -Name FirmwareStorageControllerDescriptorName

#Get the List of ServerProfiles
$FirmwareStorageControllerDescriptorList = Get-IntersightFirmwareStorageControllerDescriptor

#Get the list of FirmwareStorageControllerDescriptor under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FirmwareStorageControllerDescriptorByOrg = Get-IntersightFirmwareStorageControllerDescriptor -Organization $org

#Get the FirmwareStorageControllerDescriptor based on query Parameter
$FirmwareStorageControllerDescriptorByQueryParam = Get-IntersightFirmwareStorageControllerDescriptor -Filter Name eq FirmwareStorageControllerDescriptorName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .