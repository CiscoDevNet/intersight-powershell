$account1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$certificates1 = Initialize-IntersightX509Certificate -PemCertificate ''

$iam_trust_point1 = New-IntersightIamTrustPoint -Account $account1 -Certificates $certificates1