#Get the TamSecurityAdvisory by Name
$TamSecurityAdvisoryByName = Get-IntersightTamSecurityAdvisory -Name TamSecurityAdvisoryName

#Get the List of TamSecurityAdvisory
$TamSecurityAdvisoryList = Get-IntersightTamSecurityAdvisory

#Get the list of TamSecurityAdvisory under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$TamSecurityAdvisoryByOrg = Get-IntersightTamSecurityAdvisory -Organization $org

#Get the TamSecurityAdvisory based on query Parameter
$TamSecurityAdvisoryByQueryParam = Get-IntersightTamSecurityAdvisory -Filter Name eq TamSecurityAdvisoryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .