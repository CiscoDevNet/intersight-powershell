
#Get the SoftwareReleaseMeta to delete
$SoftwareReleaseMeta = Remove-IntersightSoftwareReleaseMeta -Name SoftwareReleaseMetaName
$SoftwareReleaseMeta | Remove-IntersightSoftwareReleaseMeta

#Remove the server profile by Moid.
Remove-IntersightSoftwareReleaseMeta -Moid 123bc2222287wee
