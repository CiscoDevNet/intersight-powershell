#Get the NiatelemetryDcnmFexDetails by Name
$NiatelemetryDcnmFexDetailsByName = Get-IntersightNiatelemetryDcnmFexDetails -Name NiatelemetryDcnmFexDetailsName

#Get the List of ServerProfiles
$NiatelemetryDcnmFexDetailsList = Get-IntersightNiatelemetryDcnmFexDetails

#Get the list of NiatelemetryDcnmFexDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryDcnmFexDetailsByOrg = Get-IntersightNiatelemetryDcnmFexDetails -Organization $org

#Get the NiatelemetryDcnmFexDetails based on query Parameter
$NiatelemetryDcnmFexDetailsByQueryParam = Get-IntersightNiatelemetryDcnmFexDetails -Filter Name eq NiatelemetryDcnmFexDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .