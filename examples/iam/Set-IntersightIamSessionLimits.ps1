
#Get the IamSessionLimits to Update
$IamSessionLimits = Get-IntersightIamSessionLimits -Name IamSessionLimitsName
$IamSessionLimits | Set-IntersightIamSessionLimits -Description 'Updated description'