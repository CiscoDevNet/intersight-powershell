
#Get the FabricUplinkPcRole to delete
$FabricUplinkPcRole = Get-IntersightFabricUplinkPcRole -Name FabricUplinkPcRoleName
$FabricUplinkPcRole | Remove-IntersightFabricUplinkPcRole

#Remove the FabricUplinkPcRole by Moid.
Remove-IntersightFabricUplinkPcRole -Moid '<Replace with Moid>'
