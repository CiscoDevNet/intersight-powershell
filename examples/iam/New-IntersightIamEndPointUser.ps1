$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$iam_end_point_user1 = New-IntersightIamEndPointUser -Organization $organization1 -Name 'iam_end_point_user1'