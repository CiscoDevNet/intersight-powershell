#Get the StorageHitachiHost by Name
$StorageHitachiHostByName = Get-IntersightStorageHitachiHost -Name StorageHitachiHostName

#Get the List of ServerProfiles
$StorageHitachiHostList = Get-IntersightStorageHitachiHost

#Get the list of StorageHitachiHost under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageHitachiHostByOrg = Get-IntersightStorageHitachiHost -Organization $org

#Get the StorageHitachiHost based on query Parameter
$StorageHitachiHostByQueryParam = Get-IntersightStorageHitachiHost -Filter Name eq StorageHitachiHostName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .