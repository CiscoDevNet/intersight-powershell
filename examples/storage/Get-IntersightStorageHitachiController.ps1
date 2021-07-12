#Get the StorageHitachiController by Name
$StorageHitachiControllerByName = Get-IntersightStorageHitachiController -Name StorageHitachiControllerName

#Get the List of ServerProfiles
$StorageHitachiControllerList = Get-IntersightStorageHitachiController

#Get the list of StorageHitachiController under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageHitachiControllerByOrg = Get-IntersightStorageHitachiController -Organization $org

#Get the StorageHitachiController based on query Parameter
$StorageHitachiControllerByQueryParam = Get-IntersightStorageHitachiController -Filter Name eq StorageHitachiControllerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .