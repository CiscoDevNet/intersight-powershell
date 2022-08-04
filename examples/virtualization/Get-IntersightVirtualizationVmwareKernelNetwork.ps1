#Get the VirtualizationVmwareKernelNetwork by Name
$VirtualizationVmwareKernelNetworkByName = Get-IntersightVirtualizationVmwareKernelNetwork -Name VirtualizationVmwareKernelNetworkName

#Get the List of ServerProfiles
$VirtualizationVmwareKernelNetworkList = Get-IntersightVirtualizationVmwareKernelNetwork

#Get the list of VirtualizationVmwareKernelNetwork under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationVmwareKernelNetworkByOrg = Get-IntersightVirtualizationVmwareKernelNetwork -Organization $org

#Get the VirtualizationVmwareKernelNetwork based on query Parameter
$VirtualizationVmwareKernelNetworkByQueryParam = Get-IntersightVirtualizationVmwareKernelNetwork -Filter Name eq VirtualizationVmwareKernelNetworkName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .