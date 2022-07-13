# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the VirtualizationVirtualMachine to Update
$VirtualizationVirtualMachine = Get-IntersightVirtualizationVirtualMachine -Name VirtualizationVirtualMachineName

# Update the VirtualizationVirtualMachine
$virtual_machine1 = $VirtualizationVirtualMachine | Set-IntersightVirtualizationVirtualMachine -PowerState 'PowerOff'