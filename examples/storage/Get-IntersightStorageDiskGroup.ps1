#Get the StorageDiskGroup by Name
$StorageDiskGroupByName = Get-IntersightStorageDiskGroup -Name StorageDiskGroupName

#Get the List of ServerProfiles
$StorageDiskGroupList = Get-IntersightStorageDiskGroup

#Get the list of StorageDiskGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageDiskGroupByOrg = Get-IntersightStorageDiskGroup -Organization $org

#Get the StorageDiskGroup based on query Parameter
$StorageDiskGroupByQueryParam = Get-IntersightStorageDiskGroup -Filter Name eq StorageDiskGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .