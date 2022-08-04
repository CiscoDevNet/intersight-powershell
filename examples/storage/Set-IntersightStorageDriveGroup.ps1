# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the StorageDriveGroup to Update
$StorageDriveGroup = Get-IntersightStorageDriveGroup -Name StorageDriveGroupName

# Update the StorageDriveGroup
$storage_group1 = $StorageDriveGroup | Set-IntersightStorageDriveGroup -Description 'update demo storage drive group' 