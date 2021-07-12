#Get the VirtualizationVmwareUplinkPort by Name
$VirtualizationVmwareUplinkPortByName = Get-IntersightVirtualizationVmwareUplinkPort -Name VirtualizationVmwareUplinkPortName

#Get the List of ServerProfiles
$VirtualizationVmwareUplinkPortList = Get-IntersightVirtualizationVmwareUplinkPort

#Get the list of VirtualizationVmwareUplinkPort under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VirtualizationVmwareUplinkPortByOrg = Get-IntersightVirtualizationVmwareUplinkPort -Organization $org

#Get the VirtualizationVmwareUplinkPort based on query Parameter
$VirtualizationVmwareUplinkPortByQueryParam = Get-IntersightVirtualizationVmwareUplinkPort -Filter Name eq VirtualizationVmwareUplinkPortName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .