#Get the TerminalAuditLog by Name
$TerminalAuditLogByName = Get-IntersightTerminalAuditLog -Name TerminalAuditLogName

#Get the List of ServerProfiles
$TerminalAuditLogList = Get-IntersightTerminalAuditLog

#Get the list of TerminalAuditLog under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$TerminalAuditLogByOrg = Get-IntersightTerminalAuditLog -Organization $org

#Get the TerminalAuditLog based on query Parameter
$TerminalAuditLogByQueryParam = Get-IntersightTerminalAuditLog -Filter Name eq TerminalAuditLogName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .