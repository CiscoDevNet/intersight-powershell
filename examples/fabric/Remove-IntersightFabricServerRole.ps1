
#Get the FabricServerRole to delete
$FabricServerRole = Get-IntersightFabricServerRole -Name FabricServerRoleName
$FabricServerRole | Remove-IntersightFabricServerRole

#Remove the FabricServerRole by Moid.
Remove-IntersightFabricServerRole -Moid '<Replace with Moid>'
