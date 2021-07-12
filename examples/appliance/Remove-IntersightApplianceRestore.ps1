
#Get the ApplianceRestore to delete
$ApplianceRestore = Remove-IntersightApplianceRestore -Name ApplianceRestoreName
$ApplianceRestore | Remove-IntersightApplianceRestore

#Remove the server profile by Moid.
Remove-IntersightApplianceRestore -Moid 123bc2222287wee
