#Get the NetworkconfigPolicy by Name
$NetworkconfigPolicyByName = Get-IntersightNetworkconfigPolicy -Name NetworkconfigPolicyName

#Get the List of ServerProfiles
$NetworkconfigPolicyList = Get-IntersightNetworkconfigPolicy

#Get the list of NetworkconfigPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NetworkconfigPolicyByOrg = Get-IntersightNetworkconfigPolicy -Organization $org

#Get the NetworkconfigPolicy based on query Parameter
$NetworkconfigPolicyByQueryParam = Get-IntersightNetworkconfigPolicy -Filter Name eq NetworkconfigPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .