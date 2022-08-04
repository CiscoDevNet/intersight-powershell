#Get the TamAdvisoryCount to delete
$TamAdvisoryCount = Get-IntersightTamAdvisoryCount -Name TamAdvisoryCountName
$TamAdvisoryCount | Remove-IntersightTamAdvisoryCount

#Remove the TamAdvisoryCount by Moid.
Remove-IntersightTamAdvisoryCount -Moid '<Replace with Moid>'
