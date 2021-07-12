#Get the VirtualizationVmwareHost by Name
$VirtualizationVmwareHostByName = Get-IntersightVirtualizationVmwareHost -Name VirtualizationVmwareHostName

#Get the List of ServerProfiles
$VirtualizationVmwareHostList = Get-IntersightVirtualizationVmwareHost

#Get the list of VirtualizationVmwareHost under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VirtualizationVmwareHostByOrg = Get-IntersightVirtualizationVmwareHost -Organization $org

#Get the VirtualizationVmwareHost based on query Parameter
$VirtualizationVmwareHostByQueryParam = Get-IntersightVirtualizationVmwareHost -Filter Name eq VirtualizationVmwareHostName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .