
#Get the FabricFlowControlPolicy to delete
$FabricFlowControlPolicy = Remove-IntersightFabricFlowControlPolicy -Name FabricFlowControlPolicyName
$FabricFlowControlPolicy | Remove-IntersightFabricFlowControlPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricFlowControlPolicy -Moid 123bc2222287wee
