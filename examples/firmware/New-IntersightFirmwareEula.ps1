$account1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$firmware_eula1 = New-IntersightFirmwareEula -Account $account1