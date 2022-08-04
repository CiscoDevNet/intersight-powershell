#Get the VirtualizationVmwareDistributedNetwork by Name
$VirtualizationVmwareDistributedNetworkByName = Get-IntersightVirtualizationVmwareDistributedNetwork -Name VirtualizationVmwareDistributedNetworkName

#Get the List of ServerProfiles
$VirtualizationVmwareDistributedNetworkList = Get-IntersightVirtualizationVmwareDistributedNetwork

#Get the list of VirtualizationVmwareDistributedNetwork under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationVmwareDistributedNetworkByOrg = Get-IntersightVirtualizationVmwareDistributedNetwork -Organization $org

#Get the VirtualizationVmwareDistributedNetwork based on query Parameter
$VirtualizationVmwareDistributedNetworkByQueryParam = Get-IntersightVirtualizationVmwareDistributedNetwork -Filter Name eq VirtualizationVmwareDistributedNetworkName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .