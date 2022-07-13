#Get the CondAlarmAggregation by Name
$CondAlarmAggregationByName = Get-IntersightCondAlarmAggregation -Name CondAlarmAggregationName

#Get the List of ServerProfiles
$CondAlarmAggregationList = Get-IntersightCondAlarmAggregation

#Get the list of CondAlarmAggregation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CondAlarmAggregationByOrg = Get-IntersightCondAlarmAggregation -Organization $org

#Get the CondAlarmAggregation based on query Parameter
$CondAlarmAggregationByQueryParam = Get-IntersightCondAlarmAggregation -Filter Name eq CondAlarmAggregationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .