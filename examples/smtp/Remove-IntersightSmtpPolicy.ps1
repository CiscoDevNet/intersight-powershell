
#Get the SmtpPolicy to delete
$SmtpPolicy = Remove-IntersightSmtpPolicy -Name SmtpPolicyName
$SmtpPolicy | Remove-IntersightSmtpPolicy

#Remove the server profile by Moid.
Remove-IntersightSmtpPolicy -Moid 123bc2222287wee
