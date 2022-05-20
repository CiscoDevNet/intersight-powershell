# Get the AdapterConfigPolicy to Update
$AdapterConfigPolicy = Get-IntersightAdapterConfigPolicy -Name AdapterConfigPolicyName

$AdapterConfigPolicy | Set-IntersightAdapterConfigPolicy -Description 'demo'