#Get the StorageHitachiVolume by Name
$StorageHitachiVolumeByName = Get-IntersightStorageHitachiVolume -Name StorageHitachiVolumeName

#Get the List of ServerProfiles
$StorageHitachiVolumeList = Get-IntersightStorageHitachiVolume

#Get the list of StorageHitachiVolume under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageHitachiVolumeByOrg = Get-IntersightStorageHitachiVolume -Organization $org

#Get the StorageHitachiVolume based on query Parameter
$StorageHitachiVolumeByQueryParam = Get-IntersightStorageHitachiVolume -Filter Name eq StorageHitachiVolumeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .