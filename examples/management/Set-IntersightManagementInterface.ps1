
#Get the ManagementInterface to Update
$ManagementInterface = Get-IntersightManagementInterface -Moid '<Replace with Moid>'

$tags1 = Initialize-IntersightMoTag -Key "key" -Value "value"
$ManagementInterface | Set-IntersightManagementInterface -Tags $tags1