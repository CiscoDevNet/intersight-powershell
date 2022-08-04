
#Get the FabricFcUplinkPcRole to delete
$FabricFcUplinkPcRole = Get-IntersightFabricFcUplinkPcRole -Name FabricFcUplinkPcRoleName
$FabricFcUplinkPcRole | Remove-IntersightFabricFcUplinkPcRole

#Remove the FabricFcUplinkPcRole by Moid.
Remove-IntersightFabricFcUplinkPcRole -Moid '<Replace with Moid>'
