
#Get the VirtualizationVirtualDisk to delete
$VirtualizationVirtualDisk = Remove-IntersightVirtualizationVirtualDisk -Name VirtualizationVirtualDiskName
$VirtualizationVirtualDisk | Remove-IntersightVirtualizationVirtualDisk

#Remove the server profile by Moid.
Remove-IntersightVirtualizationVirtualDisk -Moid 123bc2222287wee
