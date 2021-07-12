
#Get the IamQualifier to delete
$IamQualifier = Remove-IntersightIamQualifier -Name IamQualifierName
$IamQualifier | Remove-IntersightIamQualifier

#Remove the server profile by Moid.
Remove-IntersightIamQualifier -Moid 123bc2222287wee
