#Get the TamAdvisoryCount by Name
$TamAdvisoryCountByName = Get-IntersightTamAdvisoryCount -Name TamAdvisoryCountName

#Get the List of TamAdvisoryCount
$TamAdvisoryCountList = Get-IntersightTamAdvisoryCount

#Get the list of TamAdvisoryCount under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$TamAdvisoryCountByOrg = Get-IntersightTamAdvisoryCount -Organization $org

#Get the TamAdvisoryCount based on query Parameter
$TamAdvisoryCountByQueryParam = Get-IntersightTamAdvisoryCount -Filter Name eq TamAdvisoryCountName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .