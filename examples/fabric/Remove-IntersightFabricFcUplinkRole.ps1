
#Get the FabricFcUplinkRole to delete
$FabricFcUplinkRole = Get-IntersightFabricFcUplinkRole -Name FabricFcUplinkRoleName
$FabricFcUplinkRole | Remove-IntersightFabricFcUplinkRole

#Remove the FabricFcUplinkRole by Moid.
Remove-IntersightFabricFcUplinkRole -Moid '<Replace with Moid>'
