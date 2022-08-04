#Get the SmtpPolicy to delete
$SmtpPolicy = Get-IntersightSmtpPolicy -Name SmtpPolicyName
$SmtpPolicy | Remove-IntersightSmtpPolicy

#Remove the SmtpPolicy by Moid.
Remove-IntersightSmtpPolicy -Moid '<Replace with Moid>'
