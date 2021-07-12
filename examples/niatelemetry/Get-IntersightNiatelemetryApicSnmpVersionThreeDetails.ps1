#Get the NiatelemetryApicSnmpVersionThreeDetails by Name
$NiatelemetryApicSnmpVersionThreeDetailsByName = Get-IntersightNiatelemetryApicSnmpVersionThreeDetails -Name NiatelemetryApicSnmpVersionThreeDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicSnmpVersionThreeDetailsList = Get-IntersightNiatelemetryApicSnmpVersionThreeDetails

#Get the list of NiatelemetryApicSnmpVersionThreeDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryApicSnmpVersionThreeDetailsByOrg = Get-IntersightNiatelemetryApicSnmpVersionThreeDetails -Organization $org

#Get the NiatelemetryApicSnmpVersionThreeDetails based on query Parameter
$NiatelemetryApicSnmpVersionThreeDetailsByQueryParam = Get-IntersightNiatelemetryApicSnmpVersionThreeDetails -Filter Name eq NiatelemetryApicSnmpVersionThreeDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .