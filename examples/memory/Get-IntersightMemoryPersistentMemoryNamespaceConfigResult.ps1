#Get the MemoryPersistentMemoryNamespaceConfigResult by Name
$MemoryPersistentMemoryNamespaceConfigResultByName = Get-IntersightMemoryPersistentMemoryNamespaceConfigResult -Name MemoryPersistentMemoryNamespaceConfigResultName

#Get the List of ServerProfiles
$MemoryPersistentMemoryNamespaceConfigResultList = Get-IntersightMemoryPersistentMemoryNamespaceConfigResult

#Get the list of MemoryPersistentMemoryNamespaceConfigResult under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MemoryPersistentMemoryNamespaceConfigResultByOrg = Get-IntersightMemoryPersistentMemoryNamespaceConfigResult -Organization $org

#Get the MemoryPersistentMemoryNamespaceConfigResult based on query Parameter
$MemoryPersistentMemoryNamespaceConfigResultByQueryParam = Get-IntersightMemoryPersistentMemoryNamespaceConfigResult -Filter Name eq MemoryPersistentMemoryNamespaceConfigResultName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .