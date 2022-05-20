
#Get the FabricEthNetworkGroupPolicy to delete
$FabricEthNetworkGroupPolicy = Get-IntersightFabricEthNetworkGroupPolicy -Name FabricEthNetworkGroupPolicyName
$FabricEthNetworkGroupPolicy | Remove-IntersightFabricEthNetworkGroupPolicy

#Remove the FabricEthNetworkGroupPolicy by Moid.
Remove-IntersightFabricEthNetworkGroupPolicy -Moid '<Replace with Moid>'
