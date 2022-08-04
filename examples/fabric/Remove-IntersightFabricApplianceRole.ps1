
#Get the FabricApplianceRole to delete
$FabricApplianceRole = Get-IntersightFabricApplianceRole -Name FabricApplianceRoleName
$FabricApplianceRole | Remove-IntersightFabricApplianceRole

#Remove the FabricApplianceRole by Moid.
Remove-IntersightFabricApplianceRole -Moid '<Replace with Moid>'
