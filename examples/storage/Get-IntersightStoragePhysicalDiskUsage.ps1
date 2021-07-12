#Get the StoragePhysicalDiskUsage by Name
$StoragePhysicalDiskUsageByName = Get-IntersightStoragePhysicalDiskUsage -Name StoragePhysicalDiskUsageName

#Get the List of ServerProfiles
$StoragePhysicalDiskUsageList = Get-IntersightStoragePhysicalDiskUsage

#Get the list of StoragePhysicalDiskUsage under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StoragePhysicalDiskUsageByOrg = Get-IntersightStoragePhysicalDiskUsage -Organization $org

#Get the StoragePhysicalDiskUsage based on query Parameter
$StoragePhysicalDiskUsageByQueryParam = Get-IntersightStoragePhysicalDiskUsage -Filter Name eq StoragePhysicalDiskUsageName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .