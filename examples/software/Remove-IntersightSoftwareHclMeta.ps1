
#Get the SoftwareHclMeta to delete
$SoftwareHclMeta = Remove-IntersightSoftwareHclMeta -Name SoftwareHclMetaName
$SoftwareHclMeta | Remove-IntersightSoftwareHclMeta

#Remove the server profile by Moid.
Remove-IntersightSoftwareHclMeta -Moid 123bc2222287wee
