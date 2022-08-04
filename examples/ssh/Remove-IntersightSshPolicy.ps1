#Get the SshPolicy to delete
$SshPolicy = Get-IntersightSshPolicy -Name SshPolicyName
$SshPolicy | Remove-IntersightSshPolicy

#Remove the SshPolicy by Moid.
Remove-IntersightSshPolicy -Moid '<Replace with Moid>'
