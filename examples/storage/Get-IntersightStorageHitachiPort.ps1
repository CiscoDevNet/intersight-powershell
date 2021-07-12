#Get the StorageHitachiPort by Name
$StorageHitachiPortByName = Get-IntersightStorageHitachiPort -Name StorageHitachiPortName

#Get the List of ServerProfiles
$StorageHitachiPortList = Get-IntersightStorageHitachiPort

#Get the list of StorageHitachiPort under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageHitachiPortByOrg = Get-IntersightStorageHitachiPort -Organization $org

#Get the StorageHitachiPort based on query Parameter
$StorageHitachiPortByQueryParam = Get-IntersightStorageHitachiPort -Filter Name eq StorageHitachiPortName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .