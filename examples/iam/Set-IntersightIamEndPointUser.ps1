
#Get the IamEndPointUser to Update
$IamEndPointUser = Get-IntersightIamEndPointUser -Name IamEndPointUserName
$IamEndPointUser | Set-IntersightIamEndPointUser -Description 'Updated description'