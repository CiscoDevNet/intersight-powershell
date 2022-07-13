#Get the HyperflexHealth by Name
$HyperflexHealthByName = Get-IntersightHyperflexHealth -Name HyperflexHealthName

#Get the List of ServerProfiles
$HyperflexHealthList = Get-IntersightHyperflexHealth

#Get the list of HyperflexHealth under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHealthByOrg = Get-IntersightHyperflexHealth -Organization $org

#Get the HyperflexHealth based on query Parameter
$HyperflexHealthByQueryParam = Get-IntersightHyperflexHealth -Filter Name eq HyperflexHealthName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .