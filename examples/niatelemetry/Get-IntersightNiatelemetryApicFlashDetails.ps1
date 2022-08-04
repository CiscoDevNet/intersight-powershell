#Get the NiatelemetryApicFlashDetails by Name
$NiatelemetryApicFlashDetailsByName = Get-IntersightNiatelemetryApicFlashDetails -Name NiatelemetryApicFlashDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicFlashDetailsList = Get-IntersightNiatelemetryApicFlashDetails

#Get the list of NiatelemetryApicFlashDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryApicFlashDetailsByOrg = Get-IntersightNiatelemetryApicFlashDetails -Organization $org

#Get the NiatelemetryApicFlashDetails based on query Parameter
$NiatelemetryApicFlashDetailsByQueryParam = Get-IntersightNiatelemetryApicFlashDetails -Filter Name eq NiatelemetryApicFlashDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .