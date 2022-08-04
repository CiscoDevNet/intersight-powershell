#Get the ConnectorpackConnectorPackUpgrade by Name
$ConnectorpackConnectorPackUpgradeByName = Get-IntersightConnectorpackConnectorPackUpgrade -Name ConnectorpackConnectorPackUpgradeName

#Get the List of ServerProfiles
$ConnectorpackConnectorPackUpgradeList = Get-IntersightConnectorpackConnectorPackUpgrade

#Get the list of ConnectorpackConnectorPackUpgrade under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ConnectorpackConnectorPackUpgradeByOrg = Get-IntersightConnectorpackConnectorPackUpgrade -Organization $org

#Get the ConnectorpackConnectorPackUpgrade based on query Parameter
$ConnectorpackConnectorPackUpgradeByQueryParam = Get-IntersightConnectorpackConnectorPackUpgrade -Filter Name eq ConnectorpackConnectorPackUpgradeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .