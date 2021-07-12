#Get the StoragePhysicalDiskExtension by Name
$StoragePhysicalDiskExtensionByName = Get-IntersightStoragePhysicalDiskExtension -Name StoragePhysicalDiskExtensionName

#Get the List of ServerProfiles
$StoragePhysicalDiskExtensionList = Get-IntersightStoragePhysicalDiskExtension

#Get the list of StoragePhysicalDiskExtension under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StoragePhysicalDiskExtensionByOrg = Get-IntersightStoragePhysicalDiskExtension -Organization $org

#Get the StoragePhysicalDiskExtension based on query Parameter
$StoragePhysicalDiskExtensionByQueryParam = Get-IntersightStoragePhysicalDiskExtension -Filter Name eq StoragePhysicalDiskExtensionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .