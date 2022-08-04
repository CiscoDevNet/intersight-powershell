
#Get the FabricPcOperation to delete
$FabricPcOperation = Get-IntersightFabricPcOperation -Name FabricPcOperationName
$FabricPcOperation | Remove-IntersightFabricPcOperation

#Remove the FabricPcOperation by Moid.
Remove-IntersightFabricPcOperation -Moid '<Replace with Moid>'
