
#Get the IamAccount to delete
$IamAccount = Remove-IntersightIamAccount -Name IamAccountName
$IamAccount | Remove-IntersightIamAccount

#Remove the server profile by Moid.
Remove-IntersightIamAccount -Moid 123bc2222287wee
