
#Get the SoftwarerepositoryRelease to delete
$SoftwarerepositoryRelease = Remove-IntersightSoftwarerepositoryRelease -Name SoftwarerepositoryReleaseName
$SoftwarerepositoryRelease | Remove-IntersightSoftwarerepositoryRelease

#Remove the server profile by Moid.
Remove-IntersightSoftwarerepositoryRelease -Moid 123bc2222287wee
