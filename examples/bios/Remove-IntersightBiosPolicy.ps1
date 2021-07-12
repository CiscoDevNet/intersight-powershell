
#Get the BiosPolicy to delete
$BiosPolicy = Remove-IntersightBiosPolicy -Name BiosPolicyName
$BiosPolicy | Remove-IntersightBiosPolicy

#Remove the server profile by Moid.
Remove-IntersightBiosPolicy -Moid 123bc2222287wee
