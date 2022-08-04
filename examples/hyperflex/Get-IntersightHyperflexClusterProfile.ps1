#Get the HyperflexClusterProfile by Name
$HyperflexClusterProfileByName = Get-IntersightHyperflexClusterProfile -Name HyperflexClusterProfileName

#Get the List of ServerProfiles
$HyperflexClusterProfileList = Get-IntersightHyperflexClusterProfile

#Get the list of HyperflexClusterProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexClusterProfileByOrg = Get-IntersightHyperflexClusterProfile -Organization $org

#Get the HyperflexClusterProfile based on query Parameter
$HyperflexClusterProfileByQueryParam = Get-IntersightHyperflexClusterProfile -Filter Name eq HyperflexClusterProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .