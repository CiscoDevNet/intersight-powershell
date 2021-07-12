
#Get the FabricVlan to delete
$FabricVlan = Remove-IntersightFabricVlan -Name FabricVlanName
$FabricVlan | Remove-IntersightFabricVlan

#Remove the server profile by Moid.
Remove-IntersightFabricVlan -Moid 123bc2222287wee
