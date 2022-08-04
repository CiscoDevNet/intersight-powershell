#Get the CondHclStatus by Name
$CondHclStatusByName = Get-IntersightCondHclStatus -Name CondHclStatusName

#Get the List of ServerProfiles
$CondHclStatusList = Get-IntersightCondHclStatus

#Get the list of CondHclStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CondHclStatusByOrg = Get-IntersightCondHclStatus -Organization $org

#Get the CondHclStatus based on query Parameter
$CondHclStatusByQueryParam = Get-IntersightCondHclStatus -Filter Name eq CondHclStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .