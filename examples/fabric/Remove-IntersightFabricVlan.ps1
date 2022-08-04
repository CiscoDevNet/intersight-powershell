
#Get the FabricVlan to delete
$FabricVlan = Get-IntersightFabricVlan -Name FabricVlanName
$FabricVlan | Remove-IntersightFabricVlan

#Remove the FabricVlan by Moid.
Remove-IntersightFabricVlan -Moid '<Replace with Moid>'
