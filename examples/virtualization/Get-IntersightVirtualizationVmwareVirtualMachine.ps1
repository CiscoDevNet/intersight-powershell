#Get the VirtualizationVmwareVirtualMachine by Name
$VirtualizationVmwareVirtualMachineByName = Get-IntersightVirtualizationVmwareVirtualMachine -Name VirtualizationVmwareVirtualMachineName

#Get the List of ServerProfiles
$VirtualizationVmwareVirtualMachineList = Get-IntersightVirtualizationVmwareVirtualMachine

#Get the list of VirtualizationVmwareVirtualMachine under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationVmwareVirtualMachineByOrg = Get-IntersightVirtualizationVmwareVirtualMachine -Organization $org

#Get the VirtualizationVmwareVirtualMachine based on query Parameter
$VirtualizationVmwareVirtualMachineByQueryParam = Get-IntersightVirtualizationVmwareVirtualMachine -Filter Name eq VirtualizationVmwareVirtualMachineName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .