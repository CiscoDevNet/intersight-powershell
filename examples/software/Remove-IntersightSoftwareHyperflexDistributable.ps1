
#Get the SoftwareHyperflexDistributable to delete
$SoftwareHyperflexDistributable = Get-IntersightSoftwareHyperflexDistributable -Name SoftwareHyperflexDistributableName
$SoftwareHyperflexDistributable | Remove-IntersightSoftwareHyperflexDistributable

#Remove the SoftwareHyperflexDistributable by Moid.
Remove-IntersightSoftwareHyperflexDistributable -Moid '<Replace with Moid>'
