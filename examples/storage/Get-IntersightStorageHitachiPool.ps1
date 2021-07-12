#Get the StorageHitachiPool by Name
$StorageHitachiPoolByName = Get-IntersightStorageHitachiPool -Name StorageHitachiPoolName

#Get the List of ServerProfiles
$StorageHitachiPoolList = Get-IntersightStorageHitachiPool

#Get the list of StorageHitachiPool under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageHitachiPoolByOrg = Get-IntersightStorageHitachiPool -Organization $org

#Get the StorageHitachiPool based on query Parameter
$StorageHitachiPoolByQueryParam = Get-IntersightStorageHitachiPool -Filter Name eq StorageHitachiPoolName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .