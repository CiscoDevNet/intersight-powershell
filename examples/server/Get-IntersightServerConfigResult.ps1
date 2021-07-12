#Get the ServerConfigResult by Name
$ServerConfigResultByName = Get-IntersightServerConfigResult -Name ServerConfigResultName

#Get the List of ServerProfiles
$ServerConfigResultList = Get-IntersightServerConfigResult

#Get the list of ServerConfigResult under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ServerConfigResultByOrg = Get-IntersightServerConfigResult -Organization $org

#Get the ServerConfigResult based on query Parameter
$ServerConfigResultByQueryParam = Get-IntersightServerConfigResult -Filter Name eq ServerConfigResultName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .