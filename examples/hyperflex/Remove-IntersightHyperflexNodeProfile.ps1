
#Get the HyperflexNodeProfile to delete
$HyperflexNodeProfile = Get-IntersightHyperflexNodeProfile -Name HyperflexNodeProfileName
$HyperflexNodeProfile | Remove-IntersightHyperflexNodeProfile

#Remove the HyperflexNodeProfile by Moid.
Remove-IntersightHyperflexNodeProfile -Moid '<Replace with Moid>'
