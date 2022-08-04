
#Get the IamTrustPoint to Update
$IamTrustPoint = Get-IntersightIamTrustPoint -Name IamTrustPointName
$IamTrustPoint | Set-IntersightIamTrustPoint -Description 'Updated description'