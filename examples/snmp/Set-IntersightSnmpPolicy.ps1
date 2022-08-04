# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the SnmpPolicy to Update
$SnmpPolicy = Get-IntersightSnmpPolicy -Name SnmpPolicyName

# Update the SnmpPolicy
$snmp1 = $SnmpPolicy | Set-IntersightSnmpPolicy -Description 'update demo snmp policy' 