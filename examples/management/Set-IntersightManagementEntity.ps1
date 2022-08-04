
#Get the ManagementEntity to Update
$ManagementEntity = Get-IntersightManagementEntity -Moid '<Replace with Moid>'

$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$ManagementEntity | Set-IntersightManagementEntity -Tags $tags1