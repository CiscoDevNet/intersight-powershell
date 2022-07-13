$actions1 = Initialize-IntersightTamAction

$organization = Get-IntersightOrganizationOrganization -Name 'default'

$tam_security_advisory1 = New-IntersightTamSecurityAdvisory -Actions $actions1 -Organization $organization -Name 'tam_security_advisories1' -State 'ready' -Status 'final'