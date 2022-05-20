
#Get the IamSession to delete
$IamSession = Get-IntersightIamSession -Name IamSessionName
$IamSession | Remove-IntersightIamSession

#Remove the server profile by Moid.
Remove-IntersightIamSession -Moid '<Replace with Moid>'
