
#Get the FabricEthNetworkGroupPolicy to delete
$FabricEthNetworkGroupPolicy = Remove-IntersightFabricEthNetworkGroupPolicy -Name FabricEthNetworkGroupPolicyName
$FabricEthNetworkGroupPolicy | Remove-IntersightFabricEthNetworkGroupPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricEthNetworkGroupPolicy -Moid 123bc2222287wee
