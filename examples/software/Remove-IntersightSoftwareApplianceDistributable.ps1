
#Get the SoftwareApplianceDistributable to delete
$SoftwareApplianceDistributable = Remove-IntersightSoftwareApplianceDistributable -Name SoftwareApplianceDistributableName
$SoftwareApplianceDistributable | Remove-IntersightSoftwareApplianceDistributable

#Remove the server profile by Moid.
Remove-IntersightSoftwareApplianceDistributable -Moid 123bc2222287wee