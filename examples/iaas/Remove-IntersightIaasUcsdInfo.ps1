
#Get the IaasUcsdInfo to delete
$IaasUcsdInfo = Remove-IntersightIaasUcsdInfo -Name IaasUcsdInfoName
$IaasUcsdInfo | Remove-IntersightIaasUcsdInfo

#Remove the server profile by Moid.
Remove-IntersightIaasUcsdInfo -Moid 123bc2222287wee
