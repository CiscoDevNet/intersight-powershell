$account1 = Get-IntersightIamaccount -Moid '<Replace with Moid>'

$appliance_restore1 = New-IntersightApplianceRestore -Account $account1 -Filename 'name_of_the_file.txt' -Protocol 'SFTP' -RemoteHost 'appliance-remote.hostname.com' -RemotePath 'path/to/the/remote/host' -RemotePort 22 -Username 'authenicate_user' -Password 'ChangeMe' 