$config_context1 = Initialize-IntersightPolicyConfigcontext -ControlAction 'deploy' -ErrorState 'Validation-error'

$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$chassis_profile1 = New-IntersightChassisProfile -ConfigContext $config_context1 -Organization $organization1 -Name 'chassis_profile1' -Description 'chassis profile' -Type 'instance' -TargetPlatform 'FIAttached' -Action 'Validate'