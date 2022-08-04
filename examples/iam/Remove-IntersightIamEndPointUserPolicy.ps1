
#Get the IamEndPointUserPolicy to delete
$IamEndPointUserPolicy = Get-IntersightIamEndPointUserPolicy -Name IamEndPointUserPolicyName
$IamEndPointUserPolicy | Remove-IntersightIamEndPointUserPolicy

#Remove the server profile by Moid.
Remove-IntersightIamEndPointUserPolicy -Moid '<Replace with Moid>'
