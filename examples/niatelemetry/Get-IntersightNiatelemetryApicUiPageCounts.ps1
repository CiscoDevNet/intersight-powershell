#Get the NiatelemetryApicUiPageCounts by Name
$NiatelemetryApicUiPageCountsByName = Get-IntersightNiatelemetryApicUiPageCounts -Name NiatelemetryApicUiPageCountsName

#Get the List of ServerProfiles
$NiatelemetryApicUiPageCountsList = Get-IntersightNiatelemetryApicUiPageCounts

#Get the list of NiatelemetryApicUiPageCounts under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryApicUiPageCountsByOrg = Get-IntersightNiatelemetryApicUiPageCounts -Organization $org

#Get the NiatelemetryApicUiPageCounts based on query Parameter
$NiatelemetryApicUiPageCountsByQueryParam = Get-IntersightNiatelemetryApicUiPageCounts -Filter Name eq NiatelemetryApicUiPageCountsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .