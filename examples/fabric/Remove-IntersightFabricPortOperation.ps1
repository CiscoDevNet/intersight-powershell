
#Get the FabricPortOperation to delete
$FabricPortOperation = Remove-IntersightFabricPortOperation -Name FabricPortOperationName
$FabricPortOperation | Remove-IntersightFabricPortOperation

#Remove the server profile by Moid.
Remove-IntersightFabricPortOperation -Moid 123bc2222287wee
