# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the StorageStoragePolicy to Update
$StorageStoragePolicy = Get-IntersightStorageStoragePolicy -Name StorageStoragePolicyName

# Update the StorageStoragePolicy
$storage_policy1 = $StorageStoragePolicy | Set-IntersightStorageStoragePolicy -Description 'update demo storage policy' 