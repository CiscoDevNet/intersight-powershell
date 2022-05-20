#Get the SshPolicy by Name
$SshPolicyByName = Get-IntersightSshPolicy -Name SshPolicyName

#Get the List of SshPolicy
$SshPolicyList = Get-IntersightSshPolicy

#Get the list of SshPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SshPolicyByOrg = Get-IntersightSshPolicy -Organization $org

#Get the SshPolicy based on query Parameter
$SshPolicyByQueryParam = Get-IntersightSshPolicy -Filter Name eq SshPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .