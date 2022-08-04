
#Get the IamIpAddress to delete
$IamIpAddress = Get-IntersightIamIpAddress -Name IamIpAddressName
$IamIpAddress | Remove-IntersightIamIpAddress

#Remove the server profile by Moid.
Remove-IntersightIamIpAddress -Moid '<Replace with Moid>'
