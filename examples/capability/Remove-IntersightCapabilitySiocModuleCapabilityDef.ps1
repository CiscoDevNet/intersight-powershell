
#Get the CapabilitySiocModuleCapabilityDef to delete
$CapabilitySiocModuleCapabilityDef = Get-IntersightCapabilitySiocModuleCapabilityDef -Name CapabilitySiocModuleCapabilityDefName
$CapabilitySiocModuleCapabilityDef | Remove-IntersightCapabilitySiocModuleCapabilityDef

#Remove the CapabilitySiocModuleCapabilityDef by Moid.
Remove-IntersightCapabilitySiocModuleCapabilityDef -Moid '<Replace with Moid>'
