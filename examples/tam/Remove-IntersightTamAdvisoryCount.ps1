
#Get the TamAdvisoryCount to delete
$TamAdvisoryCount = Remove-IntersightTamAdvisoryCount -Name TamAdvisoryCountName
$TamAdvisoryCount | Remove-IntersightTamAdvisoryCount

#Remove the server profile by Moid.
Remove-IntersightTamAdvisoryCount -Moid 123bc2222287wee
