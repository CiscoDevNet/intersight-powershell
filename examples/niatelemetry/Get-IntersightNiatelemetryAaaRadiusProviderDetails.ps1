#Get the NiatelemetryAaaRadiusProviderDetails by Name
$NiatelemetryAaaRadiusProviderDetailsByName = Get-IntersightNiatelemetryAaaRadiusProviderDetails -Name NiatelemetryAaaRadiusProviderDetailsName

#Get the List of ServerProfiles
$NiatelemetryAaaRadiusProviderDetailsList = Get-IntersightNiatelemetryAaaRadiusProviderDetails

#Get the list of NiatelemetryAaaRadiusProviderDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryAaaRadiusProviderDetailsByOrg = Get-IntersightNiatelemetryAaaRadiusProviderDetails -Organization $org

#Get the NiatelemetryAaaRadiusProviderDetails based on query Parameter
$NiatelemetryAaaRadiusProviderDetailsByQueryParam = Get-IntersightNiatelemetryAaaRadiusProviderDetails -Filter Name eq NiatelemetryAaaRadiusProviderDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .