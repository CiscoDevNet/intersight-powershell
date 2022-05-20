# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

# Get the VnicEthNetworkPolicy  to Update
$VnicEthNetworkPolicy = Get-IntersightVnicEthNetworkPolicy -Name VnicEthNetworkPolicyName

# Update the VnicEthNetworkPolicy
$v_eth_network1 = $VnicEthNetworkPolicy | Set-IntersightVnicEthNetworkPolicy -Description 'Update demo vnic eth network policy'