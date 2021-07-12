#Get the MetaDefinition by Name
$MetaDefinitionByName = Get-IntersightMetaDefinition -Name MetaDefinitionName

#Get the List of ServerProfiles
$MetaDefinitionList = Get-IntersightMetaDefinition

#Get the list of MetaDefinition under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$MetaDefinitionByOrg = Get-IntersightMetaDefinition -Organization $org

#Get the MetaDefinition based on query Parameter
$MetaDefinitionByQueryParam = Get-IntersightMetaDefinition -Filter Name eq MetaDefinitionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .