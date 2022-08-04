
#Get the IaasUcsdInfo to delete
$IaasUcsdInfo = Get-IntersightIaasUcsdInfo -Name IaasUcsdInfoName
$IaasUcsdInfo | Remove-IntersightIaasUcsdInfo

#Remove the IaasUcsdInfo by Moid.
Remove-IntersightIaasUcsdInfo -Moid '<Replace with Moid>'

