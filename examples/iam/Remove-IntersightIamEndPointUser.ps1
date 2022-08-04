
#Get the IamEndPointUser to delete
$IamEndPointUser = Get-IntersightIamEndPointUser -Name IamEndPointUserName
$IamEndPointUser | Remove-IntersightIamEndPointUser

#Remove the server profile by Moid.
Remove-IntersightIamEndPointUser -Moid '<Replace with Moid>'
