
#Get the FabricPcOperation to delete
$FabricPcOperation = Remove-IntersightFabricPcOperation -Name FabricPcOperationName
$FabricPcOperation | Remove-IntersightFabricPcOperation

#Remove the server profile by Moid.
Remove-IntersightFabricPcOperation -Moid 123bc2222287wee
