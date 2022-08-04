
#Get the IamSession to Update
$IamSession = Get-IntersightIamSession -Name IamSessionName
$IamSession | Set-IntersightIamSession -Description 'Updated description'