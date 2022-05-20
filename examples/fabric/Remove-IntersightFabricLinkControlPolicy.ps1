
#Get the FabricLinkControlPolicy to delete
$FabricLinkControlPolicy = Get-IntersightFabricLinkControlPolicy -Name FabricLinkControlPolicyName
$FabricLinkControlPolicy | Remove-IntersightFabricLinkControlPolicy

#Remove the FabricLinkControlPolicy by Moid.
Remove-IntersightFabricLinkControlPolicy -Moid '<Replace with Moid>'
