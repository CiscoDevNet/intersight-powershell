#Get the StorageNetAppVolume by Name
$StorageNetAppVolumeByName = Get-IntersightStorageNetAppVolume -Name StorageNetAppVolumeName

#Get the List of ServerProfiles
$StorageNetAppVolumeList = Get-IntersightStorageNetAppVolume

#Get the list of StorageNetAppVolume under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppVolumeByOrg = Get-IntersightStorageNetAppVolume -Organization $org

#Get the StorageNetAppVolume based on query Parameter
$StorageNetAppVolumeByQueryParam = Get-IntersightStorageNetAppVolume -Filter Name eq StorageNetAppVolumeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .