#Get the NiatelemetryNexusDashboardMemoryDetails by Name
$NiatelemetryNexusDashboardMemoryDetailsByName = Get-IntersightNiatelemetryNexusDashboardMemoryDetails -Name NiatelemetryNexusDashboardMemoryDetailsName

#Get the List of ServerProfiles
$NiatelemetryNexusDashboardMemoryDetailsList = Get-IntersightNiatelemetryNexusDashboardMemoryDetails

#Get the list of NiatelemetryNexusDashboardMemoryDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryNexusDashboardMemoryDetailsByOrg = Get-IntersightNiatelemetryNexusDashboardMemoryDetails -Organization $org

#Get the NiatelemetryNexusDashboardMemoryDetails based on query Parameter
$NiatelemetryNexusDashboardMemoryDetailsByQueryParam = Get-IntersightNiatelemetryNexusDashboardMemoryDetails -Filter Name eq NiatelemetryNexusDashboardMemoryDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .