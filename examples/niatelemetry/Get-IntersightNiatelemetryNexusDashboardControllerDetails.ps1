#Get the NiatelemetryNexusDashboardControllerDetails by Name
$NiatelemetryNexusDashboardControllerDetailsByName = Get-IntersightNiatelemetryNexusDashboardControllerDetails -Name NiatelemetryNexusDashboardControllerDetailsName

#Get the List of ServerProfiles
$NiatelemetryNexusDashboardControllerDetailsList = Get-IntersightNiatelemetryNexusDashboardControllerDetails

#Get the list of NiatelemetryNexusDashboardControllerDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryNexusDashboardControllerDetailsByOrg = Get-IntersightNiatelemetryNexusDashboardControllerDetails -Organization $org

#Get the NiatelemetryNexusDashboardControllerDetails based on query Parameter
$NiatelemetryNexusDashboardControllerDetailsByQueryParam = Get-IntersightNiatelemetryNexusDashboardControllerDetails -Filter Name eq NiatelemetryNexusDashboardControllerDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .