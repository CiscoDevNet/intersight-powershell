$account = Get-IntersightIamaccount -Moid '<Replace with Moid>'

$appliance_device_claim1 = New-IntersightApplianceDeviceClaim -Account $account -DeviceId 'WZP23350KMU' -Hostname '10.106.233.221' -Message 'Endpoint claimed successfully' -PlatformType 'IMC' -RequestId '718' -SecurityToken '8707352528DC' -Status 'completed' -Username 'admin'
