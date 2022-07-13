#Get the LicenseIwoCustomerOp by Name
$LicenseIwoCustomerOpByName = Get-IntersightLicenseIwoCustomerOp -Name LicenseIwoCustomerOpName

#Get the List of ServerProfiles
$LicenseIwoCustomerOpList = Get-IntersightLicenseIwoCustomerOp

#Get the list of LicenseIwoCustomerOp under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$LicenseIwoCustomerOpByOrg = Get-IntersightLicenseIwoCustomerOp -Organization $org

#Get the LicenseIwoCustomerOp based on query Parameter
$LicenseIwoCustomerOpByQueryParam = Get-IntersightLicenseIwoCustomerOp -Filter Name eq LicenseIwoCustomerOpName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .