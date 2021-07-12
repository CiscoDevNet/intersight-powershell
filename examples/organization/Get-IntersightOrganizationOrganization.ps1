#Get the OrganizationOrganization by Name
$OrganizationOrganizationByName = Get-IntersightOrganizationOrganization -Name OrganizationOrganizationName

#Get the List of ServerProfiles
$OrganizationOrganizationList = Get-IntersightOrganizationOrganization

#Get the list of OrganizationOrganization under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$OrganizationOrganizationByOrg = Get-IntersightOrganizationOrganization -Organization $org

#Get the OrganizationOrganization based on query Parameter
$OrganizationOrganizationByQueryParam = Get-IntersightOrganizationOrganization -Filter Name eq OrganizationOrganizationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .