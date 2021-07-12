#Get the StorageNetAppInitiatorGroup by Name
$StorageNetAppInitiatorGroupByName = Get-IntersightStorageNetAppInitiatorGroup -Name StorageNetAppInitiatorGroupName

#Get the List of ServerProfiles
$StorageNetAppInitiatorGroupList = Get-IntersightStorageNetAppInitiatorGroup

#Get the list of StorageNetAppInitiatorGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppInitiatorGroupByOrg = Get-IntersightStorageNetAppInitiatorGroup -Organization $org

#Get the StorageNetAppInitiatorGroup based on query Parameter
$StorageNetAppInitiatorGroupByQueryParam = Get-IntersightStorageNetAppInitiatorGroup -Filter Name eq StorageNetAppInitiatorGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .