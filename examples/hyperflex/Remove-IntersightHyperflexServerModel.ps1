
#Get the HyperflexServerModel to delete
$HyperflexServerModel = Remove-IntersightHyperflexServerModel -Name HyperflexServerModelName
$HyperflexServerModel | Remove-IntersightHyperflexServerModel

#Remove the server profile by Moid.
Remove-IntersightHyperflexServerModel -Moid 123bc2222287wee
