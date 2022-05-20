
#Get the HyperflexHxapDatacenter to delete
$HyperflexHxapDatacenter = Get-IntersightHyperflexHxapDatacenter -Name HyperflexHxapDatacenterName
$HyperflexHxapDatacenter | Remove-IntersightHyperflexHxapDatacenter

#Remove the HyperflexHxapDatacenter by Moid.
Remove-IntersightHyperflexHxapDatacenter -Moid '<Replace with Moid>'
