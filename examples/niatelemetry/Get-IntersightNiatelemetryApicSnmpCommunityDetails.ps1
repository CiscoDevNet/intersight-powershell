#Get the NiatelemetryApicSnmpCommunityDetails by Name
$NiatelemetryApicSnmpCommunityDetailsByName = Get-IntersightNiatelemetryApicSnmpCommunityDetails -Name NiatelemetryApicSnmpCommunityDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicSnmpCommunityDetailsList = Get-IntersightNiatelemetryApicSnmpCommunityDetails

#Get the list of NiatelemetryApicSnmpCommunityDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryApicSnmpCommunityDetailsByOrg = Get-IntersightNiatelemetryApicSnmpCommunityDetails -Organization $org

#Get the NiatelemetryApicSnmpCommunityDetails based on query Parameter
$NiatelemetryApicSnmpCommunityDetailsByQueryParam = Get-IntersightNiatelemetryApicSnmpCommunityDetails -Filter Name eq NiatelemetryApicSnmpCommunityDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .