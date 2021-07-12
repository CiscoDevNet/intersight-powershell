#Get the ConnectorpackUpgradeImpact by Name
$ConnectorpackUpgradeImpactByName = Get-IntersightConnectorpackUpgradeImpact -Name ConnectorpackUpgradeImpactName

#Get the List of ServerProfiles
$ConnectorpackUpgradeImpactList = Get-IntersightConnectorpackUpgradeImpact

#Get the list of ConnectorpackUpgradeImpact under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ConnectorpackUpgradeImpactByOrg = Get-IntersightConnectorpackUpgradeImpact -Organization $org

#Get the ConnectorpackUpgradeImpact based on query Parameter
$ConnectorpackUpgradeImpactByQueryParam = Get-IntersightConnectorpackUpgradeImpact -Filter Name eq ConnectorpackUpgradeImpactName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .