$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$chassis_config_import1 = New-IntersightChassisConfigImport -Organization $organization1 -Description 'chassis configuration import' -PolicyPrefix 'chassis_policy' -ProfileName 'server_profile_import1'