
#Get the HyperflexVmRestoreOperation to delete
$HyperflexVmRestoreOperation = Get-IntersightHyperflexVmRestoreOperation -Name HyperflexVmRestoreOperationName
$HyperflexVmRestoreOperation | Remove-IntersightHyperflexVmRestoreOperation

#Remove the HyperflexVmRestoreOperation by Moid.
Remove-IntersightHyperflexVmRestoreOperation -Moid '<Replace with Moid>'
