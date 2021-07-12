#Get the VirtualizationVmwareDatacenter by Name
$VirtualizationVmwareDatacenterByName = Get-IntersightVirtualizationVmwareDatacenter -Name VirtualizationVmwareDatacenterName

#Get the List of ServerProfiles
$VirtualizationVmwareDatacenterList = Get-IntersightVirtualizationVmwareDatacenter

#Get the list of VirtualizationVmwareDatacenter under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VirtualizationVmwareDatacenterByOrg = Get-IntersightVirtualizationVmwareDatacenter -Organization $org

#Get the VirtualizationVmwareDatacenter based on query Parameter
$VirtualizationVmwareDatacenterByQueryParam = Get-IntersightVirtualizationVmwareDatacenter -Filter Name eq VirtualizationVmwareDatacenterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .