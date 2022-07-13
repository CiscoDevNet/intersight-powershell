#Get the CondAlarm by Name
$CondAlarmByName = Get-IntersightCondAlarm -Name CondAlarmName

#Get the List of ServerProfiles
$CondAlarmList = Get-IntersightCondAlarm

#Get the list of CondAlarm under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CondAlarmByOrg = Get-IntersightCondAlarm -Organization $org

#Get the CondAlarm based on query Parameter
$CondAlarmByQueryParam = Get-IntersightCondAlarm -Filter Name eq CondAlarmName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .