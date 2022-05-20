$account = Get-IntersightIamaccount -Moid '<Replace with Moid>'

$ApplianceBackup = New-IntersightApplianceBackup -Account $account -Filename 'default_filename1' -Protocol 'scp' -RemoteHost 'host.remote' -RemotePath 'path/to/remote/host' -RemotePort 0 -Username 'user_1' -Password 'ChangeMe'
