#Get the VirtualizationVirtualMachine by Name
$VirtualizationVirtualMachineByName = Get-IntersightVirtualizationVirtualMachine -Name VirtualizationVirtualMachineName

#Get the List of VirtualizationVirtualMachine
$VirtualizationVirtualMachineList = Get-IntersightVirtualizationVirtualMachine

#Get the list of VirtualizationVirtualMachine under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationVirtualMachineByOrg = Get-IntersightVirtualizationVirtualMachine -Organization $org

#Get the VirtualizationVirtualMachine based on query Parameter
$VirtualizationVirtualMachineByQueryParam = Get-IntersightVirtualizationVirtualMachine -Filter Name eq VirtualizationVirtualMachineName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .