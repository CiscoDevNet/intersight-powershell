$spandrives = Initialize-IntersightStorageSpanDrives -Slots 2

$manual_drive_group1 = Initialize-IntersightStorageManualdrivegroup -SpanGroups $spandrives

$storage_policy1 = Get-IntersightStorageStoragepolicy -Moid '<Replace with Moid>'

$virtualpolicy1 = Initialize-IntersightStorageVirtualDrivePolicy -StripSize 64 -WritePolicy 'Default' -ReadPolicy 'Default' -AccessPolicy 'Default' -DriveCache 'Default'

$virtual_drives1 = Initialize-IntersightStorageVirtualdriveconfiguration -Name 'tf_drive_gp-vd' -Size 100 -ExpandToAvailable 0 -BootDrive 0 -VirtualDrivePolicy $virtualpolicy1

$virtualpolicy2 = Initialize-IntersightStorageVirtualDrivePolicy -StripSize 64 -WritePolicy 'Default' -ReadPolicy 'Default' -AccessPolicy 'Default' -DriveCache 'Default'

$virtual_drives2 = Initialize-IntersightStorageVirtualdriveconfiguration -Name 'drive_gp-vd-01' -Size 100 -ExpandToAvailable 0 -BootDrive 0 -VirtualDrivePolicy $virtualpolicy2

$tf_drive_gp = New-IntersightStorageDriveGroup -ManualDriveGroup $manual_drive_group1 -StoragePolicy $storage_policy1 -VirtualDrives @($virtual_drives1,$virtual_drives2) -Name 'tf_drive_gp' -RaidLevel 'Raid0'