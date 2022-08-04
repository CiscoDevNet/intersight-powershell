
#Get the HyperflexFeatureLimitInternal to Update
$HyperflexFeatureLimitInternal = Get-IntersightHyperflexFeatureLimitInternal -Name HyperflexFeatureLimitInternalName
$HyperflexFeatureLimitInternal | Set-IntersightHyperflexFeatureLimitInternal -Description 'Updated description' 
