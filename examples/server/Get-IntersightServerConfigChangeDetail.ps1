#Get the ServerConfigChangeDetail by Name
$ServerConfigChangeDetailByName = Get-IntersightServerConfigChangeDetail -Name ServerConfigChangeDetailName

#Get the List of ServerProfiles
$ServerConfigChangeDetailList = Get-IntersightServerConfigChangeDetail

#Get the list of ServerConfigChangeDetail under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ServerConfigChangeDetailByOrg = Get-IntersightServerConfigChangeDetail -Organization $org

#Get the ServerConfigChangeDetail based on query Parameter
$ServerConfigChangeDetailByQueryParam = Get-IntersightServerConfigChangeDetail -Filter Name eq ServerConfigChangeDetailName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .