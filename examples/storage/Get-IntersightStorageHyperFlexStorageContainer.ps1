#Get the StorageHyperFlexStorageContainer by Name
$StorageHyperFlexStorageContainerByName = Get-IntersightStorageHyperFlexStorageContainer -Name StorageHyperFlexStorageContainerName

#Get the List of ServerProfiles
$StorageHyperFlexStorageContainerList = Get-IntersightStorageHyperFlexStorageContainer

#Get the list of StorageHyperFlexStorageContainer under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageHyperFlexStorageContainerByOrg = Get-IntersightStorageHyperFlexStorageContainer -Organization $org

#Get the StorageHyperFlexStorageContainer based on query Parameter
$StorageHyperFlexStorageContainerByQueryParam = Get-IntersightStorageHyperFlexStorageContainer -Filter Name eq StorageHyperFlexStorageContainerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .