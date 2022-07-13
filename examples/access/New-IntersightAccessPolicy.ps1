# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

$inband_ip_pool1 = Get-IntersightIppoolpool -Moid '<Replace with Moid>'

# Create the AccessPolicy
$access1 = New-IntersightAccessPolicy -Name 'access1' -InbandIpPool $inband_ip_pool1 -Organization $organization -Description 'demo access policy' -InbandVlan 19