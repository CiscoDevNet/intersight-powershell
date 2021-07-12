#Get the MacpoolUniverse by Name
$MacpoolUniverseByName = Get-IntersightMacpoolUniverse -Name MacpoolUniverseName

#Get the List of ServerProfiles
$MacpoolUniverseList = Get-IntersightMacpoolUniverse

#Get the list of MacpoolUniverse under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$MacpoolUniverseByOrg = Get-IntersightMacpoolUniverse -Organization $org

#Get the MacpoolUniverse based on query Parameter
$MacpoolUniverseByQueryParam = Get-IntersightMacpoolUniverse -Filter Name eq MacpoolUniverseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .