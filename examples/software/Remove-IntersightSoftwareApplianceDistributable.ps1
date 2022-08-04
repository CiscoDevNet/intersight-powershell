#Get the SoftwareApplianceDistributable to delete
$SoftwareApplianceDistributable = Get-IntersightSoftwareApplianceDistributable -Name SoftwareApplianceDistributableName
$SoftwareApplianceDistributable | Remove-IntersightSoftwareApplianceDistributable

#Remove the SoftwareApplianceDistributable by Moid.
Remove-IntersightSoftwareApplianceDistributable -Moid '<Replace with Moid>'

