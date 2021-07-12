#Get the IppoolUniverse by Name
$IppoolUniverseByName = Get-IntersightIppoolUniverse -Name IppoolUniverseName

#Get the List of ServerProfiles
$IppoolUniverseList = Get-IntersightIppoolUniverse

#Get the list of IppoolUniverse under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IppoolUniverseByOrg = Get-IntersightIppoolUniverse -Organization $org

#Get the IppoolUniverse based on query Parameter
$IppoolUniverseByQueryParam = Get-IntersightIppoolUniverse -Filter Name eq IppoolUniverseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .