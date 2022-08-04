
#Get the CapabilitySiocModuleDescriptor to delete
$CapabilitySiocModuleDescriptor = Get-IntersightCapabilitySiocModuleDescriptor -Name CapabilitySiocModuleDescriptorName
$CapabilitySiocModuleDescriptor | Remove-IntersightCapabilitySiocModuleDescriptor

#Remove the CapabilitySiocModuleDescriptor by Moid.
Remove-IntersightCapabilitySiocModuleDescriptor -Moid '<Replace with Moid>'
