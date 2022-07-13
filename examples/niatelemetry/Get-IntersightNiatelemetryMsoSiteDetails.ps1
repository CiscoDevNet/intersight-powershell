#Get the NiatelemetryMsoSiteDetails by Name
$NiatelemetryMsoSiteDetailsByName = Get-IntersightNiatelemetryMsoSiteDetails -Name NiatelemetryMsoSiteDetailsName

#Get the List of ServerProfiles
$NiatelemetryMsoSiteDetailsList = Get-IntersightNiatelemetryMsoSiteDetails

#Get the list of NiatelemetryMsoSiteDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryMsoSiteDetailsByOrg = Get-IntersightNiatelemetryMsoSiteDetails -Organization $org

#Get the NiatelemetryMsoSiteDetails based on query Parameter
$NiatelemetryMsoSiteDetailsByQueryParam = Get-IntersightNiatelemetryMsoSiteDetails -Filter Name eq NiatelemetryMsoSiteDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .