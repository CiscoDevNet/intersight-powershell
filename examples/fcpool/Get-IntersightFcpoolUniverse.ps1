#Get the FcpoolUniverse by Name
$FcpoolUniverseByName = Get-IntersightFcpoolUniverse -Name FcpoolUniverseName

#Get the List of ServerProfiles
$FcpoolUniverseList = Get-IntersightFcpoolUniverse

#Get the list of FcpoolUniverse under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FcpoolUniverseByOrg = Get-IntersightFcpoolUniverse -Organization $org

#Get the FcpoolUniverse based on query Parameter
$FcpoolUniverseByQueryParam = Get-IntersightFcpoolUniverse -Filter Name eq FcpoolUniverseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .