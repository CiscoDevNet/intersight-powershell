#Get the StoragePureProtectionGroupSnapshot by Name
$StoragePureProtectionGroupSnapshotByName = Get-IntersightStoragePureProtectionGroupSnapshot -Name StoragePureProtectionGroupSnapshotName

#Get the List of ServerProfiles
$StoragePureProtectionGroupSnapshotList = Get-IntersightStoragePureProtectionGroupSnapshot

#Get the list of StoragePureProtectionGroupSnapshot under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StoragePureProtectionGroupSnapshotByOrg = Get-IntersightStoragePureProtectionGroupSnapshot -Organization $org

#Get the StoragePureProtectionGroupSnapshot based on query Parameter
$StoragePureProtectionGroupSnapshotByQueryParam = Get-IntersightStoragePureProtectionGroupSnapshot -Filter Name eq StoragePureProtectionGroupSnapshotName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .