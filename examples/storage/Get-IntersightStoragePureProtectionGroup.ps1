#Get the StoragePureProtectionGroup by Name
$StoragePureProtectionGroupByName = Get-IntersightStoragePureProtectionGroup -Name StoragePureProtectionGroupName

#Get the List of ServerProfiles
$StoragePureProtectionGroupList = Get-IntersightStoragePureProtectionGroup

#Get the list of StoragePureProtectionGroup under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePureProtectionGroupByOrg = Get-IntersightStoragePureProtectionGroup -Organization $org

#Get the StoragePureProtectionGroup based on query Parameter
$StoragePureProtectionGroupByQueryParam = Get-IntersightStoragePureProtectionGroup -Filter Name eq StoragePureProtectionGroupName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .