
#Get the FabricPortPolicy to delete
$FabricPortPolicy = Remove-IntersightFabricPortPolicy -Name FabricPortPolicyName
$FabricPortPolicy | Remove-IntersightFabricPortPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricPortPolicy -Moid 123bc2222287wee
