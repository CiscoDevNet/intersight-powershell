#Get the MemoryPersistentMemoryRegion by Name
$MemoryPersistentMemoryRegionByName = Get-IntersightMemoryPersistentMemoryRegion -Name MemoryPersistentMemoryRegionName

#Get the List of ServerProfiles
$MemoryPersistentMemoryRegionList = Get-IntersightMemoryPersistentMemoryRegion

#Get the list of MemoryPersistentMemoryRegion under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$MemoryPersistentMemoryRegionByOrg = Get-IntersightMemoryPersistentMemoryRegion -Organization $org

#Get the MemoryPersistentMemoryRegion based on query Parameter
$MemoryPersistentMemoryRegionByQueryParam = Get-IntersightMemoryPersistentMemoryRegion -Filter Name eq MemoryPersistentMemoryRegionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .