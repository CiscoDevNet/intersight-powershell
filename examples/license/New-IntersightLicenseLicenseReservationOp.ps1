$account1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$license_license_reservation_op1 = New-IntersightLicenseLicenseReservationOp -Account $account1 -GenerateRequestCode 1 -GenerateReturnCode 1