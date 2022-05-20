#Get the VirtualizationVirtualDisk by Name
$VirtualizationVirtualDiskByName = Get-IntersightVirtualizationVirtualDisk -Name VirtualizationVirtualDiskName

#Get the List of VirtualizationVirtualDisk
$VirtualizationVirtualDiskList = Get-IntersightVirtualizationVirtualDisk

#Get the list of VirtualizationVirtualDisk under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$VirtualizationVirtualDiskByOrg = Get-IntersightVirtualizationVirtualDisk -Organization $org

#Get the VirtualizationVirtualDisk based on query Parameter
$VirtualizationVirtualDiskByQueryParam = Get-IntersightVirtualizationVirtualDisk -Filter Name eq VirtualizationVirtualDiskName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .