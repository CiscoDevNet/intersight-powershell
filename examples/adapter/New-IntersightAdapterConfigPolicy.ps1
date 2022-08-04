# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

$ServerProfileRef = Get-IntersightServerprofile -Name "serverProfile" | Get-IntersightMoMoRef

$EthSettings = Initialize-IntersightAdapterEthSettings -LldpEnabled 1

$FcSettings = Initialize-IntersightAdapterFcSettings -FipEnabled 1

$AdapterConfig1 = Initialize-IntersightAdapterAdapterConfig -SlotId 1 -EthSettings $EthSettings -FcSettings $FcSettings

$AdapterConfig2 = Initialize-IntersightAdapterAdapterConfig -SlotId 'MLOM' -EthSettings $EthSettings -FcSettings $FcSettings

$AdapterConfigPolicy = New-IntersightAdapterConfigPolicy -Name 'AdapterConfigPolicy' -Organization $organization -Profiles $ServerProfileRef -Settings $AdapterConfig1, $AdapterConfig2