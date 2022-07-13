#Get the StorageVirtualDriveExtension by Name
$StorageVirtualDriveExtensionByName = Get-IntersightStorageVirtualDriveExtension -Name StorageVirtualDriveExtensionName

#Get the List of ServerProfiles
$StorageVirtualDriveExtensionList = Get-IntersightStorageVirtualDriveExtension

#Get the list of StorageVirtualDriveExtension under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageVirtualDriveExtensionByOrg = Get-IntersightStorageVirtualDriveExtension -Organization $org

#Get the StorageVirtualDriveExtension based on query Parameter
$StorageVirtualDriveExtensionByQueryParam = Get-IntersightStorageVirtualDriveExtension -Filter Name eq StorageVirtualDriveExtensionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .