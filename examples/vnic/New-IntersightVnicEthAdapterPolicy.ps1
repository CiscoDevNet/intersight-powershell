$organization = Get-IntersightOrganizationOrganization -Name 'default'

$vxlan_settings1 = Initialize-IntersightVnicVxlansettings -Enabled 0

$nvgre_settings1 = Initialize-IntersightVnicNvgresettings -Enabled 1

$arfs_settings1 = Initialize-IntersightVnicArfssettings -Enabled 1

$interrupt_settings1 = Initialize-IntersightVnicEthinterruptsettings -CoalescingTime 125 -CoalescingType 'MIN' -Count 4 -Mode 'MSI' 

$completion_queue_settings1 = Initialize-IntersightVnicCompletionqueuesettings -Count 4 

$rx_queue_settings1 = Initialize-IntersightVnicEthrxqueuesettings -Count 4 -RingSize 512 

$tx_queue_settings1 = Initialize-IntersightVnicEthtxqueuesettings -Count  4 -RingSize 512 

$tcp_offload_settings1 = Initialize-IntersightVnicTcpoffloadsettings -LargeReceive 1 -LargeSend 1 -RxChecksum 1 -TxChecksum 1

$v_eth_adapter1 = New-IntersightVnicEthAdapterPolicy -Organization $organization -VxlanSettings $vxlan_settings1 -NvgreSettings $nvgre_settings1 -ArfsSettings $arfs_settings1 -InterruptSettings $interrupt_settings1 -CompletionQueueSettings $completion_queue_settings1 -RxQueueSettings $rx_queue_settings1 -TxQueueSettings $tx_queue_settings1 -TcpOffloadSettings $tcp_offload_settings1 -Name 'v_eth_adapter1' -RssSettings 1 -UplinkFailbackTimeout 5