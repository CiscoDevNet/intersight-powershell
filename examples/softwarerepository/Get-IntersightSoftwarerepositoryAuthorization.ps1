#Get the SoftwarerepositoryAuthorization by Name
$SoftwarerepositoryAuthorizationByName = Get-IntersightSoftwarerepositoryAuthorization -Name SoftwarerepositoryAuthorizationName

#Get the List of ServerProfiles
$SoftwarerepositoryAuthorizationList = Get-IntersightSoftwarerepositoryAuthorization

#Get the list of SoftwarerepositoryAuthorization under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$SoftwarerepositoryAuthorizationByOrg = Get-IntersightSoftwarerepositoryAuthorization -Organization $org

#Get the SoftwarerepositoryAuthorization based on query Parameter
$SoftwarerepositoryAuthorizationByQueryParam = Get-IntersightSoftwarerepositoryAuthorization -Filter Name eq SoftwarerepositoryAuthorizationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .