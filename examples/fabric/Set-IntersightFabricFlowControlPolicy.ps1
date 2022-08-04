
#Get the FabricFlowControlPolicy to Update
$FabricFlowControlPolicy = Get-IntersightFabricFlowControlPolicy -Name FabricFlowControlPolicyName
$FabricFlowControlPolicy | Set-IntersightFabricFlowControlPolicy -Description 'Updated description'
