$holder1 = Get-IntersightIamSecurityholder -Moid '<Replace with Moid>'

$parent1 = Get-IntersightIamSystem -Moid '<Replace with Moid>'

$iam_ip_access_management1 = New-IntersightIamIpAccessManagement -Holder $holder1 -Parent $parent1 -Enable 1