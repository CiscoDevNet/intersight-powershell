
#Get the HyperflexHxdpVersion to delete
$HyperflexHxdpVersion = Remove-IntersightHyperflexHxdpVersion -Name HyperflexHxdpVersionName
$HyperflexHxdpVersion | Remove-IntersightHyperflexHxdpVersion

#Remove the server profile by Moid.
Remove-IntersightHyperflexHxdpVersion -Moid 123bc2222287wee
