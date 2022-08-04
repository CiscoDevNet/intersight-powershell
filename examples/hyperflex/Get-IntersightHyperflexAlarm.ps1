#Get the HyperflexAlarm by Name
$HyperflexAlarmByName = Get-IntersightHyperflexAlarm -Name HyperflexAlarmName

#Get the List of ServerProfiles
$HyperflexAlarmList = Get-IntersightHyperflexAlarm

#Get the list of HyperflexAlarm under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexAlarmByOrg = Get-IntersightHyperflexAlarm -Organization $org

#Get the HyperflexAlarm based on query Parameter
$HyperflexAlarmByQueryParam = Get-IntersightHyperflexAlarm -Filter Name eq HyperflexAlarmName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .