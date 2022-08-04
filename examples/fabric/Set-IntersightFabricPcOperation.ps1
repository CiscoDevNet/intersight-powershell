
#Get the FabricPcOperation to Update
$FabricPcOperation = Get-IntersightFabricPcOperation -Name FabricPcOperationName
$FabricPcOperation | Set-IntersightFabricPcOperation -Description 'Updated description'
