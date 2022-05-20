$target_resource1 = Initialize-IntersightTechsupportmanagementTechsupportbundle -ClassId 'TechsupportmanagementTechSupportBundle'

$techsupportmanagement_tech_support_bundle = New-IntersightTechsupportmanagementTechSupportBundle -TargetResource $target_resource1 -PlatformType 'UCSD' -Pid '3' -Serial '4'