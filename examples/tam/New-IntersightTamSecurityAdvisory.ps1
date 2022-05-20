$actions1 = Initialize-IntersightTamAction

$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$tam_security_advisory1 = New-IntersightTamSecurityAdvisory -Actions $actions1 -Organization $organization -Name 'tam_security_advisories1' -State 'ready' -Status 'final'