#Get the StorageHitachiParityGroup by Name
$StorageHitachiParityGroupByName = Get-IntersightStorageHitachiParityGroup -Name StorageHitachiParityGroupName

#Get the List of ServerProfiles
$StorageHitachiParityGroupList = Get-IntersightStorageHitachiParityGroup

#Get the list of StorageHitachiParityGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageHitachiParityGroupByOrg = Get-IntersightStorageHitachiParityGroup -Organization $org

#Get the StorageHitachiParityGroup based on query Parameter
$StorageHitachiParityGroupByQueryParam = Get-IntersightStorageHitachiParityGroup -Filter Name eq StorageHitachiParityGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .