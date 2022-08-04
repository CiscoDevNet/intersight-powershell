#Get the NiatelemetryDcnmPsuDetails by Name
$NiatelemetryDcnmPsuDetailsByName = Get-IntersightNiatelemetryDcnmPsuDetails -Name NiatelemetryDcnmPsuDetailsName

#Get the List of ServerProfiles
$NiatelemetryDcnmPsuDetailsList = Get-IntersightNiatelemetryDcnmPsuDetails

#Get the list of NiatelemetryDcnmPsuDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryDcnmPsuDetailsByOrg = Get-IntersightNiatelemetryDcnmPsuDetails -Organization $org

#Get the NiatelemetryDcnmPsuDetails based on query Parameter
$NiatelemetryDcnmPsuDetailsByQueryParam = Get-IntersightNiatelemetryDcnmPsuDetails -Filter Name eq NiatelemetryDcnmPsuDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .