
#Get the IamTrustPoint to delete
$IamTrustPoint = Remove-IntersightIamTrustPoint -Name IamTrustPointName
$IamTrustPoint | Remove-IntersightIamTrustPoint

#Remove the server profile by Moid.
Remove-IntersightIamTrustPoint -Moid 123bc2222287wee
