#Get the OsDistribution by Name
$OsDistributionByName = Get-IntersightOsDistribution -Name OsDistributionName

#Get the List of ServerProfiles
$OsDistributionList = Get-IntersightOsDistribution

#Get the list of OsDistribution under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$OsDistributionByOrg = Get-IntersightOsDistribution -Organization $org

#Get the OsDistribution based on query Parameter
$OsDistributionByQueryParam = Get-IntersightOsDistribution -Filter Name eq OsDistributionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .