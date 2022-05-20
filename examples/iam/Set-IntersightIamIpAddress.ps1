
#Get the IamIpAddress to Update
$IamIpAddress = Get-IntersightIamIpAddress -Name IamIpAddressName
$IamIpAddress | Set-IntersightIamIpAddress -Description 'Updated description'