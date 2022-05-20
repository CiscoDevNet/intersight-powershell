
#Get the IamEndPointUserRole to delete
$IamEndPointUserRole = Get-IntersightIamEndPointUserRole -Name IamEndPointUserRoleName
$IamEndPointUserRole | Remove-IntersightIamEndPointUserRole

#Remove the server profile by Moid.
Remove-IntersightIamEndPointUserRole -Moid '<Replace with Moid>'
