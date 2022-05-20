
#Get the HyperflexHxdpVersion to Update
$HyperflexHxdpVersion = Get-IntersightHyperflexHxdpVersion -Name HyperflexHxdpVersionName
$HyperflexHxdpVersion | Set-IntersightHyperflexHxdpVersion -Description 'Updated description'
