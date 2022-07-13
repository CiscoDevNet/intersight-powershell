#Get the VirtualizationVmwareVirtualNetworkInterface by Name
$VirtualizationVmwareVirtualNetworkInterfaceByName = Get-IntersightVirtualizationVmwareVirtualNetworkInterface -Name VirtualizationVmwareVirtualNetworkInterfaceName

#Get the List of ServerProfiles
$VirtualizationVmwareVirtualNetworkInterfaceList = Get-IntersightVirtualizationVmwareVirtualNetworkInterface

#Get the list of VirtualizationVmwareVirtualNetworkInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationVmwareVirtualNetworkInterfaceByOrg = Get-IntersightVirtualizationVmwareVirtualNetworkInterface -Organization $org

#Get the VirtualizationVmwareVirtualNetworkInterface based on query Parameter
$VirtualizationVmwareVirtualNetworkInterfaceByQueryParam = Get-IntersightVirtualizationVmwareVirtualNetworkInterface -Filter Name eq VirtualizationVmwareVirtualNetworkInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .