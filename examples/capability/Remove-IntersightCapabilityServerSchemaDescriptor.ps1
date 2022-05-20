
#Get the CapabilityServerSchemaDescriptor to delete
$CapabilityServerSchemaDescriptor = Get-IntersightCapabilityServerSchemaDescriptor -Name CapabilityServerSchemaDescriptorName
$CapabilityServerSchemaDescriptor | Remove-IntersightCapabilityServerSchemaDescriptor

#Remove the CapabilityServerSchemaDescriptor by Moid.
Remove-IntersightCapabilityServerSchemaDescriptor -Moid '<Replace with Moid>'
