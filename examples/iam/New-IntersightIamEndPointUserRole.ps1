$end_point_role1 = Get-IntersightIamEndpointrole -Moid '<Replace with Moid>'

$end_point_user1 = Get-IntersightIamEndpointuser -Moid '<Replace with Moid>'

$end_point_user_policy1 = Get-IntersightIamEndpointuserpolicy -Moid '<Replace with Moid>'

$iam_end_point_user_role1 = New-IntersightIamEndPointUserRole -EndPointRole $end_point_role1 -EndPointUser $end_point_user1 -EndPointUserPolicy $end_point_user_policy1 -Enabled 1 -Password 'ChangeMe'