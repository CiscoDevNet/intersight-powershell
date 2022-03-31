# This example clones the ServerProfile which already created Named "test_server_profile"

$sourceServerProfile = Get-IntersightServerProfile -Name test_server_profile

$orgRef = Get-IntersightOrganizationOrganization -Name default

$targetProfile = Initialize-IntersightServerProfile -Name cloned_serer_profile -Description "cloned from test_server_profile" -Organization $orgRef

$result = New-IntersightBulkMoCloner -Sources $sourceServerProfile -Targets $targetProfile