#Get the NiatelemetrySshVersionTwo by Name
$NiatelemetrySshVersionTwoByName = Get-IntersightNiatelemetrySshVersionTwo -Name NiatelemetrySshVersionTwoName

#Get the List of ServerProfiles
$NiatelemetrySshVersionTwoList = Get-IntersightNiatelemetrySshVersionTwo

#Get the list of NiatelemetrySshVersionTwo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetrySshVersionTwoByOrg = Get-IntersightNiatelemetrySshVersionTwo -Organization $org

#Get the NiatelemetrySshVersionTwo based on query Parameter
$NiatelemetrySshVersionTwoByQueryParam = Get-IntersightNiatelemetrySshVersionTwo -Filter Name eq NiatelemetrySshVersionTwoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .