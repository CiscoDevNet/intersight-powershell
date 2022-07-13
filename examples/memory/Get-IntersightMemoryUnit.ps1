#Get the MemoryUnit by Name
$MemoryUnitByName = Get-IntersightMemoryUnit -Name MemoryUnitName

#Get the List of ServerProfiles
$MemoryUnitList = Get-IntersightMemoryUnit

#Get the list of MemoryUnit under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MemoryUnitByOrg = Get-IntersightMemoryUnit -Organization $org

#Get the MemoryUnit based on query Parameter
$MemoryUnitByQueryParam = Get-IntersightMemoryUnit -Filter Name eq MemoryUnitName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .