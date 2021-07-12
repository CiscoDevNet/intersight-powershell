
#Get the FabricApplianceRole to delete
$FabricApplianceRole = Remove-IntersightFabricApplianceRole -Name FabricApplianceRoleName
$FabricApplianceRole | Remove-IntersightFabricApplianceRole

#Remove the server profile by Moid.
Remove-IntersightFabricApplianceRole -Moid 123bc2222287wee
