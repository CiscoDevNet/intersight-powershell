#Get the NiatelemetryAppDetails by Name
$NiatelemetryAppDetailsByName = Get-IntersightNiatelemetryAppDetails -Name NiatelemetryAppDetailsName

#Get the List of ServerProfiles
$NiatelemetryAppDetailsList = Get-IntersightNiatelemetryAppDetails

#Get the list of NiatelemetryAppDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryAppDetailsByOrg = Get-IntersightNiatelemetryAppDetails -Organization $org

#Get the NiatelemetryAppDetails based on query Parameter
$NiatelemetryAppDetailsByQueryParam = Get-IntersightNiatelemetryAppDetails -Filter Name eq NiatelemetryAppDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .