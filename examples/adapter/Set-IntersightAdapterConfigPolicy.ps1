# Get the AdapterConfigPolicy to Update
$AdapterConfigPolicy = Get-IntersightAdapterConfigPolicy -Name AdapterConfigPolicyName

$PortChannelSettings = Initialize-IntersightAdapterPortChannelSettings -Enabled $true
$AdapterConfig3 = Initialize-IntersightAdapterAdapterConfig -PortChannelSettings $PortChannelSettings
$AdapterConfigPolicy.Settings.Add($AdapterConfig3)

$AdapterConfigPolicy | Set-IntersightAdapterConfigPolicy -Description 'demo' -Settings $AdapterConfig3.Settings