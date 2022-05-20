
#Get the HyperflexClusterProfile to Update
$HyperflexClusterProfile = Get-IntersightHyperflexClusterProfile -Name HyperflexClusterProfileName
$HyperflexClusterProfile | Set-IntersightHyperflexClusterProfile -Description 'Updated description'
