#Get the IaasConnectorPack by Name
$IaasConnectorPackByName = Get-IntersightIaasConnectorPack -Name IaasConnectorPackName

#Get the List of ServerProfiles
$IaasConnectorPackList = Get-IntersightIaasConnectorPack

#Get the list of IaasConnectorPack under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$IaasConnectorPackByOrg = Get-IntersightIaasConnectorPack -Organization $org

#Get the IaasConnectorPack based on query Parameter
$IaasConnectorPackByQueryParam = Get-IntersightIaasConnectorPack -Filter Name eq IaasConnectorPackName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .