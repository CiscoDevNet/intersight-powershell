
#Get the NtpPolicy to delete
$NtpPolicy = Get-IntersightNtpPolicy -Name NtpPolicyName
$NtpPolicy | Remove-IntersightNtpPolicy

#Remove the NtpPolicy by Moid.
Remove-IntersightNtpPolicy -Moid '<Replace with Moid>'
