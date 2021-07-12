#Get the NiatelemetryMsoTenantDetails by Name
$NiatelemetryMsoTenantDetailsByName = Get-IntersightNiatelemetryMsoTenantDetails -Name NiatelemetryMsoTenantDetailsName

#Get the List of ServerProfiles
$NiatelemetryMsoTenantDetailsList = Get-IntersightNiatelemetryMsoTenantDetails

#Get the list of NiatelemetryMsoTenantDetails under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$NiatelemetryMsoTenantDetailsByOrg = Get-IntersightNiatelemetryMsoTenantDetails -Organization $org

#Get the NiatelemetryMsoTenantDetails based on query Parameter
$NiatelemetryMsoTenantDetailsByQueryParam = Get-IntersightNiatelemetryMsoTenantDetails -Filter Name eq NiatelemetryMsoTenantDetailsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .