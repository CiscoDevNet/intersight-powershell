#Get the ExternalsiteAuthorization by Name
$ExternalsiteAuthorizationByName = Get-IntersightExternalsiteAuthorization -Name ExternalsiteAuthorizationName

#Get the List of ServerProfiles
$ExternalsiteAuthorizationList = Get-IntersightExternalsiteAuthorization

#Get the list of ExternalsiteAuthorization under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ExternalsiteAuthorizationByOrg = Get-IntersightExternalsiteAuthorization -Organization $org

#Get the ExternalsiteAuthorization based on query Parameter
$ExternalsiteAuthorizationByQueryParam = Get-IntersightExternalsiteAuthorization -Filter Name eq ExternalsiteAuthorizationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .