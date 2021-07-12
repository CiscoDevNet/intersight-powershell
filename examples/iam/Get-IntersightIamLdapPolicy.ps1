#Get the IamLdapPolicy by Name
$IamLdapPolicyByName = Get-IntersightIamLdapPolicy -Name IamLdapPolicyName

#Get the List of ServerProfiles
$IamLdapPolicyList = Get-IntersightIamLdapPolicy

#Get the list of IamLdapPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IamLdapPolicyByOrg = Get-IntersightIamLdapPolicy -Organization $org

#Get the IamLdapPolicy based on query Parameter
$IamLdapPolicyByQueryParam = Get-IntersightIamLdapPolicy -Filter Name eq IamLdapPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .