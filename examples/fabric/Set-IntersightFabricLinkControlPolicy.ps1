
#Get the FabricLinkControlPolicy to Update
$FabricLinkControlPolicy = Get-IntersightFabricLinkControlPolicy -Name FabricLinkControlPolicyName
$FabricLinkControlPolicy | Set-IntersightFabricLinkControlPolicy  -Description 'Updated description'
