#Get the IqnpoolUniverse by Name
$IqnpoolUniverseByName = Get-IntersightIqnpoolUniverse -Name IqnpoolUniverseName

#Get the List of ServerProfiles
$IqnpoolUniverseList = Get-IntersightIqnpoolUniverse

#Get the list of IqnpoolUniverse under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IqnpoolUniverseByOrg = Get-IntersightIqnpoolUniverse -Organization $org

#Get the IqnpoolUniverse based on query Parameter
$IqnpoolUniverseByQueryParam = Get-IntersightIqnpoolUniverse -Filter Name eq IqnpoolUniverseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .