$password_properties1 = Initialize-IntersightIamEndpointpasswordproperties -EnforceStrongPassword 1 -EnablePasswordExpiry 1 -PasswordExpiryDuration 50 -PasswordHistory 5 -NotificationPeriod 1 -GracePeriod 2 

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$user_policy1 = New-IntersightIamEndPointUserPolicy -PasswordProperties $password_properties1 -Organization $organization1 -Name 'user_policy1' -Description 'test policy'