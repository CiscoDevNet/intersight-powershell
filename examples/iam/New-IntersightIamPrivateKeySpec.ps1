$certificate_request1 = Get-IntersightIamCertificaterequest -Moid '<Replace with Moid>'

$iam_private_key_spec1 = New-IntersightIamPrivateKeySpec -CertificateRequest $certificate_request1