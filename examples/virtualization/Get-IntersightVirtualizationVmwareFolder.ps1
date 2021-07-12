#Get the VirtualizationVmwareFolder by Name
$VirtualizationVmwareFolderByName = Get-IntersightVirtualizationVmwareFolder -Name VirtualizationVmwareFolderName

#Get the List of ServerProfiles
$VirtualizationVmwareFolderList = Get-IntersightVirtualizationVmwareFolder

#Get the list of VirtualizationVmwareFolder under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VirtualizationVmwareFolderByOrg = Get-IntersightVirtualizationVmwareFolder -Organization $org

#Get the VirtualizationVmwareFolder based on query Parameter
$VirtualizationVmwareFolderByQueryParam = Get-IntersightVirtualizationVmwareFolder -Filter Name eq VirtualizationVmwareFolderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .