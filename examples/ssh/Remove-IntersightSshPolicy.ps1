
#Get the SshPolicy to delete
$SshPolicy = Remove-IntersightSshPolicy -Name SshPolicyName
$SshPolicy | Remove-IntersightSshPolicy

#Remove the server profile by Moid.
Remove-IntersightSshPolicy -Moid 123bc2222287wee
