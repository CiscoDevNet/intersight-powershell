
#Get the IamEndPointUserRole to delete
$IamEndPointUserRole = Remove-IntersightIamEndPointUserRole -Name IamEndPointUserRoleName
$IamEndPointUserRole | Remove-IntersightIamEndPointUserRole

#Remove the server profile by Moid.
Remove-IntersightIamEndPointUserRole -Moid 123bc2222287wee
