#Get the NiatelemetryAaaTacacsProviderDetails by Name
$NiatelemetryAaaTacacsProviderDetailsByName = Get-IntersightNiatelemetryAaaTacacsProviderDetails -Name NiatelemetryAaaTacacsProviderDetailsName

#Get the List of ServerProfiles
$NiatelemetryAaaTacacsProviderDetailsList = Get-IntersightNiatelemetryAaaTacacsProviderDetails

#Get the list of NiatelemetryAaaTacacsProviderDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryAaaTacacsProviderDetailsByOrg = Get-IntersightNiatelemetryAaaTacacsProviderDetails -Organization $org

#Get the NiatelemetryAaaTacacsProviderDetails based on query Parameter
$NiatelemetryAaaTacacsProviderDetailsByQueryParam = Get-IntersightNiatelemetryAaaTacacsProviderDetails -Filter Name eq NiatelemetryAaaTacacsProviderDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .