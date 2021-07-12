#Get the IaasLicenseInfo by Name
$IaasLicenseInfoByName = Get-IntersightIaasLicenseInfo -Name IaasLicenseInfoName

#Get the List of ServerProfiles
$IaasLicenseInfoList = Get-IntersightIaasLicenseInfo

#Get the list of IaasLicenseInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IaasLicenseInfoByOrg = Get-IntersightIaasLicenseInfo -Organization $org

#Get the IaasLicenseInfo based on query Parameter
$IaasLicenseInfoByQueryParam = Get-IntersightIaasLicenseInfo -Filter Name eq IaasLicenseInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .