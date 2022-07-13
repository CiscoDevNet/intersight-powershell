#Get the MemoryPersistentMemoryNamespace by Name
$MemoryPersistentMemoryNamespaceByName = Get-IntersightMemoryPersistentMemoryNamespace -Name MemoryPersistentMemoryNamespaceName

#Get the List of ServerProfiles
$MemoryPersistentMemoryNamespaceList = Get-IntersightMemoryPersistentMemoryNamespace

#Get the list of MemoryPersistentMemoryNamespace under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MemoryPersistentMemoryNamespaceByOrg = Get-IntersightMemoryPersistentMemoryNamespace -Organization $org

#Get the MemoryPersistentMemoryNamespace based on query Parameter
$MemoryPersistentMemoryNamespaceByQueryParam = Get-IntersightMemoryPersistentMemoryNamespace -Filter Name eq MemoryPersistentMemoryNamespaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .