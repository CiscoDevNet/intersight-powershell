
#Get the HyperflexHxdpVersion to delete
$HyperflexHxdpVersion = Get-IntersightHyperflexHxdpVersion -Name HyperflexHxdpVersionName
$HyperflexHxdpVersion | Remove-IntersightHyperflexHxdpVersion

#Remove the HyperflexHxdpVersion by Moid.
Remove-IntersightHyperflexHxdpVersion -Moid '<Replace with Moid>'
