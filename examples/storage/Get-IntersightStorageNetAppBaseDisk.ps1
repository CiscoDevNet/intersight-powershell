#Get the StorageNetAppBaseDisk by Name
$StorageNetAppBaseDiskByName = Get-IntersightStorageNetAppBaseDisk -Name StorageNetAppBaseDiskName

#Get the List of ServerProfiles
$StorageNetAppBaseDiskList = Get-IntersightStorageNetAppBaseDisk

#Get the list of StorageNetAppBaseDisk under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppBaseDiskByOrg = Get-IntersightStorageNetAppBaseDisk -Organization $org

#Get the StorageNetAppBaseDisk based on query Parameter
$StorageNetAppBaseDiskByQueryParam = Get-IntersightStorageNetAppBaseDisk -Filter Name eq StorageNetAppBaseDiskName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .