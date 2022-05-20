# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the VirtualizationVirtualMachine to Update
$VirtualizationVirtualMachine = Get-IntersightVirtualizationVirtualMachine -Name VirtualizationVirtualMachineName

# Update the VirtualizationVirtualMachine
$virtual_machine1 = $VirtualizationVirtualMachine | Set-IntersightVirtualizationVirtualMachine -PowerState 'PowerOff'