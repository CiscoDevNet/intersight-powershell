#Get the StoragePureVolume by Name
$StoragePureVolumeByName = Get-IntersightStoragePureVolume -Name StoragePureVolumeName

#Get the List of ServerProfiles
$StoragePureVolumeList = Get-IntersightStoragePureVolume

#Get the list of StoragePureVolume under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePureVolumeByOrg = Get-IntersightStoragePureVolume -Organization $org

#Get the StoragePureVolume based on query Parameter
$StoragePureVolumeByQueryParam = Get-IntersightStoragePureVolume -Filter Name eq StoragePureVolumeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .