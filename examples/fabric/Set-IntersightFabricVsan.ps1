
#Get the FabricVsan to Update
$FabricVsan = Get-IntersightFabricVsan -Name FabricVsanName
$FabricVsan | Set-IntersightFabricVsan -Description 'Updated description'
