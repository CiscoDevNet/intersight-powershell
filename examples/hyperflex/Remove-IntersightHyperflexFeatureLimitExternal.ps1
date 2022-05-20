
#Get the HyperflexFeatureLimitExternal to delete
$HyperflexFeatureLimitExternal = Get-IntersightHyperflexFeatureLimitExternal -Name HyperflexFeatureLimitExternalName
$HyperflexFeatureLimitExternal | Remove-IntersightHyperflexFeatureLimitExternal

#Remove the HyperflexFeatureLimitExternal by Moid.
Remove-IntersightHyperflexFeatureLimitExternal -Moid '<Replace with Moid>'
