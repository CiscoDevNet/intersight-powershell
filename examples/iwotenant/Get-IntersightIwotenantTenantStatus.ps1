#Get the IwotenantTenantStatus by Name
$IwotenantTenantStatusByName = Get-IntersightIwotenantTenantStatus -Name IwotenantTenantStatusName

#Get the List of ServerProfiles
$IwotenantTenantStatusList = Get-IntersightIwotenantTenantStatus

#Get the list of IwotenantTenantStatus under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IwotenantTenantStatusByOrg = Get-IntersightIwotenantTenantStatus -Organization $org

#Get the IwotenantTenantStatus based on query Parameter
$IwotenantTenantStatusByQueryParam = Get-IntersightIwotenantTenantStatus -Filter Name eq IwotenantTenantStatusName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .