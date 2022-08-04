#Get the SoftwarerepositoryCategoryMapper to delete
$SoftwarerepositoryCategoryMapper = Get-IntersightSoftwarerepositoryCategoryMapper -Name SoftwarerepositoryCategoryMapperName
$SoftwarerepositoryCategoryMapper | Remove-IntersightSoftwarerepositoryCategoryMapper

#Remove the SoftwarerepositoryCategoryMapper by Moid.
Remove-IntersightSoftwarerepositoryCategoryMapper -Moid '<Replace with Moid>'
