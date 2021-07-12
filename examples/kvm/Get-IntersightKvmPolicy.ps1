#Get the KvmPolicy by Name
$KvmPolicyByName = Get-IntersightKvmPolicy -Name KvmPolicyName

#Get the List of ServerProfiles
$KvmPolicyList = Get-IntersightKvmPolicy

#Get the list of KvmPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KvmPolicyByOrg = Get-IntersightKvmPolicy -Organization $org

#Get the KvmPolicy based on query Parameter
$KvmPolicyByQueryParam = Get-IntersightKvmPolicy -Filter Name eq KvmPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .