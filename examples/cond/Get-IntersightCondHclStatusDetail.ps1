#Get the CondHclStatusDetail by Name
$CondHclStatusDetailByName = Get-IntersightCondHclStatusDetail -Name CondHclStatusDetailName

#Get the List of ServerProfiles
$CondHclStatusDetailList = Get-IntersightCondHclStatusDetail

#Get the list of CondHclStatusDetail under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CondHclStatusDetailByOrg = Get-IntersightCondHclStatusDetail -Organization $org

#Get the CondHclStatusDetail based on query Parameter
$CondHclStatusDetailByQueryParam = Get-IntersightCondHclStatusDetail -Filter Name eq CondHclStatusDetailName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .