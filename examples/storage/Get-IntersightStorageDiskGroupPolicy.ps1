#Get the StorageDiskGroupPolicy by Name
$StorageDiskGroupPolicyByName = Get-IntersightStorageDiskGroupPolicy -Name StorageDiskGroupPolicyName

#Get the List of ServerProfiles
$StorageDiskGroupPolicyList = Get-IntersightStorageDiskGroupPolicy

#Get the list of StorageDiskGroupPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageDiskGroupPolicyByOrg = Get-IntersightStorageDiskGroupPolicy -Organization $org

#Get the StorageDiskGroupPolicy based on query Parameter
$StorageDiskGroupPolicyByQueryParam = Get-IntersightStorageDiskGroupPolicy -Filter Name eq StorageDiskGroupPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .