$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$hyperflex_auto_support_policy1 = New-IntersightHyperflexAutoSupportPolicy -Organization $organization1 -AdminState 1 -ServiceTicketReceipient 'test@example.com' -Name 'hyperflex_auto_support_policy1'