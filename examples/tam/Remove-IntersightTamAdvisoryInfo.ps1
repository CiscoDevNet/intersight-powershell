
#Get the TamAdvisoryInfo to delete
$TamAdvisoryInfo = Remove-IntersightTamAdvisoryInfo -Name TamAdvisoryInfoName
$TamAdvisoryInfo | Remove-IntersightTamAdvisoryInfo

#Remove the server profile by Moid.
Remove-IntersightTamAdvisoryInfo -Moid '<Replace with Moid>'
