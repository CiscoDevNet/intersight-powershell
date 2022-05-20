
#Get the IamSessionLimits to delete
$IamSessionLimits = Get-IntersightIamSessionLimits -Name IamSessionLimitsName
$IamSessionLimits | Remove-IntersightIamSessionLimits

#Remove the server profile by Moid.
Remove-IntersightIamSessionLimits -Moid '<Replace with Moid>'
