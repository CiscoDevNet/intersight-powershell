
#Get the SoftwareUcsdDistributable to delete
$SoftwareUcsdDistributable = Get-IntersightSoftwareUcsdDistributable -Name SoftwareUcsdDistributableName
$SoftwareUcsdDistributable | Remove-IntersightSoftwareUcsdDistributable

#Remove the SoftwareUcsdDistributable by Moid.
Remove-IntersightSoftwareUcsdDistributable -Moid '<Replace with Moid>'
