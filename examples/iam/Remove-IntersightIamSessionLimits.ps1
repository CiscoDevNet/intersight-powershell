
#Get the IamSessionLimits to delete
$IamSessionLimits = Remove-IntersightIamSessionLimits -Name IamSessionLimitsName
$IamSessionLimits | Remove-IntersightIamSessionLimits

#Remove the server profile by Moid.
Remove-IntersightIamSessionLimits -Moid 123bc2222287wee
