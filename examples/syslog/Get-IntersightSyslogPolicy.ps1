#Get the SyslogPolicy by Name
$SyslogPolicyByName = Get-IntersightSyslogPolicy -Name SyslogPolicyName

#Get the List of SyslogPolicy
$SyslogPolicyList = Get-IntersightSyslogPolicy

#Get the list of SyslogPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SyslogPolicyByOrg = Get-IntersightSyslogPolicy -Organization $org

#Get the SyslogPolicy based on query Parameter
$SyslogPolicyByQueryParam = Get-IntersightSyslogPolicy -Filter Name eq SyslogPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .