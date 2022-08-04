#Get the NiatelemetryApicSnmpCommunityAccessDetails by Name
$NiatelemetryApicSnmpCommunityAccessDetailsByName = Get-IntersightNiatelemetryApicSnmpCommunityAccessDetails -Name NiatelemetryApicSnmpCommunityAccessDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicSnmpCommunityAccessDetailsList = Get-IntersightNiatelemetryApicSnmpCommunityAccessDetails

#Get the list of NiatelemetryApicSnmpCommunityAccessDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryApicSnmpCommunityAccessDetailsByOrg = Get-IntersightNiatelemetryApicSnmpCommunityAccessDetails -Organization $org

#Get the NiatelemetryApicSnmpCommunityAccessDetails based on query Parameter
$NiatelemetryApicSnmpCommunityAccessDetailsByQueryParam = Get-IntersightNiatelemetryApicSnmpCommunityAccessDetails -Filter Name eq NiatelemetryApicSnmpCommunityAccessDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .