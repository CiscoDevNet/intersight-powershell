#Get the HyperflexExtFcStoragePolicy by Name
$HyperflexExtFcStoragePolicyByName = Get-IntersightHyperflexExtFcStoragePolicy -Name HyperflexExtFcStoragePolicyName

#Get the List of ServerProfiles
$HyperflexExtFcStoragePolicyList = Get-IntersightHyperflexExtFcStoragePolicy

#Get the list of HyperflexExtFcStoragePolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexExtFcStoragePolicyByOrg = Get-IntersightHyperflexExtFcStoragePolicy -Organization $org

#Get the HyperflexExtFcStoragePolicy based on query Parameter
$HyperflexExtFcStoragePolicyByQueryParam = Get-IntersightHyperflexExtFcStoragePolicy -Filter Name eq HyperflexExtFcStoragePolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .