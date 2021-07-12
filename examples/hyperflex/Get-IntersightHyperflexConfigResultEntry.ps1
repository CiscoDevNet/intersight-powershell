#Get the HyperflexConfigResultEntry by Name
$HyperflexConfigResultEntryByName = Get-IntersightHyperflexConfigResultEntry -Name HyperflexConfigResultEntryName

#Get the List of ServerProfiles
$HyperflexConfigResultEntryList = Get-IntersightHyperflexConfigResultEntry

#Get the list of HyperflexConfigResultEntry under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexConfigResultEntryByOrg = Get-IntersightHyperflexConfigResultEntry -Organization $org

#Get the HyperflexConfigResultEntry based on query Parameter
$HyperflexConfigResultEntryByQueryParam = Get-IntersightHyperflexConfigResultEntry -Filter Name eq HyperflexConfigResultEntryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .