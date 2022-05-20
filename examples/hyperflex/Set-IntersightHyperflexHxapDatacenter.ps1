
#Get the HyperflexHxapDatacenter to Update
$HyperflexHxapDatacenter = Get-IntersightHyperflexHxapDatacenter -Name HyperflexHxapDatacenterName
$HyperflexHxapDatacenter | Set-IntersightHyperflexHxapDatacenter -Description 'Updated description'
