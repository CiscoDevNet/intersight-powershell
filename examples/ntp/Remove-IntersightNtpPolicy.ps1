
#Get the NtpPolicy to delete
$NtpPolicy = Remove-IntersightNtpPolicy -Name NtpPolicyName
$NtpPolicy | Remove-IntersightNtpPolicy

#Remove the server profile by Moid.
Remove-IntersightNtpPolicy -Moid 123bc2222287wee
