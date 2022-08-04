$host1 = Get-IntersightVirtualizationIweHost -Moid '<Replace with Moid>'

$registered_device1 = Get-IntersightAssetDeviceRegistration -Moid '<Replace with Moid>'

$virtualization_virtual_machine1 = New-IntersightVirtualizationVirtualMachine -Host $host1 -RegisteredDevice $registered_device1 -Name 'virtualization_virtual_machine1' -PowerState 'PowerOn' -ProvisionType 'OVA' -Cpu 16 -Memory 3755356