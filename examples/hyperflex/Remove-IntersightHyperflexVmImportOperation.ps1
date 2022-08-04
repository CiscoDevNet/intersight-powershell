
#Get the HyperflexVmImportOperation to delete
$HyperflexVmImportOperation = Get-IntersightHyperflexVmImportOperation -Name HyperflexVmImportOperationName
$HyperflexVmImportOperation | Remove-IntersightHyperflexVmImportOperation

#Remove the HyperflexVmImportOperation by Moid.
Remove-IntersightHyperflexVmImportOperation -Moid '<Replace with Moid>'
