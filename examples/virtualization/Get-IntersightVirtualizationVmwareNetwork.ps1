#Get the VirtualizationVmwareNetwork by Name
$VirtualizationVmwareNetworkByName = Get-IntersightVirtualizationVmwareNetwork -Name VirtualizationVmwareNetworkName

#Get the List of ServerProfiles
$VirtualizationVmwareNetworkList = Get-IntersightVirtualizationVmwareNetwork

#Get the list of VirtualizationVmwareNetwork under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationVmwareNetworkByOrg = Get-IntersightVirtualizationVmwareNetwork -Organization $org

#Get the VirtualizationVmwareNetwork based on query Parameter
$VirtualizationVmwareNetworkByQueryParam = Get-IntersightVirtualizationVmwareNetwork -Filter Name eq VirtualizationVmwareNetworkName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .