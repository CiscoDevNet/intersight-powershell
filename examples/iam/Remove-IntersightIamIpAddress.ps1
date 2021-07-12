
#Get the IamIpAddress to delete
$IamIpAddress = Remove-IntersightIamIpAddress -Name IamIpAddressName
$IamIpAddress | Remove-IntersightIamIpAddress

#Remove the server profile by Moid.
Remove-IntersightIamIpAddress -Moid 123bc2222287wee
