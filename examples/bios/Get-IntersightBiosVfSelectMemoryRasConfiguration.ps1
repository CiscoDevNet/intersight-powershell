#Get the BiosVfSelectMemoryRasConfiguration by Name
$BiosVfSelectMemoryRasConfigurationByName = Get-IntersightBiosVfSelectMemoryRasConfiguration -Name BiosVfSelectMemoryRasConfigurationName

#Get the List of ServerProfiles
$BiosVfSelectMemoryRasConfigurationList = Get-IntersightBiosVfSelectMemoryRasConfiguration

#Get the list of BiosVfSelectMemoryRasConfiguration under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$BiosVfSelectMemoryRasConfigurationByOrg = Get-IntersightBiosVfSelectMemoryRasConfiguration -Organization $org

#Get the BiosVfSelectMemoryRasConfiguration based on query Parameter
$BiosVfSelectMemoryRasConfigurationByQueryParam = Get-IntersightBiosVfSelectMemoryRasConfiguration -Filter Name eq BiosVfSelectMemoryRasConfigurationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .