#Get the NiatelemetryMsoEpgDetails by Name
$NiatelemetryMsoEpgDetailsByName = Get-IntersightNiatelemetryMsoEpgDetails -Name NiatelemetryMsoEpgDetailsName

#Get the List of ServerProfiles
$NiatelemetryMsoEpgDetailsList = Get-IntersightNiatelemetryMsoEpgDetails

#Get the list of NiatelemetryMsoEpgDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryMsoEpgDetailsByOrg = Get-IntersightNiatelemetryMsoEpgDetails -Organization $org

#Get the NiatelemetryMsoEpgDetails based on query Parameter
$NiatelemetryMsoEpgDetailsByQueryParam = Get-IntersightNiatelemetryMsoEpgDetails -Filter Name eq NiatelemetryMsoEpgDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .