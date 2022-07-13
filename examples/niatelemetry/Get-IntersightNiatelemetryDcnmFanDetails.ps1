#Get the NiatelemetryDcnmFanDetails by Name
$NiatelemetryDcnmFanDetailsByName = Get-IntersightNiatelemetryDcnmFanDetails -Name NiatelemetryDcnmFanDetailsName

#Get the List of ServerProfiles
$NiatelemetryDcnmFanDetailsList = Get-IntersightNiatelemetryDcnmFanDetails

#Get the list of NiatelemetryDcnmFanDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryDcnmFanDetailsByOrg = Get-IntersightNiatelemetryDcnmFanDetails -Organization $org

#Get the NiatelemetryDcnmFanDetails based on query Parameter
$NiatelemetryDcnmFanDetailsByQueryParam = Get-IntersightNiatelemetryDcnmFanDetails -Filter Name eq NiatelemetryDcnmFanDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .