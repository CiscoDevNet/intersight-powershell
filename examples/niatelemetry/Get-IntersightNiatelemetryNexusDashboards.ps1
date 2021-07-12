#Get the NiatelemetryNexusDashboards by Name
$NiatelemetryNexusDashboardsByName = Get-IntersightNiatelemetryNexusDashboards -Name NiatelemetryNexusDashboardsName

#Get the List of ServerProfiles
$NiatelemetryNexusDashboardsList = Get-IntersightNiatelemetryNexusDashboards

#Get the list of NiatelemetryNexusDashboards under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryNexusDashboardsByOrg = Get-IntersightNiatelemetryNexusDashboards -Organization $org

#Get the NiatelemetryNexusDashboards based on query Parameter
$NiatelemetryNexusDashboardsByQueryParam = Get-IntersightNiatelemetryNexusDashboards -Filter Name eq NiatelemetryNexusDashboardsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .