
#Get the IamEndPointUserPolicy to Update
$IamEndPointUserPolicy = Get-IntersightIamEndPointUserPolicy -Name IamEndPointUserPolicyName
$IamEndPointUserPolicy | Set-IntersightIamEndPointUserPolicy -Description 'Updated description'