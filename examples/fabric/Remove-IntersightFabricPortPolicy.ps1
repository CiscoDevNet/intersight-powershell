
#Get the FabricPortPolicy to delete
$FabricPortPolicy = Get-IntersightFabricPortPolicy -Name FabricPortPolicyName
$FabricPortPolicy | Remove-IntersightFabricPortPolicy

#Remove the FabricPortPolicy by Moid.
Remove-IntersightFabricPortPolicy -Moid '<Replace with Moid>'
