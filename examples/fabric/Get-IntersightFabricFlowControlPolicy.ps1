#Get the FabricFlowControlPolicy by Name
$FabricFlowControlPolicyByName = Get-IntersightFabricFlowControlPolicy -Name FabricFlowControlPolicyName

#Get the List of ServerProfiles
$FabricFlowControlPolicyList = Get-IntersightFabricFlowControlPolicy

#Get the list of FabricFlowControlPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricFlowControlPolicyByOrg = Get-IntersightFabricFlowControlPolicy -Organization $org

#Get the FabricFlowControlPolicy based on query Parameter
$FabricFlowControlPolicyByQueryParam = Get-IntersightFabricFlowControlPolicy -Filter Name eq FabricFlowControlPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .