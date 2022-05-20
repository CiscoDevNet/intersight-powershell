
#Get the HyperflexClusterProfile to delete
$HyperflexClusterProfile = Get-IntersightHyperflexClusterProfile -Name HyperflexClusterProfileName
$HyperflexClusterProfile | Remove-IntersightHyperflexClusterProfile

#Remove the HyperflexClusterProfile by Moid.
Remove-IntersightHyperflexClusterProfile -Moid '<Replace with Moid>'
