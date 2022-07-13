#Get the NtpPolicy by Name
$NtpPolicyByName = Get-IntersightNtpPolicy -Name NtpPolicyName

#Get the List of ServerProfiles
$NtpPolicyList = Get-IntersightNtpPolicy

#Get the list of NtpPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NtpPolicyByOrg = Get-IntersightNtpPolicy -Organization $org

#Get the NtpPolicy based on query Parameter
$NtpPolicyByQueryParam = Get-IntersightNtpPolicy -Filter Name eq NtpPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .