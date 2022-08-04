
#Get the FabricVlan to Update
$FabricVlan = Get-IntersightFabricVlan -Name FabricVlanName
$FabricVlan | Set-IntersightFabricVlan -Description 'Updated description'
