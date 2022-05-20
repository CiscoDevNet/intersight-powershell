$account1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$parent1 = Get-IntersightIamSystem -Moid '<Replace with Moid>'

$system1 = Get-IntersightIamSystem -Moid '<Replace with Moid>'

$idp1 = New-IntersightIamIdp -Account $account1 -Parent $parent1 -System $system1 -DomainName 'cisco.com' -EnableSingleLogout 1 -Name 'Cisco' -Type Saml