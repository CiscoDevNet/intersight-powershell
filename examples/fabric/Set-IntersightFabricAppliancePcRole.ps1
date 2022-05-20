
#Get the FabricAppliancePcRole to Update
$FabricAppliancePcRole = Get-IntersightFabricAppliancePcRole -Name FabricAppliancePcRoleName
$FabricAppliancePcRole | Set-IntersightFabricAppliancePcRole -Description 'Updated description'
