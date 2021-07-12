#Get the NiatelemetryApicPsuDetails by Name
$NiatelemetryApicPsuDetailsByName = Get-IntersightNiatelemetryApicPsuDetails -Name NiatelemetryApicPsuDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicPsuDetailsList = Get-IntersightNiatelemetryApicPsuDetails

#Get the list of NiatelemetryApicPsuDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryApicPsuDetailsByOrg = Get-IntersightNiatelemetryApicPsuDetails -Organization $org

#Get the NiatelemetryApicPsuDetails based on query Parameter
$NiatelemetryApicPsuDetailsByQueryParam = Get-IntersightNiatelemetryApicPsuDetails -Filter Name eq NiatelemetryApicPsuDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .