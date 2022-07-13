#Get the HyperflexNodeConfigPolicy by Name
$HyperflexNodeConfigPolicyByName = Get-IntersightHyperflexNodeConfigPolicy -Name HyperflexNodeConfigPolicyName

#Get the List of ServerProfiles
$HyperflexNodeConfigPolicyList = Get-IntersightHyperflexNodeConfigPolicy

#Get the list of HyperflexNodeConfigPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexNodeConfigPolicyByOrg = Get-IntersightHyperflexNodeConfigPolicy -Organization $org

#Get the HyperflexNodeConfigPolicy based on query Parameter
$HyperflexNodeConfigPolicyByQueryParam = Get-IntersightHyperflexNodeConfigPolicy -Filter Name eq HyperflexNodeConfigPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .