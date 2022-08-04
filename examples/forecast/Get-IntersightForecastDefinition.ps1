#Get the ForecastDefinition by Name
$ForecastDefinitionByName = Get-IntersightForecastDefinition -Name ForecastDefinitionName

#Get the List of ServerProfiles
$ForecastDefinitionList = Get-IntersightForecastDefinition

#Get the list of ForecastDefinition under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ForecastDefinitionByOrg = Get-IntersightForecastDefinition -Organization $org

#Get the ForecastDefinition based on query Parameter
$ForecastDefinitionByQueryParam = Get-IntersightForecastDefinition -Filter Name eq ForecastDefinitionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .