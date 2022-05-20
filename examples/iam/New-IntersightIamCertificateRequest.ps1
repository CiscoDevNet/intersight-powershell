$account1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$certificate1 = Get-IntersightX509Certificate -Moid '<Replace with Moid>'

$iam_certificate_request1 = New-IntersightIamCertificateRequest -Account $account1 -Certificate $certificate1 -EmailAddress 'email@example.com' -Name 'iam_certificate_request1' -SelfSigned 0