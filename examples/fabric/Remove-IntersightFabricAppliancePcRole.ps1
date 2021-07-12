
#Get the FabricAppliancePcRole to delete
$FabricAppliancePcRole = Remove-IntersightFabricAppliancePcRole -Name FabricAppliancePcRoleName
$FabricAppliancePcRole | Remove-IntersightFabricAppliancePcRole

#Remove the server profile by Moid.
Remove-IntersightFabricAppliancePcRole -Moid 123bc2222287wee
