#Get the VirtualizationVmwarePhysicalNetworkInterface by Name
$VirtualizationVmwarePhysicalNetworkInterfaceByName = Get-IntersightVirtualizationVmwarePhysicalNetworkInterface -Name VirtualizationVmwarePhysicalNetworkInterfaceName

#Get the List of ServerProfiles
$VirtualizationVmwarePhysicalNetworkInterfaceList = Get-IntersightVirtualizationVmwarePhysicalNetworkInterface

#Get the list of VirtualizationVmwarePhysicalNetworkInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationVmwarePhysicalNetworkInterfaceByOrg = Get-IntersightVirtualizationVmwarePhysicalNetworkInterface -Organization $org

#Get the VirtualizationVmwarePhysicalNetworkInterface based on query Parameter
$VirtualizationVmwarePhysicalNetworkInterfaceByQueryParam = Get-IntersightVirtualizationVmwarePhysicalNetworkInterface -Filter Name eq VirtualizationVmwarePhysicalNetworkInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .