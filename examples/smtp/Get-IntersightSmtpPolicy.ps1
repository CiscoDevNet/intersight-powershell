#Get the SmtpPolicy by Name
$SmtpPolicyByName = Get-IntersightSmtpPolicy -Name SmtpPolicyName

#Get the List of ServerProfiles
$SmtpPolicyList = Get-IntersightSmtpPolicy

#Get the list of SmtpPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SmtpPolicyByOrg = Get-IntersightSmtpPolicy -Organization $org

#Get the SmtpPolicy based on query Parameter
$SmtpPolicyByQueryParam = Get-IntersightSmtpPolicy -Filter Name eq SmtpPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .