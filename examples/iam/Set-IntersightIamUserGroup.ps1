
#Get the IamUserGroup to Update
$IamUserGroup = Get-IntersightIamUserGroup -Name IamUserGroupName
$IamUserGroup | Set-IntersightIamUserGroup -Description 'Updated description'