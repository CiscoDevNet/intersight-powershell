#Get the LicenseIwoLicenseCount by Name
$LicenseIwoLicenseCountByName = Get-IntersightLicenseIwoLicenseCount -Name LicenseIwoLicenseCountName

#Get the List of ServerProfiles
$LicenseIwoLicenseCountList = Get-IntersightLicenseIwoLicenseCount

#Get the list of LicenseIwoLicenseCount under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$LicenseIwoLicenseCountByOrg = Get-IntersightLicenseIwoLicenseCount -Organization $org

#Get the LicenseIwoLicenseCount based on query Parameter
$LicenseIwoLicenseCountByQueryParam = Get-IntersightLicenseIwoLicenseCount -Filter Name eq LicenseIwoLicenseCountName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .