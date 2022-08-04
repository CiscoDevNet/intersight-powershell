
#Get the HyperflexVmRestoreOperation to Update
$HyperflexVmRestoreOperation = Get-IntersightHyperflexVmRestoreOperation -Name HyperflexVmRestoreOperationName
$HyperflexVmRestoreOperation | Set-IntersightHyperflexVmRestoreOperation -Description 'Updated description'
