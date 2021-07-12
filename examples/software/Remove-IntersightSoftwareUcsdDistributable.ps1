
#Get the SoftwareUcsdDistributable to delete
$SoftwareUcsdDistributable = Remove-IntersightSoftwareUcsdDistributable -Name SoftwareUcsdDistributableName
$SoftwareUcsdDistributable | Remove-IntersightSoftwareUcsdDistributable

#Remove the server profile by Moid.
Remove-IntersightSoftwareUcsdDistributable -Moid 123bc2222287wee
