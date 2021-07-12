#Get the StorageStoragePolicy by Name
$StorageStoragePolicyByName = Get-IntersightStorageStoragePolicy -Name StorageStoragePolicyName

#Get the List of ServerProfiles
$StorageStoragePolicyList = Get-IntersightStorageStoragePolicy

#Get the list of StorageStoragePolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageStoragePolicyByOrg = Get-IntersightStorageStoragePolicy -Organization $org

#Get the StorageStoragePolicy based on query Parameter
$StorageStoragePolicyByQueryParam = Get-IntersightStorageStoragePolicy -Filter Name eq StorageStoragePolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .