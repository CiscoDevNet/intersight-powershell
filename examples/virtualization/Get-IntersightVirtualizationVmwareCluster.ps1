#Get the VirtualizationVmwareCluster by Name
$VirtualizationVmwareClusterByName = Get-IntersightVirtualizationVmwareCluster -Name VirtualizationVmwareClusterName

#Get the List of ServerProfiles
$VirtualizationVmwareClusterList = Get-IntersightVirtualizationVmwareCluster

#Get the list of VirtualizationVmwareCluster under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VirtualizationVmwareClusterByOrg = Get-IntersightVirtualizationVmwareCluster -Organization $org

#Get the VirtualizationVmwareCluster based on query Parameter
$VirtualizationVmwareClusterByQueryParam = Get-IntersightVirtualizationVmwareCluster -Filter Name eq VirtualizationVmwareClusterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .