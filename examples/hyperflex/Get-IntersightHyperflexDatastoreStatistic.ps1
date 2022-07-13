#Get the HyperflexDatastoreStatistic by Name
$HyperflexDatastoreStatisticByName = Get-IntersightHyperflexDatastoreStatistic -Name HyperflexDatastoreStatisticName

#Get the List of ServerProfiles
$HyperflexDatastoreStatisticList = Get-IntersightHyperflexDatastoreStatistic

#Get the list of HyperflexDatastoreStatistic under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexDatastoreStatisticByOrg = Get-IntersightHyperflexDatastoreStatistic -Organization $org

#Get the HyperflexDatastoreStatistic based on query Parameter
$HyperflexDatastoreStatisticByQueryParam = Get-IntersightHyperflexDatastoreStatistic -Filter Name eq HyperflexDatastoreStatisticName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .