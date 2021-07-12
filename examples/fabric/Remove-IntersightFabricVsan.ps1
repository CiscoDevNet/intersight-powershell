
#Get the FabricVsan to delete
$FabricVsan = Remove-IntersightFabricVsan -Name FabricVsanName
$FabricVsan | Remove-IntersightFabricVsan

#Remove the server profile by Moid.
Remove-IntersightFabricVsan -Moid 123bc2222287wee
