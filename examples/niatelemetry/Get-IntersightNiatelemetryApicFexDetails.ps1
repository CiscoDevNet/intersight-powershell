#Get the NiatelemetryApicFexDetails by Name
$NiatelemetryApicFexDetailsByName = Get-IntersightNiatelemetryApicFexDetails -Name NiatelemetryApicFexDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicFexDetailsList = Get-IntersightNiatelemetryApicFexDetails

#Get the list of NiatelemetryApicFexDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryApicFexDetailsByOrg = Get-IntersightNiatelemetryApicFexDetails -Organization $org

#Get the NiatelemetryApicFexDetails based on query Parameter
$NiatelemetryApicFexDetailsByQueryParam = Get-IntersightNiatelemetryApicFexDetails -Filter Name eq NiatelemetryApicFexDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .