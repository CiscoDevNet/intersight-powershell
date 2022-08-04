
#Get the FabricUplinkRole to delete
$FabricUplinkRole = Get-IntersightFabricUplinkRole -Name FabricUplinkRoleName
$FabricUplinkRole | Remove-IntersightFabricUplinkRole

#Remove the FabricUplinkRole by Moid.
Remove-IntersightFabricUplinkRole -Moid '<Replace with Moid>'
