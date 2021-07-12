#Get the MemoryPersistentMemoryPolicy by Name
$MemoryPersistentMemoryPolicyByName = Get-IntersightMemoryPersistentMemoryPolicy -Name MemoryPersistentMemoryPolicyName

#Get the List of ServerProfiles
$MemoryPersistentMemoryPolicyList = Get-IntersightMemoryPersistentMemoryPolicy

#Get the list of MemoryPersistentMemoryPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$MemoryPersistentMemoryPolicyByOrg = Get-IntersightMemoryPersistentMemoryPolicy -Organization $org

#Get the MemoryPersistentMemoryPolicy based on query Parameter
$MemoryPersistentMemoryPolicyByQueryParam = Get-IntersightMemoryPersistentMemoryPolicy -Filter Name eq MemoryPersistentMemoryPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .