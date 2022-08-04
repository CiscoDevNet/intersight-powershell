$account1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$features1 = Initialize-IntersightIamFeaturedefinition -Feature IWE

$parent1 = Get-IntersightIamAccount -Moid '<Replace with Moid>'

$iam_account_experience1 = New-IntersightIamAccountExperience -Account $account1 -Features $features1 -Parent $parent1