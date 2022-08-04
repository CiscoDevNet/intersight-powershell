$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$policy_bucket1 = Get-IntersightBootPrecisionpolicy -Moid '<Replace with Moid>'

$policy_bucket1 = Get-IntersightAccessPolicy -Moid '<Replace with Moid>'

$policy_bucket1 = Get-IntersightSolPolicy -Moid '<Replace with Moid>'

$template1 = New-IntersightServerProfileTemplate -Organization $organization1 -PolicyBucket @($policy_bucket1,$policy_bucket2,$policy_bucket3) -Name 'server_profile_template1' -Description 'demo server profile template' -TargetPlatform 'FIAttached'