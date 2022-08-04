#Get the TopSystem by Name
$TopSystemByName = Get-IntersightTopSystem -Name TopSystemName

#Get the List of ServerProfiles
$TopSystemList = Get-IntersightTopSystem

#Get the list of TopSystem under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$TopSystemByOrg = Get-IntersightTopSystem -Organization $org

#Get the TopSystem based on query Parameter
$TopSystemByQueryParam = Get-IntersightTopSystem -Filter Name eq TopSystemName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .