#Get the StorageDriveGroup by Name
$StorageDriveGroupByName = Get-IntersightStorageDriveGroup -Name StorageDriveGroupName

#Get the List of StorageDriveGroups
$StorageDriveGroupList = Get-IntersightStorageDriveGroup

#Get the list of StorageDriveGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageDriveGroupByOrg = Get-IntersightStorageDriveGroup -Organization $org

#Get the StorageDriveGroup based on query Parameter
$StorageDriveGroupByQueryParam = Get-IntersightStorageDriveGroup -Filter Name eq StorageDriveGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .