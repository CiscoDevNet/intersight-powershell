
#Get the SoftwarerepositoryOperatingSystemFile to delete
$SoftwarerepositoryOperatingSystemFile = Remove-IntersightSoftwarerepositoryOperatingSystemFile -Name SoftwarerepositoryOperatingSystemFileName
$SoftwarerepositoryOperatingSystemFile | Remove-IntersightSoftwarerepositoryOperatingSystemFile

#Remove the server profile by Moid.
Remove-IntersightSoftwarerepositoryOperatingSystemFile -Moid 123bc2222287wee
