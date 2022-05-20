$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$mappings1 = Initialize-IntersightVmediaMapping -ClassId 'VmediaMapping' -DeviceType 'cdd' -FileLocation 'infra-chx.auslab.cisco.com/software/linux/ubuntu-18.04.5-server-amd64.iso' -HostName 'infra-chx.auslab.cisco.com' -MountOptions 'RO' -MountProtocol 'nfs' -RemoteFile 'ubuntu-18.04.5-server-amd64.iso' -RemotePath '/iso/software/linux' -VolumeName 'IMC_DVD'

$vmedia1 = New-IntersightVmediaPolicy -Organization $organization -Mappings $mappings1 -Name 'vmedia1' -Description 'demo vmedia policy' -Enabled 1 -Encryption 1 -LowPowerUsb 1