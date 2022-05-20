# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the VirtualizationVirtualDisk to Update
$VirtualizationVirtualDisk = Get-IntersightVirtualizationVirtualDisk -Name VirtualizationVirtualDiskName

# Update the VirtualizationVirtualDisk
$virtualdisk1 = $VirtualizationVirtualDisk | Set-IntersightVirtualizationVirtualDisk -Capacity 15

