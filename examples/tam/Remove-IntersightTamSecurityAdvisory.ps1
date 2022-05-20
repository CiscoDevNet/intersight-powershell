#Get the TamSecurityAdvisory to delete
$TamSecurityAdvisory = Get-IntersightTamSecurityAdvisory -Name TamSecurityAdvisoryName
$TamSecurityAdvisory | Remove-IntersightTamSecurityAdvisory

#Remove the TamSecurityAdvisory by Moid.
Remove-IntersightTamSecurityAdvisory -Moid '<Replace with Moid>'
