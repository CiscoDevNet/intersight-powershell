#Get the VirtualizationVirtualDisk to delete
$VirtualizationVirtualDisk = Get-IntersightVirtualizationVirtualDisk -Name VirtualizationVirtualDiskName
$VirtualizationVirtualDisk | Remove-IntersightVirtualizationVirtualDisk

#Remove the VirtualizationVirtualDisk by Moid.
Remove-IntersightVirtualizationVirtualDisk -Moid '<Replace with Moid>'
