
#Get the CapabilityPortGroupAggregationDef to delete
$CapabilityPortGroupAggregationDef = Get-IntersightCapabilityPortGroupAggregationDef -Name CapabilityPortGroupAggregationDefName
$CapabilityPortGroupAggregationDef | Remove-IntersightCapabilityPortGroupAggregationDef

#Remove the CapabilityPortGroupAggregationDef by Moid.
Remove-IntersightCapabilityPortGroupAggregationDef -Moid '<Replace with Moid>'
