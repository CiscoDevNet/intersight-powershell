$account = Get-IntersightIamaccount -Name 'admin'

$schedule = Initialize-IntersightOnpremSchedule -TimeZone "PacificNiue" -DayOfMonth 1 -DayOfWeek 1 -MonthOfYear 1 -RepeatInterval 0 -TimeOfDay 0 -WeekOfMonth 1

$ApplianceBackupPolicy = New-IntersightApplianceBackupPolicy -Schedule $schedule -Account $account -Filename 'default_filename1' -Protocol 'scp' -RemoteHost 'host.remote' -RemotePath 'path/to/remote/host' -RemotePort 0 -Username 'user_1' -ManualBackup 1
