#Get the MemoryPersistentMemoryConfiguration by Name
$MemoryPersistentMemoryConfigurationByName = Get-IntersightMemoryPersistentMemoryConfiguration -Name MemoryPersistentMemoryConfigurationName

#Get the List of ServerProfiles
$MemoryPersistentMemoryConfigurationList = Get-IntersightMemoryPersistentMemoryConfiguration

#Get the list of MemoryPersistentMemoryConfiguration under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MemoryPersistentMemoryConfigurationByOrg = Get-IntersightMemoryPersistentMemoryConfiguration -Organization $org

#Get the MemoryPersistentMemoryConfiguration based on query Parameter
$MemoryPersistentMemoryConfigurationByQueryParam = Get-IntersightMemoryPersistentMemoryConfiguration -Filter Name eq MemoryPersistentMemoryConfigurationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .