$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$kubernetes_virtual_machine_instance_type1 = New-IntersightKubernetesVirtualMachineInstanceType -Organization $organization1 -Description 'kubernetes virtual machine instance type' -Name 'kubernetes_virtual_machine_instance_type1' -Cpu 4 -DiskSize 10 -Memory 4096