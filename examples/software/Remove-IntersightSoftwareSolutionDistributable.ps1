
#Get the SoftwareSolutionDistributable to delete
$SoftwareSolutionDistributable = Get-IntersightSoftwareSolutionDistributable -Name SoftwareSolutionDistributableName
$SoftwareSolutionDistributable | Remove-IntersightSoftwareSolutionDistributable

#Remove the SoftwareSolutionDistributable by Moid.
Remove-IntersightSoftwareSolutionDistributable -Moid '<Replace with Moid>'
