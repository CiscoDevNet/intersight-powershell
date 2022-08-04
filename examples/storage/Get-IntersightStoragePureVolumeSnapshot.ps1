#Get the StoragePureVolumeSnapshot by Name
$StoragePureVolumeSnapshotByName = Get-IntersightStoragePureVolumeSnapshot -Name StoragePureVolumeSnapshotName

#Get the List of ServerProfiles
$StoragePureVolumeSnapshotList = Get-IntersightStoragePureVolumeSnapshot

#Get the list of StoragePureVolumeSnapshot under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePureVolumeSnapshotByOrg = Get-IntersightStoragePureVolumeSnapshot -Organization $org

#Get the StoragePureVolumeSnapshot based on query Parameter
$StoragePureVolumeSnapshotByQueryParam = Get-IntersightStoragePureVolumeSnapshot -Filter Name eq StoragePureVolumeSnapshotName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .