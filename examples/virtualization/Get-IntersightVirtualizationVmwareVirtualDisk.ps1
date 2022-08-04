#Get the VirtualizationVmwareVirtualDisk by Name
$VirtualizationVmwareVirtualDiskByName = Get-IntersightVirtualizationVmwareVirtualDisk -Name VirtualizationVmwareVirtualDiskName

#Get the List of ServerProfiles
$VirtualizationVmwareVirtualDiskList = Get-IntersightVirtualizationVmwareVirtualDisk

#Get the list of VirtualizationVmwareVirtualDisk under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$VirtualizationVmwareVirtualDiskByOrg = Get-IntersightVirtualizationVmwareVirtualDisk -Organization $org

#Get the VirtualizationVmwareVirtualDisk based on query Parameter
$VirtualizationVmwareVirtualDiskByQueryParam = Get-IntersightVirtualizationVmwareVirtualDisk -Filter Name eq VirtualizationVmwareVirtualDiskName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .