#Get the StorageNetAppVolumeSnapshot by Name
$StorageNetAppVolumeSnapshotByName = Get-IntersightStorageNetAppVolumeSnapshot -Name StorageNetAppVolumeSnapshotName

#Get the List of ServerProfiles
$StorageNetAppVolumeSnapshotList = Get-IntersightStorageNetAppVolumeSnapshot

#Get the list of StorageNetAppVolumeSnapshot under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppVolumeSnapshotByOrg = Get-IntersightStorageNetAppVolumeSnapshot -Organization $org

#Get the StorageNetAppVolumeSnapshot based on query Parameter
$StorageNetAppVolumeSnapshotByQueryParam = Get-IntersightStorageNetAppVolumeSnapshot -Filter Name eq StorageNetAppVolumeSnapshotName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .