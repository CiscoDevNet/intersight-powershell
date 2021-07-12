#Get the HyperflexAutoSupportPolicy by Name
$HyperflexAutoSupportPolicyByName = Get-IntersightHyperflexAutoSupportPolicy -Name HyperflexAutoSupportPolicyName

#Get the List of ServerProfiles
$HyperflexAutoSupportPolicyList = Get-IntersightHyperflexAutoSupportPolicy

#Get the list of HyperflexAutoSupportPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexAutoSupportPolicyByOrg = Get-IntersightHyperflexAutoSupportPolicy -Organization $org

#Get the HyperflexAutoSupportPolicy based on query Parameter
$HyperflexAutoSupportPolicyByQueryParam = Get-IntersightHyperflexAutoSupportPolicy -Filter Name eq HyperflexAutoSupportPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .