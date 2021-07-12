#Get the HyperflexNodeProfile by Name
$HyperflexNodeProfileByName = Get-IntersightHyperflexNodeProfile -Name HyperflexNodeProfileName

#Get the List of ServerProfiles
$HyperflexNodeProfileList = Get-IntersightHyperflexNodeProfile

#Get the list of HyperflexNodeProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexNodeProfileByOrg = Get-IntersightHyperflexNodeProfile -Organization $org

#Get the HyperflexNodeProfile based on query Parameter
$HyperflexNodeProfileByQueryParam = Get-IntersightHyperflexNodeProfile -Filter Name eq HyperflexNodeProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .