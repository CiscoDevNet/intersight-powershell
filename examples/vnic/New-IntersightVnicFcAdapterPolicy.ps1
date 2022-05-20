$organization = Get-IntersightOrganizationOrganization -Moid '<Replace with Moid>'

$error_recovery_settings1 = Initialize-IntersightVnicFcerrorrecoverysettings -Enabled 0 -IoRetryCount 255 -IoRetryTimeout 50 -LinkDownTimeout 240000 -PortDownTimeout 240000

$flogi_settings1 = Initialize-IntersightVnicFlogisettings -Retries 0 -Timeout 255000

$interrupt_settings1 = Initialize-IntersightVnicFcinterruptsettings -Mode 'MSIx'

$plogi_settings1 = Initialize-IntersightVnicPlogisettings -Retries 255 -Timeout 255000

$rx_queue_settings1 = Initialize-IntersightVnicFcqueuesettings -RingSize 128

$tx_queue_settings1 = Initialize-IntersightVnicFcqueuesettings -RingSize 128

$scsi_queue_settings1 = Initialize-IntersightVnicScsiqueuesettings -Count 8 -RingSize 152

$v_fc_adapter1 = New-IntersightVnicFcAdapterPolicy -Organization $organization -ErrorRecoverySettings $error_recovery_settings1 -FlogiSettings $flogi_settings1 -InterruptSettings $interrupt_settings1 -PlogiSettings $plogi_settings1 -RxQueueSettings $rx_queue_settings1 -TxQueueSettings $tx_queue_settings1 -ScsiQueueSettings $scsi_queue_settings1 -Name 'v_fc_adapter1' -ErrorDetectionTimeout 100000 -IoThrottleCount 1024 -LunCount 1024 -LunQueueDepth 254 -ResourceAllocationTimeout 100000