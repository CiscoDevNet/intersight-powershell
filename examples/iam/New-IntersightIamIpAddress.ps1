$ip_access_management1 = Get-IntersightIamIpaccessmanagement -Moid '<Replace with Moid>'

$iam_ip_address1 = New-IntersightIamIpAddress -IpAccessManagement $ip_access_management1 -Address '12.13.14.15-12.13.14.200' -Description 'Trusted IP address range.'