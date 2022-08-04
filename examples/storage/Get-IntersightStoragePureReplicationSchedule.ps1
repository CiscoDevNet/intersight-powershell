#Get the StoragePureReplicationSchedule by Name
$StoragePureReplicationScheduleByName = Get-IntersightStoragePureReplicationSchedule -Name StoragePureReplicationScheduleName

#Get the List of ServerProfiles
$StoragePureReplicationScheduleList = Get-IntersightStoragePureReplicationSchedule

#Get the list of StoragePureReplicationSchedule under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePureReplicationScheduleByOrg = Get-IntersightStoragePureReplicationSchedule -Organization $org

#Get the StoragePureReplicationSchedule based on query Parameter
$StoragePureReplicationScheduleByQueryParam = Get-IntersightStoragePureReplicationSchedule -Filter Name eq StoragePureReplicationScheduleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .