
#Get the IamUser to Update
$IamUser = Get-IntersightIamUser -Name IamUserName
$IamUser | Set-IntersightIamUser -Description 'Updated description'