#Get the NetworkElementSummary by Name
$NetworkElementSummaryByName = Get-IntersightNetworkElementSummary -Name NetworkElementSummaryName

#Get the List of ServerProfiles
$NetworkElementSummaryList = Get-IntersightNetworkElementSummary

#Get the list of NetworkElementSummary under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NetworkElementSummaryByOrg = Get-IntersightNetworkElementSummary -Organization $org

#Get the NetworkElementSummary based on query Parameter
$NetworkElementSummaryByQueryParam = Get-IntersightNetworkElementSummary -Filter Name eq NetworkElementSummaryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .