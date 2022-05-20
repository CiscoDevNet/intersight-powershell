#Get the TamAdvisoryInstance to delete
$TamAdvisoryInstance = Get-IntersightTamAdvisoryInstance -Name TamAdvisoryInstanceName
$TamAdvisoryInstance | Remove-IntersightTamAdvisoryInstance

#Remove the TamAdvisoryInstance by Moid.
Remove-IntersightTamAdvisoryInstance -Moid '<Replace with Moid>'
