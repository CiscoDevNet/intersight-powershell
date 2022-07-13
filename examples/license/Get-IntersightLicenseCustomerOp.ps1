#Get the LicenseCustomerOp by Name
$LicenseCustomerOpByName = Get-IntersightLicenseCustomerOp -Name LicenseCustomerOpName

#Get the List of ServerProfiles
$LicenseCustomerOpList = Get-IntersightLicenseCustomerOp

#Get the list of LicenseCustomerOp under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$LicenseCustomerOpByOrg = Get-IntersightLicenseCustomerOp -Organization $org

#Get the LicenseCustomerOp based on query Parameter
$LicenseCustomerOpByQueryParam = Get-IntersightLicenseCustomerOp -Filter Name eq LicenseCustomerOpName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .