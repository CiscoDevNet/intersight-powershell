#Get the StoragePureSnapshotSchedule by Name
$StoragePureSnapshotScheduleByName = Get-IntersightStoragePureSnapshotSchedule -Name StoragePureSnapshotScheduleName

#Get the List of ServerProfiles
$StoragePureSnapshotScheduleList = Get-IntersightStoragePureSnapshotSchedule

#Get the list of StoragePureSnapshotSchedule under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePureSnapshotScheduleByOrg = Get-IntersightStoragePureSnapshotSchedule -Organization $org

#Get the StoragePureSnapshotSchedule based on query Parameter
$StoragePureSnapshotScheduleByQueryParam = Get-IntersightStoragePureSnapshotSchedule -Filter Name eq StoragePureSnapshotScheduleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .