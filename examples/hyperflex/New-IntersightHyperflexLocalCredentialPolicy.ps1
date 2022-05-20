$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_local_credential_policy1 = New-IntersightHyperflexLocalCredentialPolicy -Organization $organization1 -HxdpRootPwd 'ChangeMe@123' -HypervisorAdmin 'admin' -HypervisorAdminPwd 'ChangeMe' -FactoryHypervisorPassword 0 -Name 'hyperflex_local_credential_policy1'