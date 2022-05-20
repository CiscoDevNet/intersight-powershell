
#Get the IamQualifier to Update
$IamQualifier = Get-IntersightIamQualifier -Name IamQualifierName
$IamQualifier | Set-IntersightIamQualifier -Description 'Updated description'