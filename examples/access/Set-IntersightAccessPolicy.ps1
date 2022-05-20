# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the AccessPolicy to Update
$AccessPolicy = Get-IntersightAccessPolicy -Name AccessPolicyName

# Update the AccessPolicy
$access1 = $AccessPolicy | Set-IntersightAccessPolicy -Description 'update demo access policy' -InbandVlan 19