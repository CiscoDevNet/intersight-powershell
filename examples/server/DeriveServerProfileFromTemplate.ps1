
$source = Get-IntersightServerProfileTemplate -Name "server_template"

$orgRef = Get-IntersightOrganizationOrganization -Name default

$targetProfile = Initialize-IntersightServerProfile -Name cloned-server-profile -Description "cloned from template" -Organization (Get-IntersightMoMoRef -ManagedObject ($orgRef))

New-IntersightBulkMoCloner -Sources $source -Targets $targetProfile