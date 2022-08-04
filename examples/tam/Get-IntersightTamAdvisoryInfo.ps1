#Get the TamAdvisoryInfo by Name
$TamAdvisoryInfoByName = Get-IntersightTamAdvisoryInfo -Name TamAdvisoryInfoName

#Get the List of TamAdvisoryInfo
$TamAdvisoryInfoList = Get-IntersightTamAdvisoryInfo

#Get the list of TamAdvisoryInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$TamAdvisoryInfoByOrg = Get-IntersightTamAdvisoryInfo -Organization $org

#Get the TamAdvisoryInfo based on query Parameter
$TamAdvisoryInfoByQueryParam = Get-IntersightTamAdvisoryInfo -Filter Name eq TamAdvisoryInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .