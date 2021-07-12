
#Get the IpmioverlanPolicy to delete
$IpmioverlanPolicy = Remove-IntersightIpmioverlanPolicy -Name IpmioverlanPolicyName
$IpmioverlanPolicy | Remove-IntersightIpmioverlanPolicy

#Remove the server profile by Moid.
Remove-IntersightIpmioverlanPolicy -Moid 123bc2222287wee
