
#Get the FabricFcoeUplinkRole to delete
$FabricFcoeUplinkRole = Get-IntersightFabricFcoeUplinkRole -Name FabricFcoeUplinkRoleName
$FabricFcoeUplinkRole | Remove-IntersightFabricFcoeUplinkRole

#Remove the FabricFcoeUplinkRole by Moid.
Remove-IntersightFabricFcoeUplinkRole -Moid '<Replace with Moid>'
