
#Get the FabricFcoeUplinkPcRole to delete
$FabricFcoeUplinkPcRole = Get-IntersightFabricFcoeUplinkPcRole -Name FabricFcoeUplinkPcRoleName
$FabricFcoeUplinkPcRole | Remove-IntersightFabricFcoeUplinkPcRole

#Remove the FabricFcoeUplinkPcRole by Moid.
Remove-IntersightFabricFcoeUplinkPcRole -Moid '<Replace with Moid>'
