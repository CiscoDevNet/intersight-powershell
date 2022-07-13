$organization = Get-IntersightOrganizationOrganization -Name 'default'

$v_fc_qos1 = New-IntersightVnicFcQosPolicy -Organization $organization -Name 'v_fc_qos1' -RateLimit 10000 -Cos 6 -MaxDataFieldSize 2112