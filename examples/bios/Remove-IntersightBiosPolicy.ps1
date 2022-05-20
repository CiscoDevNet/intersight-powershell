
#Get the BiosPolicy to delete
$BiosPolicy = Get-IntersightBiosPolicy -Name BiosPolicyName
$BiosPolicy | Remove-IntersightBiosPolicy

#Remove the BiosPolicy by Moid.
Remove-IntersightBiosPolicy -Moid '<Replace with Moid>'
