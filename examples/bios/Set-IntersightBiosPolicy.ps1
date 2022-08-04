#Get the BiosPolicy to Update

$BiosPolicy = Get-IntersightBiosPolicy -Name BiosPolicyName
$BiosPolicy | Set-IntersightBiosPolicy -Description 'Bios policy'