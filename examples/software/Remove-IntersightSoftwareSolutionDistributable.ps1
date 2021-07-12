
#Get the SoftwareSolutionDistributable to delete
$SoftwareSolutionDistributable = Remove-IntersightSoftwareSolutionDistributable -Name SoftwareSolutionDistributableName
$SoftwareSolutionDistributable | Remove-IntersightSoftwareSolutionDistributable

#Remove the server profile by Moid.
Remove-IntersightSoftwareSolutionDistributable -Moid 123bc2222287wee
