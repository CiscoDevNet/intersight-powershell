
#Get the HyperflexFeatureLimitInternal to delete
$HyperflexFeatureLimitInternal = Remove-IntersightHyperflexFeatureLimitInternal -Name HyperflexFeatureLimitInternalName
$HyperflexFeatureLimitInternal | Remove-IntersightHyperflexFeatureLimitInternal

#Remove the server profile by Moid.
Remove-IntersightHyperflexFeatureLimitInternal -Moid 123bc2222287wee
