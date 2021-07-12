#Get the MemoryPersistentMemoryUnit by Name
$MemoryPersistentMemoryUnitByName = Get-IntersightMemoryPersistentMemoryUnit -Name MemoryPersistentMemoryUnitName

#Get the List of ServerProfiles
$MemoryPersistentMemoryUnitList = Get-IntersightMemoryPersistentMemoryUnit

#Get the list of MemoryPersistentMemoryUnit under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$MemoryPersistentMemoryUnitByOrg = Get-IntersightMemoryPersistentMemoryUnit -Organization $org

#Get the MemoryPersistentMemoryUnit based on query Parameter
$MemoryPersistentMemoryUnitByQueryParam = Get-IntersightMemoryPersistentMemoryUnit -Filter Name eq MemoryPersistentMemoryUnitName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .