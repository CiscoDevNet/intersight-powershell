#Get the IaasMostRunTasks by Name
$IaasMostRunTasksByName = Get-IntersightIaasMostRunTasks -Name IaasMostRunTasksName

#Get the List of ServerProfiles
$IaasMostRunTasksList = Get-IntersightIaasMostRunTasks

#Get the list of IaasMostRunTasks under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IaasMostRunTasksByOrg = Get-IntersightIaasMostRunTasks -Organization $org

#Get the IaasMostRunTasks based on query Parameter
$IaasMostRunTasksByQueryParam = Get-IntersightIaasMostRunTasks -Filter Name eq IaasMostRunTasksName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .