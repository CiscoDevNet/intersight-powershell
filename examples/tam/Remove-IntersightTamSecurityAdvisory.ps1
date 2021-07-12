
#Get the TamSecurityAdvisory to delete
$TamSecurityAdvisory = Remove-IntersightTamSecurityAdvisory -Name TamSecurityAdvisoryName
$TamSecurityAdvisory | Remove-IntersightTamSecurityAdvisory

#Remove the server profile by Moid.
Remove-IntersightTamSecurityAdvisory -Moid 123bc2222287wee
