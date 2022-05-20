
#Get the SoftwareUcsdBundleDistributable to delete
$SoftwareUcsdBundleDistributable = Get-IntersightSoftwareUcsdBundleDistributable -Name SoftwareUcsdBundleDistributableName
$SoftwareUcsdBundleDistributable | Remove-IntersightSoftwareUcsdBundleDistributable

#Remove the SoftwareUcsdBundleDistributable by Moid.
Remove-IntersightSoftwareUcsdBundleDistributable -Moid '<Replace with Moid>'
