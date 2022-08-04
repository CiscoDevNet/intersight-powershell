
#Get the FabricEthNetworkGroupPolicy to Update
$FabricEthNetworkGroupPolicy = Get-IntersightFabricEthNetworkGroupPolicy -Name FabricEthNetworkGroupPolicyName
$FabricEthNetworkGroupPolicy | Set-IntersightFabricEthNetworkGroupPolicy -Description 'Updated description'
