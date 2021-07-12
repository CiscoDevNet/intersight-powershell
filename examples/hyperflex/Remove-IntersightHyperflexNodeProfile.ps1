
#Get the HyperflexNodeProfile to delete
$HyperflexNodeProfile = Remove-IntersightHyperflexNodeProfile -Name HyperflexNodeProfileName
$HyperflexNodeProfile | Remove-IntersightHyperflexNodeProfile

#Remove the server profile by Moid.
Remove-IntersightHyperflexNodeProfile -Moid 123bc2222287wee
