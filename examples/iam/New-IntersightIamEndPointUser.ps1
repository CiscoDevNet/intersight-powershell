$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$iam_end_point_user1 = New-IntersightIamEndPointUser -Organization $organization1 -Name 'iam_end_point_user1'