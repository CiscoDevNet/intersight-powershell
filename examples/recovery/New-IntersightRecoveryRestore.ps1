$device1 = Get-IntersightAssetDeviceregistration -Moid '<Replace with Moid>'

$workflow1 = Get-IntersightWorkflowWorkflowinfoRelationship -Moid '<Replace with Moid>'

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$recovery_restore1 = New-IntersightRecoveryRestore -Device $device1 -Workflow $workflow1 -Organization $organization1