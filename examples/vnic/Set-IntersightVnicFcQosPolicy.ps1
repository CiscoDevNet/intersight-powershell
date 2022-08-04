# Get the organization.
$organization = Get-IntersightOrganizationOrganization -Name 'default'

# Get the VnicFcQosPolicy to Update
$VnicFcQosPolicy = Get-IntersightVnicFcQosPolicy -Name VnicFcQosPolicyName

# Update the VnicFcQosPolicy
$v_fc_qos1 = $VnicFcQosPolicy | Set-IntersightVnicFcQosPolicy -Description 'Update demo vnic fc qos policy'