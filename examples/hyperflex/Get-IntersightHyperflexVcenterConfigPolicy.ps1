#Get the HyperflexVcenterConfigPolicy by Name
$HyperflexVcenterConfigPolicyByName = Get-IntersightHyperflexVcenterConfigPolicy -Name HyperflexVcenterConfigPolicyName

#Get the List of ServerProfiles
$HyperflexVcenterConfigPolicyList = Get-IntersightHyperflexVcenterConfigPolicy

#Get the list of HyperflexVcenterConfigPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexVcenterConfigPolicyByOrg = Get-IntersightHyperflexVcenterConfigPolicy -Organization $org

#Get the HyperflexVcenterConfigPolicy based on query Parameter
$HyperflexVcenterConfigPolicyByQueryParam = Get-IntersightHyperflexVcenterConfigPolicy -Filter Name eq HyperflexVcenterConfigPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .