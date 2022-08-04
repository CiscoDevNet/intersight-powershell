
#Get the HyperflexVmImportOperation to Update
$HyperflexVmImportOperation = Get-IntersightHyperflexVmImportOperation -Name HyperflexVmImportOperationName
$HyperflexVmImportOperation | Set-IntersightHyperflexVmImportOperation -Description 'Updated description'
