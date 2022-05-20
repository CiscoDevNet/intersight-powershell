#Get the SyslogPolicy to delete
$SyslogPolicy = Get-IntersightSyslogPolicy -Name SyslogPolicyName
$SyslogPolicy | Remove-IntersightSyslogPolicy

#Remove the SyslogPolicy by Moid.
Remove-IntersightSyslogPolicy -Moid '<Replace with Moid>'
