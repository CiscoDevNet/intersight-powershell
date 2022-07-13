#Get the SecurityUnit by Name
$SecurityUnitByName = Get-IntersightSecurityUnit -Name SecurityUnitName

#Get the List of ServerProfiles
$SecurityUnitList = Get-IntersightSecurityUnit

#Get the list of SecurityUnit under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$SecurityUnitByOrg = Get-IntersightSecurityUnit -Organization $org

#Get the SecurityUnit based on query Parameter
$SecurityUnitByQueryParam = Get-IntersightSecurityUnit -Filter Name eq SecurityUnitName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .