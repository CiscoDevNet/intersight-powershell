
#Get the IamQualifier to delete
$IamQualifier = Get-IntersightIamQualifier -Name IamQualifierName
$IamQualifier | Remove-IntersightIamQualifier

#Remove the server profile by Moid.
Remove-IntersightIamQualifier -Moid '<Replace with Moid>'
