#Get the HyperflexFeatureLimitExternal by Name
$HyperflexFeatureLimitExternalByName = Get-IntersightHyperflexFeatureLimitExternal -Name HyperflexFeatureLimitExternalName

#Get the List of ServerProfiles
$HyperflexFeatureLimitExternalList = Get-IntersightHyperflexFeatureLimitExternal

#Get the list of HyperflexFeatureLimitExternal under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexFeatureLimitExternalByOrg = Get-IntersightHyperflexFeatureLimitExternal -Organization $org

#Get the HyperflexFeatureLimitExternal based on query Parameter
$HyperflexFeatureLimitExternalByQueryParam = Get-IntersightHyperflexFeatureLimitExternal -Filter Name eq HyperflexFeatureLimitExternalName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .