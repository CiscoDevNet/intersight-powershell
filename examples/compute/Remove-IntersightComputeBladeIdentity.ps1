
#Get the ComputeBladeIdentity to delete
$ComputeBladeIdentity = Remove-IntersightComputeBladeIdentity -Name ComputeBladeIdentityName
$ComputeBladeIdentity | Remove-IntersightComputeBladeIdentity

#Remove the server profile by Moid.
Remove-IntersightComputeBladeIdentity -Moid 123bc2222287wee
