$lun1 = Initialize-IntersightVnicLun -ClassId 'VnicLun' -Bootable 1 -LunId 4

$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$vnic_iscsi_static_target_policy = New-IntersightVnicIscsiStaticTargetPolicy -Lun $lun1 -Organization $organization -Name 'vnic_iscsi_static_target_policy1' -Description 'vnic iscsi static target policy' -IpAddress '10.1.1.1' -Port 860