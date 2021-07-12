
#Get the FabricLinkControlPolicy to delete
$FabricLinkControlPolicy = Remove-IntersightFabricLinkControlPolicy -Name FabricLinkControlPolicyName
$FabricLinkControlPolicy | Remove-IntersightFabricLinkControlPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricLinkControlPolicy -Moid 123bc2222287wee
