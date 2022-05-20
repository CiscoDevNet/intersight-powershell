
#Get the IpmioverlanPolicy to Update
$IpmioverlanPolicy = Get-IntersightIpmioverlanPolicy -Name IpmioverlanPolicyName
$IpmioverlanPolicy | Set-IntersightIpmioverlanPolicy -Description 'Updated description'