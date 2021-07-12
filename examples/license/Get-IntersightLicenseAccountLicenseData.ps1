#Get the LicenseAccountLicenseData by Name
$LicenseAccountLicenseDataByName = Get-IntersightLicenseAccountLicenseData -Name LicenseAccountLicenseDataName

#Get the List of ServerProfiles
$LicenseAccountLicenseDataList = Get-IntersightLicenseAccountLicenseData

#Get the list of LicenseAccountLicenseData under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$LicenseAccountLicenseDataByOrg = Get-IntersightLicenseAccountLicenseData -Organization $org

#Get the LicenseAccountLicenseData based on query Parameter
$LicenseAccountLicenseDataByQueryParam = Get-IntersightLicenseAccountLicenseData -Filter Name eq LicenseAccountLicenseDataName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .