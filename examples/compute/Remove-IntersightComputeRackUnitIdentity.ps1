
#Get the ComputeRackUnitIdentity to delete
$ComputeRackUnitIdentity = Remove-IntersightComputeRackUnitIdentity -Name ComputeRackUnitIdentityName
$ComputeRackUnitIdentity | Remove-IntersightComputeRackUnitIdentity

#Remove the server profile by Moid.
Remove-IntersightComputeRackUnitIdentity -Moid 123bc2222287wee
