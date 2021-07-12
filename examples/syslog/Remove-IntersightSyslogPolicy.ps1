
#Get the SyslogPolicy to delete
$SyslogPolicy = Remove-IntersightSyslogPolicy -Name SyslogPolicyName
$SyslogPolicy | Remove-IntersightSyslogPolicy

#Remove the server profile by Moid.
Remove-IntersightSyslogPolicy -Moid 123bc2222287wee
