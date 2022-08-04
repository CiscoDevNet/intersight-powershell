#Get the VirtualizationVirtualMachine to delete
$VirtualizationVirtualMachine = Get-IntersightVirtualizationVirtualMachine -Name VirtualizationVirtualMachineName
$VirtualizationVirtualMachine | Remove-IntersightVirtualizationVirtualMachine

#Remove the VirtualizationVirtualMachine by Moid.
Remove-IntersightVirtualizationVirtualMachine -Moid '<Replace with Moid>'
