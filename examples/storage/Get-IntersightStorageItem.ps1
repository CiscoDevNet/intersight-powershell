#Get the StorageItem by Name
$StorageItemByName = Get-IntersightStorageItem -Name StorageItemName

#Get the List of ServerProfiles
$StorageItemList = Get-IntersightStorageItem

#Get the list of StorageItem under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageItemByOrg = Get-IntersightStorageItem -Organization $org

#Get the StorageItem based on query Parameter
$StorageItemByQueryParam = Get-IntersightStorageItem -Filter Name eq StorageItemName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .