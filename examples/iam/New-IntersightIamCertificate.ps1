$certificate1 = Initialize-IntersightX509Certificate -PemCertificate 'var.pemcertificate1'

$iam_certificate1 = New-IntersightIamCertificate -Certificate $certificate1