#Get the SolPolicy to delete
$SolPolicy = Get-IntersightSolPolicy -Name SolPolicyName
$SolPolicy | Remove-IntersightSolPolicy

#Remove the SolPolicy by Moid.
Remove-IntersightSolPolicy -Moid '<Replace with Moid>'
