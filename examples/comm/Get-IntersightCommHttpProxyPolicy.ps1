#Get the CommHttpProxyPolicy by Name
$CommHttpProxyPolicyByName = Get-IntersightCommHttpProxyPolicy -Name CommHttpProxyPolicyName

#Get the List of ServerProfiles
$CommHttpProxyPolicyList = Get-IntersightCommHttpProxyPolicy

#Get the list of CommHttpProxyPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CommHttpProxyPolicyByOrg = Get-IntersightCommHttpProxyPolicy -Organization $org

#Get the CommHttpProxyPolicy based on query Parameter
$CommHttpProxyPolicyByQueryParam = Get-IntersightCommHttpProxyPolicy -Filter Name eq CommHttpProxyPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .