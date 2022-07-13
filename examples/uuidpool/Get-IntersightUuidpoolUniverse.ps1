#Get the UuidpoolUniverse by Name
$UuidpoolUniverseByName = Get-IntersightUuidpoolUniverse -Name UuidpoolUniverseName

#Get the List of ServerProfiles
$UuidpoolUniverseList = Get-IntersightUuidpoolUniverse

#Get the list of UuidpoolUniverse under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$UuidpoolUniverseByOrg = Get-IntersightUuidpoolUniverse -Organization $org

#Get the UuidpoolUniverse based on query Parameter
$UuidpoolUniverseByQueryParam = Get-IntersightUuidpoolUniverse -Filter Name eq UuidpoolUniverseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .