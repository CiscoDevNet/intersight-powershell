
#Get the TamAdvisoryInstance to delete
$TamAdvisoryInstance = Remove-IntersightTamAdvisoryInstance -Name TamAdvisoryInstanceName
$TamAdvisoryInstance | Remove-IntersightTamAdvisoryInstance

#Remove the server profile by Moid.
Remove-IntersightTamAdvisoryInstance -Moid 123bc2222287wee
