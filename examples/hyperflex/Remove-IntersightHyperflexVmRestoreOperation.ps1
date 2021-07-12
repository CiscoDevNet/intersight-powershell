
#Get the HyperflexVmRestoreOperation to delete
$HyperflexVmRestoreOperation = Remove-IntersightHyperflexVmRestoreOperation -Name HyperflexVmRestoreOperationName
$HyperflexVmRestoreOperation | Remove-IntersightHyperflexVmRestoreOperation

#Remove the server profile by Moid.
Remove-IntersightHyperflexVmRestoreOperation -Moid 123bc2222287wee
