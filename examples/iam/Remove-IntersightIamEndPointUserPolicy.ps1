
#Get the IamEndPointUserPolicy to delete
$IamEndPointUserPolicy = Remove-IntersightIamEndPointUserPolicy -Name IamEndPointUserPolicyName
$IamEndPointUserPolicy | Remove-IntersightIamEndPointUserPolicy

#Remove the server profile by Moid.
Remove-IntersightIamEndPointUserPolicy -Moid 123bc2222287wee
