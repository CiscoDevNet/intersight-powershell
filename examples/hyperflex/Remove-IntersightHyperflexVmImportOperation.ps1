
#Get the HyperflexVmImportOperation to delete
$HyperflexVmImportOperation = Remove-IntersightHyperflexVmImportOperation -Name HyperflexVmImportOperationName
$HyperflexVmImportOperation | Remove-IntersightHyperflexVmImportOperation

#Remove the server profile by Moid.
Remove-IntersightHyperflexVmImportOperation -Moid 123bc2222287wee
