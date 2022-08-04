$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$chassis_config_import1 = New-IntersightChassisConfigImport -Organization $organization1 -Description 'chassis configuration import' -PolicyPrefix 'chassis_policy' -ProfileName 'server_profile_import1'