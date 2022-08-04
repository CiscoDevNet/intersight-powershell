
#Get the NtpPolicy to Update
$NtpPolicy = Get-IntersightNtpPolicy -Name NtpPolicyName
$NtpPolicy | Set-IntersightNtpPolicy -Description 'Updated description'
