
#Get the HyperflexFeatureLimitInternal to delete
$HyperflexFeatureLimitInternal = Get-IntersightHyperflexFeatureLimitInternal -Name HyperflexFeatureLimitInternalName
$HyperflexFeatureLimitInternal | Remove-IntersightHyperflexFeatureLimitInternal

#Remove the HyperflexFeatureLimitInternal by Moid.
Remove-IntersightHyperflexFeatureLimitInternal -Moid '<Replace with Moid>'
