#Get the NiatelemetryNiaLicenseState by Name
$NiatelemetryNiaLicenseStateByName = Get-IntersightNiatelemetryNiaLicenseState -Name NiatelemetryNiaLicenseStateName

#Get the List of ServerProfiles
$NiatelemetryNiaLicenseStateList = Get-IntersightNiatelemetryNiaLicenseState

#Get the list of NiatelemetryNiaLicenseState under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NiatelemetryNiaLicenseStateByOrg = Get-IntersightNiatelemetryNiaLicenseState -Organization $org

#Get the NiatelemetryNiaLicenseState based on query Parameter
$NiatelemetryNiaLicenseStateByQueryParam = Get-IntersightNiatelemetryNiaLicenseState -Filter Name eq NiatelemetryNiaLicenseStateName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .