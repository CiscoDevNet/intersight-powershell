
#Get the HyperflexFeatureLimitExternal to delete
$HyperflexFeatureLimitExternal = Remove-IntersightHyperflexFeatureLimitExternal -Name HyperflexFeatureLimitExternalName
$HyperflexFeatureLimitExternal | Remove-IntersightHyperflexFeatureLimitExternal

#Remove the server profile by Moid.
Remove-IntersightHyperflexFeatureLimitExternal -Moid 123bc2222287wee
