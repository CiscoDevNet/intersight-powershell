
#Get the IpmioverlanPolicy to delete
$IpmioverlanPolicy = Get-IntersightIpmioverlanPolicy -Name IpmioverlanPolicyName
$IpmioverlanPolicy | Remove-IntersightIpmioverlanPolicy

#Remove the IpmioverlanPolicy by Moid.
Remove-IntersightIpmioverlanPolicy -Moid '<Replace with Moid>'
