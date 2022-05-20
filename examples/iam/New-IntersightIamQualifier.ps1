$account1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$permissions = Get-IntersightIamPermission -Moid '<Replace with Moid>'

$idp = Initialize-IntersightIamIdp -DomainName 'cisco.com' -EnableSingleLogout 1 -Name 'Cisco' -Type Saml

$usergroup1 = Initialize-IntersightIamUsergroup -Idp $idp -Permissions $permissions 

$iam_qualifier1 = New-IntersightIamQualifier -Usergroup $usergroup1