$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$comm_http_proxy_policy1 = New-IntersightCommHttpProxyPolicy -Organization $organization1 -Name 'comm_http_proxy_policy1' -Description 'comm http proxy policy' -Hostname '10.10.10.1' -Password 'ChangeMe' -Port 53 -Username 'admin'