
#Get the VirtualizationVirtualMachine to delete
$VirtualizationVirtualMachine = Remove-IntersightVirtualizationVirtualMachine -Name VirtualizationVirtualMachineName
$VirtualizationVirtualMachine | Remove-IntersightVirtualizationVirtualMachine

#Remove the server profile by Moid.
Remove-IntersightVirtualizationVirtualMachine -Moid 123bc2222287wee
