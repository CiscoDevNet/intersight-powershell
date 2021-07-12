
#Get the SolPolicy to delete
$SolPolicy = Remove-IntersightSolPolicy -Name SolPolicyName
$SolPolicy | Remove-IntersightSolPolicy

#Remove the server profile by Moid.
Remove-IntersightSolPolicy -Moid 123bc2222287wee
