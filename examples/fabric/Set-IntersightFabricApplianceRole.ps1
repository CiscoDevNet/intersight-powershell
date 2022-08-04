
#Get the FabricApplianceRole to Update
$FabricApplianceRole = Get-IntersightFabricApplianceRole -Name FabricApplianceRoleName
$FabricApplianceRole | Set-IntersightFabricApplianceRole -Description 'Updated description'
