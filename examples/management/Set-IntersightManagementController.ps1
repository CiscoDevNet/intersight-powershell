
#Get the ManagementController to Update
$ManagementController = Get-IntersightManagementController -Moid '<Replace with Moid>'

$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$ManagementController | Set-IntersightManagementController -Tags $tags1