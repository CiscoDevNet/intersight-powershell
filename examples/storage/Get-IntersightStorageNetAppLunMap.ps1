#Get the StorageNetAppLunMap by Name
$StorageNetAppLunMapByName = Get-IntersightStorageNetAppLunMap -Name StorageNetAppLunMapName

#Get the List of ServerProfiles
$StorageNetAppLunMapList = Get-IntersightStorageNetAppLunMap

#Get the list of StorageNetAppLunMap under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppLunMapByOrg = Get-IntersightStorageNetAppLunMap -Organization $org

#Get the StorageNetAppLunMap based on query Parameter
$StorageNetAppLunMapByQueryParam = Get-IntersightStorageNetAppLunMap -Filter Name eq StorageNetAppLunMapName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .