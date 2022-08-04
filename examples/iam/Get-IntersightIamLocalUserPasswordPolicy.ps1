#Get the IamLocalUserPasswordPolicy by Name
$IamLocalUserPasswordPolicyByName = Get-IntersightIamLocalUserPasswordPolicy -Name IamLocalUserPasswordPolicyName

#Get the List of ServerProfiles
$IamLocalUserPasswordPolicyList = Get-IntersightIamLocalUserPasswordPolicy

#Get the list of IamLocalUserPasswordPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamLocalUserPasswordPolicyByOrg = Get-IntersightIamLocalUserPasswordPolicy -Organization $org

#Get the IamLocalUserPasswordPolicy based on query Parameter
$IamLocalUserPasswordPolicyByQueryParam = Get-IntersightIamLocalUserPasswordPolicy -Filter Name eq IamLocalUserPasswordPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .