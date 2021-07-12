#Get the CondHclStatusJob by Name
$CondHclStatusJobByName = Get-IntersightCondHclStatusJob -Name CondHclStatusJobName

#Get the List of ServerProfiles
$CondHclStatusJobList = Get-IntersightCondHclStatusJob

#Get the list of CondHclStatusJob under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CondHclStatusJobByOrg = Get-IntersightCondHclStatusJob -Organization $org

#Get the CondHclStatusJob based on query Parameter
$CondHclStatusJobByQueryParam = Get-IntersightCondHclStatusJob -Filter Name eq CondHclStatusJobName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .