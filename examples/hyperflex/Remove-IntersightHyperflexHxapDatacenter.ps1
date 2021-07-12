
#Get the HyperflexHxapDatacenter to delete
$HyperflexHxapDatacenter = Remove-IntersightHyperflexHxapDatacenter -Name HyperflexHxapDatacenterName
$HyperflexHxapDatacenter | Remove-IntersightHyperflexHxapDatacenter

#Remove the server profile by Moid.
Remove-IntersightHyperflexHxapDatacenter -Moid 123bc2222287wee
