
#Get the FabricPortOperation to Update
$FabricPortOperation = Get-IntersightFabricPortOperation -Name FabricPortOperationName
$FabricPortOperation | Set-IntersightFabricPortOperation  -Description 'Updated description'
