#Get the NiatelemetryApicSnmpTrapDetails by Name
$NiatelemetryApicSnmpTrapDetailsByName = Get-IntersightNiatelemetryApicSnmpTrapDetails -Name NiatelemetryApicSnmpTrapDetailsName

#Get the List of ServerProfiles
$NiatelemetryApicSnmpTrapDetailsList = Get-IntersightNiatelemetryApicSnmpTrapDetails

#Get the list of NiatelemetryApicSnmpTrapDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryApicSnmpTrapDetailsByOrg = Get-IntersightNiatelemetryApicSnmpTrapDetails -Organization $org

#Get the NiatelemetryApicSnmpTrapDetails based on query Parameter
$NiatelemetryApicSnmpTrapDetailsByQueryParam = Get-IntersightNiatelemetryApicSnmpTrapDetails -Filter Name eq NiatelemetryApicSnmpTrapDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .