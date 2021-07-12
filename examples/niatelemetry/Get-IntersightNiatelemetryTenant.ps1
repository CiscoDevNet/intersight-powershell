#Get the NiatelemetryTenant by Name
$NiatelemetryTenantByName = Get-IntersightNiatelemetryTenant -Name NiatelemetryTenantName

#Get the List of ServerProfiles
$NiatelemetryTenantList = Get-IntersightNiatelemetryTenant

#Get the list of NiatelemetryTenant under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryTenantByOrg = Get-IntersightNiatelemetryTenant -Organization $org

#Get the NiatelemetryTenant based on query Parameter
$NiatelemetryTenantByQueryParam = Get-IntersightNiatelemetryTenant -Filter Name eq NiatelemetryTenantName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .