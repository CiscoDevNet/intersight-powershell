$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$server1 = Get-IntersightComputeRackunit -Moid '<Replace with Moid>'

$server_profile1 = Get-IntersightServerProfile -Moid '<Replace with Moid>'

$server_profile_import1 = New-IntersightServerConfigImport -Organization $organization1 -Server $server1 -ServerProfile $server_profile1 -ProfileName 'server_profile_import1' -Description 'server_profile_import'