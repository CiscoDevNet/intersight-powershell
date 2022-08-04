#Get the LicenseSmartlicenseToken by Name
$LicenseSmartlicenseTokenByName = Get-IntersightLicenseSmartlicenseToken -Name LicenseSmartlicenseTokenName

#Get the List of ServerProfiles
$LicenseSmartlicenseTokenList = Get-IntersightLicenseSmartlicenseToken

#Get the list of LicenseSmartlicenseToken under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$LicenseSmartlicenseTokenByOrg = Get-IntersightLicenseSmartlicenseToken -Organization $org

#Get the LicenseSmartlicenseToken based on query Parameter
$LicenseSmartlicenseTokenByQueryParam = Get-IntersightLicenseSmartlicenseToken -Filter Name eq LicenseSmartlicenseTokenName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .