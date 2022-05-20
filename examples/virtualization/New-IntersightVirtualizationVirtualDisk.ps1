$cluster1 = Get-IntersightVirtualizationIweCluster -Moid '<Replace with Moid>'

$registered_device1 = Get-IntersightAssetDeviceRegistration -Moid '<Replace with Moid>'

$virtualization_virtual_disk1 = New-IntersightVirtualizationVirtualDisk -Cluster $cluster1 -RegisteredDevice $registered_device1 -Name 'vIAjZv26eq' -SourceCerts '<Base64 encoded CA certificates of the https source>' -SourceDiskToClone '<Source disk from which the content is copied>' -Capacity 10