
#Get the IamAccount to Update
$IamAccount = Get-IntersightIamAccount -Name IamAccountName
$IamAccount | Set-IntersightIamAccount -Description 'Updated description'