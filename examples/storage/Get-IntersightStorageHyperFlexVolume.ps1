#Get the StorageHyperFlexVolume by Name
$StorageHyperFlexVolumeByName = Get-IntersightStorageHyperFlexVolume -Name StorageHyperFlexVolumeName

#Get the List of ServerProfiles
$StorageHyperFlexVolumeList = Get-IntersightStorageHyperFlexVolume

#Get the list of StorageHyperFlexVolume under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageHyperFlexVolumeByOrg = Get-IntersightStorageHyperFlexVolume -Organization $org

#Get the StorageHyperFlexVolume based on query Parameter
$StorageHyperFlexVolumeByQueryParam = Get-IntersightStorageHyperFlexVolume -Filter Name eq StorageHyperFlexVolumeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .