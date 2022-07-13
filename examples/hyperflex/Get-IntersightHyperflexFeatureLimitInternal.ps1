#Get the HyperflexFeatureLimitInternal by Name
$HyperflexFeatureLimitInternalByName = Get-IntersightHyperflexFeatureLimitInternal -Name HyperflexFeatureLimitInternalName

#Get the List of ServerProfiles
$HyperflexFeatureLimitInternalList = Get-IntersightHyperflexFeatureLimitInternal

#Get the list of HyperflexFeatureLimitInternal under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexFeatureLimitInternalByOrg = Get-IntersightHyperflexFeatureLimitInternal -Organization $org

#Get the HyperflexFeatureLimitInternal based on query Parameter
$HyperflexFeatureLimitInternalByQueryParam = Get-IntersightHyperflexFeatureLimitInternal -Filter Name eq HyperflexFeatureLimitInternalName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .