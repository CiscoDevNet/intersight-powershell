#Get the HyperflexUcsmConfigPolicy by Name
$HyperflexUcsmConfigPolicyByName = Get-IntersightHyperflexUcsmConfigPolicy -Name HyperflexUcsmConfigPolicyName

#Get the List of ServerProfiles
$HyperflexUcsmConfigPolicyList = Get-IntersightHyperflexUcsmConfigPolicy

#Get the list of HyperflexUcsmConfigPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexUcsmConfigPolicyByOrg = Get-IntersightHyperflexUcsmConfigPolicy -Organization $org

#Get the HyperflexUcsmConfigPolicy based on query Parameter
$HyperflexUcsmConfigPolicyByQueryParam = Get-IntersightHyperflexUcsmConfigPolicy -Filter Name eq HyperflexUcsmConfigPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .