#Get the ServerConfigResultEntry by Name
$ServerConfigResultEntryByName = Get-IntersightServerConfigResultEntry -Name ServerConfigResultEntryName

#Get the List of ServerProfiles
$ServerConfigResultEntryList = Get-IntersightServerConfigResultEntry

#Get the list of ServerConfigResultEntry under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ServerConfigResultEntryByOrg = Get-IntersightServerConfigResultEntry -Organization $org

#Get the ServerConfigResultEntry based on query Parameter
$ServerConfigResultEntryByQueryParam = Get-IntersightServerConfigResultEntry -Filter Name eq ServerConfigResultEntryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .