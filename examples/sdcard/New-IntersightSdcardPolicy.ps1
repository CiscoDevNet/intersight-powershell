$organization1 = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$virtual_drives = Initialize-IntersightSdcardOperatingSystem -Enable 1

$partitions1 = Initialize-IntersightSdcardPartition -Type 'OS' -VirtualDrives $virtual_drives 

$sdcard1 = New-IntersightSdcardPolicy -Organization $organization1 -Partitions $partitions1 -Name 'sdcard1' -Description 'demo sd card policy'