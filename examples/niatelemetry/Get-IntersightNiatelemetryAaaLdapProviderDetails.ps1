#Get the NiatelemetryAaaLdapProviderDetails by Name
$NiatelemetryAaaLdapProviderDetailsByName = Get-IntersightNiatelemetryAaaLdapProviderDetails -Name NiatelemetryAaaLdapProviderDetailsName

#Get the List of ServerProfiles
$NiatelemetryAaaLdapProviderDetailsList = Get-IntersightNiatelemetryAaaLdapProviderDetails

#Get the list of NiatelemetryAaaLdapProviderDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryAaaLdapProviderDetailsByOrg = Get-IntersightNiatelemetryAaaLdapProviderDetails -Organization $org

#Get the NiatelemetryAaaLdapProviderDetails based on query Parameter
$NiatelemetryAaaLdapProviderDetailsByQueryParam = Get-IntersightNiatelemetryAaaLdapProviderDetails -Filter Name eq NiatelemetryAaaLdapProviderDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .