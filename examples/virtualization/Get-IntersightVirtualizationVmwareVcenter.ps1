#Get the VirtualizationVmwareVcenter by Name
$VirtualizationVmwareVcenterByName = Get-IntersightVirtualizationVmwareVcenter -Name VirtualizationVmwareVcenterName

#Get the List of ServerProfiles
$VirtualizationVmwareVcenterList = Get-IntersightVirtualizationVmwareVcenter

#Get the list of VirtualizationVmwareVcenter under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationVmwareVcenterByOrg = Get-IntersightVirtualizationVmwareVcenter -Organization $org

#Get the VirtualizationVmwareVcenter based on query Parameter
$VirtualizationVmwareVcenterByQueryParam = Get-IntersightVirtualizationVmwareVcenter -Filter Name eq VirtualizationVmwareVcenterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .