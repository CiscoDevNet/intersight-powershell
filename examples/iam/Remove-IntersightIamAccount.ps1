
#Get the IamAccount to delete
$IamAccount = Get-IntersightIamAccount -Name IamAccountName
$IamAccount | Remove-IntersightIamAccount

#Remove the server profile by Moid.
Remove-IntersightIamAccount -Moid '<Replace with Moid>'
