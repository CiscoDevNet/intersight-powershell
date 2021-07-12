#Get the BiosUnit by Name
$BiosUnitByName = Get-IntersightBiosUnit -Name BiosUnitName

#Get the List of ServerProfiles
$BiosUnitList = Get-IntersightBiosUnit

#Get the list of BiosUnit under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BiosUnitByOrg = Get-IntersightBiosUnit -Organization $org

#Get the BiosUnit based on query Parameter
$BiosUnitByQueryParam = Get-IntersightBiosUnit -Filter Name eq BiosUnitName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .