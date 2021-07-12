#Get the StoragePureHostGroup by Name
$StoragePureHostGroupByName = Get-IntersightStoragePureHostGroup -Name StoragePureHostGroupName

#Get the List of ServerProfiles
$StoragePureHostGroupList = Get-IntersightStoragePureHostGroup

#Get the list of StoragePureHostGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StoragePureHostGroupByOrg = Get-IntersightStoragePureHostGroup -Organization $org

#Get the StoragePureHostGroup based on query Parameter
$StoragePureHostGroupByQueryParam = Get-IntersightStoragePureHostGroup -Filter Name eq StoragePureHostGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .