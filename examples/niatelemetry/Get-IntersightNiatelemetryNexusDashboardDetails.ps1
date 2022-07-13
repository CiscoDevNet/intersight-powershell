#Get the NiatelemetryNexusDashboardDetails by Name
$NiatelemetryNexusDashboardDetailsByName = Get-IntersightNiatelemetryNexusDashboardDetails -Name NiatelemetryNexusDashboardDetailsName

#Get the List of ServerProfiles
$NiatelemetryNexusDashboardDetailsList = Get-IntersightNiatelemetryNexusDashboardDetails

#Get the list of NiatelemetryNexusDashboardDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryNexusDashboardDetailsByOrg = Get-IntersightNiatelemetryNexusDashboardDetails -Organization $org

#Get the NiatelemetryNexusDashboardDetails based on query Parameter
$NiatelemetryNexusDashboardDetailsByQueryParam = Get-IntersightNiatelemetryNexusDashboardDetails -Filter Name eq NiatelemetryNexusDashboardDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .