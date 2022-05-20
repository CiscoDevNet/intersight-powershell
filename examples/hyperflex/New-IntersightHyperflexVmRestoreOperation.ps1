$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$hyperflex_vm_restore_operation1 = New-IntersightHyperflexVmRestoreOperation -Organization $organization1 -NewName 'virtual_machine_1' -PowerOn 1