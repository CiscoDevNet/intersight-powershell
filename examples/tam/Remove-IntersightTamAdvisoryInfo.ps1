
#Get the TamAdvisoryInfo to delete
$TamAdvisoryInfo = Remove-IntersightTamAdvisoryInfo -Name TamAdvisoryInfoName
$TamAdvisoryInfo | Remove-IntersightTamAdvisoryInfo

#Remove the server profile by Moid.
Remove-IntersightTamAdvisoryInfo -Moid 123bc2222287wee
