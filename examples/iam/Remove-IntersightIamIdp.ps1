
#Get the IamIdp to delete
$IamIdp = Get-IntersightIamIdp -Name IamIdpName
$IamIdp | Remove-IntersightIamIdp

#Remove the server profile by Moid.
Remove-IntersightIamIdp -Moid '<Replace with Moid>'
