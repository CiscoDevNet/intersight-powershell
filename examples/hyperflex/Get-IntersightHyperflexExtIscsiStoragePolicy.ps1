#Get the HyperflexExtIscsiStoragePolicy by Name
$HyperflexExtIscsiStoragePolicyByName = Get-IntersightHyperflexExtIscsiStoragePolicy -Name HyperflexExtIscsiStoragePolicyName

#Get the List of ServerProfiles
$HyperflexExtIscsiStoragePolicyList = Get-IntersightHyperflexExtIscsiStoragePolicy

#Get the list of HyperflexExtIscsiStoragePolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexExtIscsiStoragePolicyByOrg = Get-IntersightHyperflexExtIscsiStoragePolicy -Organization $org

#Get the HyperflexExtIscsiStoragePolicy based on query Parameter
$HyperflexExtIscsiStoragePolicyByQueryParam = Get-IntersightHyperflexExtIscsiStoragePolicy -Filter Name eq HyperflexExtIscsiStoragePolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .