
#Get the IamEndPointUser to delete
$IamEndPointUser = Remove-IntersightIamEndPointUser -Name IamEndPointUserName
$IamEndPointUser | Remove-IntersightIamEndPointUser

#Remove the server profile by Moid.
Remove-IntersightIamEndPointUser -Moid 123bc2222287wee
