#Get the StorageNetAppLicense by Name
$StorageNetAppLicenseByName = Get-IntersightStorageNetAppLicense -Name StorageNetAppLicenseName

#Get the List of ServerProfiles
$StorageNetAppLicenseList = Get-IntersightStorageNetAppLicense

#Get the list of StorageNetAppLicense under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppLicenseByOrg = Get-IntersightStorageNetAppLicense -Organization $org

#Get the StorageNetAppLicense based on query Parameter
$StorageNetAppLicenseByQueryParam = Get-IntersightStorageNetAppLicense -Filter Name eq StorageNetAppLicenseName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .