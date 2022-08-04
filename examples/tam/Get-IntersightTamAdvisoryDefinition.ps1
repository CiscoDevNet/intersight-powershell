#Get the TamAdvisoryDefinition by Name
$TamAdvisoryDefinitionByName = Get-IntersightTamAdvisoryDefinition -Name TamAdvisoryDefinitionName

#Get the List of TamAdvisoryDefinition
$TamAdvisoryDefinitionList = Get-IntersightTamAdvisoryDefinition

#Get the list of TamAdvisoryDefinition under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$TamAdvisoryDefinitionByOrg = Get-IntersightTamAdvisoryDefinition -Organization $org

#Get the TamAdvisoryDefinition based on query Parameter
$TamAdvisoryDefinitionByQueryParam = Get-IntersightTamAdvisoryDefinition -Filter Name eq TamAdvisoryDefinitionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .