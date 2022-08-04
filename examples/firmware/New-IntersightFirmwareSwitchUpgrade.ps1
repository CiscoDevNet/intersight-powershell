$direct_download1 = Initialize-IntersightFirmwareDirectdownload -ImageSource 'cisco' -Password 'ChangeMe' -Upgradeoption ChassisUpgradeFull -Username 'admin1'

$cifs_server1 = Initialize-IntersightFirmwareCifsServer -FileLocation '10.1.1.1' -MountOptions None

$network_share1 = Initialize-IntersightFirmwareNetworkshare -CifsServer $cifs_server1 -MapType 'cifs' -Upgradeoption NwUpgradeFull -Username 'admin1'

$firmware_switch_upgrade1 = New-IntersightFirmwareSwitchUpgrade -DirectDownload $direct_download1 -NetworkShare $network_share1 -SkipEstimateImpact 0 -Status 'SUCCESSFUL' -UpgradeType NetworkUpgrade