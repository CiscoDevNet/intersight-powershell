
#Get the FabricPortMode to delete
$FabricPortMode = Get-IntersightFabricPortMode -Name FabricPortModeName
$FabricPortMode | Remove-IntersightFabricPortMode

#Remove the FabricPortMode by Moid.
Remove-IntersightFabricPortMode -Moid '<Replace with Moid>'
