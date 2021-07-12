#Get the StorageHitachiHostLun by Name
$StorageHitachiHostLunByName = Get-IntersightStorageHitachiHostLun -Name StorageHitachiHostLunName

#Get the List of ServerProfiles
$StorageHitachiHostLunList = Get-IntersightStorageHitachiHostLun

#Get the list of StorageHitachiHostLun under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageHitachiHostLunByOrg = Get-IntersightStorageHitachiHostLun -Organization $org

#Get the StorageHitachiHostLun based on query Parameter
$StorageHitachiHostLunByQueryParam = Get-IntersightStorageHitachiHostLun -Filter Name eq StorageHitachiHostLunName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .