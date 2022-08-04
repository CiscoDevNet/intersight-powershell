#Get the NiatelemetryApicFanDetails by Name
$NiatelemetryApicFanDetailsByName = Get-IntersightNiatelemetryApicFanDetails -Name NiatelemetryApicFanDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicFanDetailsList = Get-IntersightNiatelemetryApicFanDetails

#Get the list of NiatelemetryApicFanDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryApicFanDetailsByOrg = Get-IntersightNiatelemetryApicFanDetails -Organization $org

#Get the NiatelemetryApicFanDetails based on query Parameter
$NiatelemetryApicFanDetailsByQueryParam = Get-IntersightNiatelemetryApicFanDetails -Filter Name eq NiatelemetryApicFanDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .