#Get the NiatelemetryApicCoreFileDetails by Name
$NiatelemetryApicCoreFileDetailsByName = Get-IntersightNiatelemetryApicCoreFileDetails -Name NiatelemetryApicCoreFileDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicCoreFileDetailsList = Get-IntersightNiatelemetryApicCoreFileDetails

#Get the list of NiatelemetryApicCoreFileDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryApicCoreFileDetailsByOrg = Get-IntersightNiatelemetryApicCoreFileDetails -Organization $org

#Get the NiatelemetryApicCoreFileDetails based on query Parameter
$NiatelemetryApicCoreFileDetailsByQueryParam = Get-IntersightNiatelemetryApicCoreFileDetails -Filter Name eq NiatelemetryApicCoreFileDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .