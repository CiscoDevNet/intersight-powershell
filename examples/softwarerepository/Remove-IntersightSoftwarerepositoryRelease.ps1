#Get the SoftwarerepositoryRelease to delete
$SoftwarerepositoryRelease = Get-IntersightSoftwarerepositoryRelease -Name SoftwarerepositoryReleaseName
$SoftwarerepositoryRelease | Remove-IntersightSoftwarerepositoryRelease

#Remove the SoftwarerepositoryRelease by Moid.
Remove-IntersightSoftwarerepositoryRelease -Moid '<Replace with Moid>'
