#Get the HyperflexHxapVirtualMachineNetworkInterface by Name
$HyperflexHxapVirtualMachineNetworkInterfaceByName = Get-IntersightHyperflexHxapVirtualMachineNetworkInterface -Name HyperflexHxapVirtualMachineNetworkInterfaceName

#Get the List of ServerProfiles
$HyperflexHxapVirtualMachineNetworkInterfaceList = Get-IntersightHyperflexHxapVirtualMachineNetworkInterface

#Get the list of HyperflexHxapVirtualMachineNetworkInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHxapVirtualMachineNetworkInterfaceByOrg = Get-IntersightHyperflexHxapVirtualMachineNetworkInterface -Organization $org

#Get the HyperflexHxapVirtualMachineNetworkInterface based on query Parameter
$HyperflexHxapVirtualMachineNetworkInterfaceByQueryParam = Get-IntersightHyperflexHxapVirtualMachineNetworkInterface -Filter Name eq HyperflexHxapVirtualMachineNetworkInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .