#Get the LicenseLicenseInfo by Name
$LicenseLicenseInfoByName = Get-IntersightLicenseLicenseInfo -Name LicenseLicenseInfoName

#Get the List of ServerProfiles
$LicenseLicenseInfoList = Get-IntersightLicenseLicenseInfo

#Get the list of LicenseLicenseInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$LicenseLicenseInfoByOrg = Get-IntersightLicenseLicenseInfo -Organization $org

#Get the LicenseLicenseInfo based on query Parameter
$LicenseLicenseInfoByQueryParam = Get-IntersightLicenseLicenseInfo -Filter Name eq LicenseLicenseInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .