#Get the HyperflexProxySettingPolicy by Name
$HyperflexProxySettingPolicyByName = Get-IntersightHyperflexProxySettingPolicy -Name HyperflexProxySettingPolicyName

#Get the List of ServerProfiles
$HyperflexProxySettingPolicyList = Get-IntersightHyperflexProxySettingPolicy

#Get the list of HyperflexProxySettingPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexProxySettingPolicyByOrg = Get-IntersightHyperflexProxySettingPolicy -Organization $org

#Get the HyperflexProxySettingPolicy based on query Parameter
$HyperflexProxySettingPolicyByQueryParam = Get-IntersightHyperflexProxySettingPolicy -Filter Name eq HyperflexProxySettingPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .