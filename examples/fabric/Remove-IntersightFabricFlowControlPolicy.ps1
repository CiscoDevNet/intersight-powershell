
#Get the FabricFlowControlPolicy to delete
$FabricFlowControlPolicy = Get-IntersightFabricFlowControlPolicy -Name FabricFlowControlPolicyName
$FabricFlowControlPolicy | Remove-IntersightFabricFlowControlPolicy

#Remove the FabricFlowControlPolicy by Moid.
Remove-IntersightFabricFlowControlPolicy -Moid '<Replace with Moid>'
