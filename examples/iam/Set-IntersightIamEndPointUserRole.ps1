
#Get the IamEndPointUserRole to Update
$IamEndPointUserRole = Get-IntersightIamEndPointUserRole -Name IamEndPointUserRoleName
$IamEndPointUserRole | Set-IntersightIamEndPointUserRole -Description 'Updated description'