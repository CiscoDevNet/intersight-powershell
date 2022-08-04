$resource_limits1 = Get-IntersightIamResourcelimits -Moid '<Replace with Moid>'

$security_holder1 = Get-IntersightIamSecurityholder -Moid '<Replace with Moid>'

$session_limits1 = Get-IntersightIamSessionlimits -Moid '<Replace with Moid>'

$account1 = New-IntersightIamAccount -ResourceLimits $resource_limits1 -SecurityHolder $security_holder1 -SessionLimits $session_limits1 -Name 'iamaccount-1'