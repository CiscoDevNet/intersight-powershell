#Get the HyperflexClusterStoragePolicy by Name
$HyperflexClusterStoragePolicyByName = Get-IntersightHyperflexClusterStoragePolicy -Name HyperflexClusterStoragePolicyName

#Get the List of ServerProfiles
$HyperflexClusterStoragePolicyList = Get-IntersightHyperflexClusterStoragePolicy

#Get the list of HyperflexClusterStoragePolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexClusterStoragePolicyByOrg = Get-IntersightHyperflexClusterStoragePolicy -Organization $org

#Get the HyperflexClusterStoragePolicy based on query Parameter
$HyperflexClusterStoragePolicyByQueryParam = Get-IntersightHyperflexClusterStoragePolicy -Filter Name eq HyperflexClusterStoragePolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .