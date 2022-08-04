
#Get the IamTrustPoint to delete
$IamTrustPoint = Get-IntersightIamTrustPoint -Name IamTrustPointName
$IamTrustPoint | Remove-IntersightIamTrustPoint

#Remove the server profile by Moid.
Remove-IntersightIamTrustPoint -Moid '<Replace with Moid>'
