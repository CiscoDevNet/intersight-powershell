
#Get the FabricAppliancePcRole to delete
$FabricAppliancePcRole = Get-IntersightFabricAppliancePcRole -Name FabricAppliancePcRoleName
$FabricAppliancePcRole | Remove-IntersightFabricAppliancePcRole

#Remove the FabricAppliancePcRole by Moid.
Remove-IntersightFabricAppliancePcRole -Moid '<Replace with Moid>'

