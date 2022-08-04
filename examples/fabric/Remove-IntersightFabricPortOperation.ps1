
#Get the FabricPortOperation to delete
$FabricPortOperation = Get-IntersightFabricPortOperation -Name FabricPortOperationName
$FabricPortOperation | Remove-IntersightFabricPortOperation

#Remove the FabricPortOperation by Moid.
Remove-IntersightFabricPortOperation -Moid '<Replace with Moid>'
