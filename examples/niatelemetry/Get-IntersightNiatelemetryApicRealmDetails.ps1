#Get the NiatelemetryApicRealmDetails by Name
$NiatelemetryApicRealmDetailsByName = Get-IntersightNiatelemetryApicRealmDetails -Name NiatelemetryApicRealmDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicRealmDetailsList = Get-IntersightNiatelemetryApicRealmDetails

#Get the list of NiatelemetryApicRealmDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryApicRealmDetailsByOrg = Get-IntersightNiatelemetryApicRealmDetails -Organization $org

#Get the NiatelemetryApicRealmDetails based on query Parameter
$NiatelemetryApicRealmDetailsByQueryParam = Get-IntersightNiatelemetryApicRealmDetails -Filter Name eq NiatelemetryApicRealmDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .