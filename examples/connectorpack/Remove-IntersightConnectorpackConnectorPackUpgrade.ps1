
#Get the ConnectorpackConnectorPackUpgrade to delete
$ConnectorpackConnectorPackUpgrade = Get-IntersightConnectorpackConnectorPackUpgrade -Name ConnectorpackConnectorPackUpgradeName
$ConnectorpackConnectorPackUpgrade | Remove-IntersightConnectorpackConnectorPackUpgrade

#Remove the ConnectorpackConnectorPackUpgrade by Moid.
Remove-IntersightConnectorpackConnectorPackUpgrade -Moid '<Replace with Moid>'
