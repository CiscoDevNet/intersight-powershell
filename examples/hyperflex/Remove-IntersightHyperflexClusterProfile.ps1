
#Get the HyperflexClusterProfile to delete
$HyperflexClusterProfile = Remove-IntersightHyperflexClusterProfile -Name HyperflexClusterProfileName
$HyperflexClusterProfile | Remove-IntersightHyperflexClusterProfile

#Remove the server profile by Moid.
Remove-IntersightHyperflexClusterProfile -Moid 123bc2222287wee
