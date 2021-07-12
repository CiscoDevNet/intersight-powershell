#Get the StorageHitachiArray by Name
$StorageHitachiArrayByName = Get-IntersightStorageHitachiArray -Name StorageHitachiArrayName

#Get the List of ServerProfiles
$StorageHitachiArrayList = Get-IntersightStorageHitachiArray

#Get the list of StorageHitachiArray under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageHitachiArrayByOrg = Get-IntersightStorageHitachiArray -Organization $org

#Get the StorageHitachiArray based on query Parameter
$StorageHitachiArrayByQueryParam = Get-IntersightStorageHitachiArray -Filter Name eq StorageHitachiArrayName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .