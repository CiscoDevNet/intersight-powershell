
#Get the AccessPolicy to delete
$AccessPolicy = Remove-IntersightAccessPolicy -Name AccessPolicyName
$AccessPolicy | Remove-IntersightAccessPolicy

#Remove the server profile by Moid.
Remove-IntersightAccessPolicy -Moid 123bc2222287wee
