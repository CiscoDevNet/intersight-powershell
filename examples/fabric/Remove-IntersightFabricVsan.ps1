
#Get the FabricVsan to delete
$FabricVsan = Get-IntersightFabricVsan -Name FabricVsanName
$FabricVsan | Remove-IntersightFabricVsan

#Remove the FabricVsan by Moid.
Remove-IntersightFabricVsan -Moid '<Replace with Moid>'
