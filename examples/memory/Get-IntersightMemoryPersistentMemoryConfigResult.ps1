#Get the MemoryPersistentMemoryConfigResult by Name
$MemoryPersistentMemoryConfigResultByName = Get-IntersightMemoryPersistentMemoryConfigResult -Name MemoryPersistentMemoryConfigResultName

#Get the List of ServerProfiles
$MemoryPersistentMemoryConfigResultList = Get-IntersightMemoryPersistentMemoryConfigResult

#Get the list of MemoryPersistentMemoryConfigResult under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MemoryPersistentMemoryConfigResultByOrg = Get-IntersightMemoryPersistentMemoryConfigResult -Organization $org

#Get the MemoryPersistentMemoryConfigResult based on query Parameter
$MemoryPersistentMemoryConfigResultByQueryParam = Get-IntersightMemoryPersistentMemoryConfigResult -Filter Name eq MemoryPersistentMemoryConfigResultName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .