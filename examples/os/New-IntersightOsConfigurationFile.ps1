$catalog1 = Get-IntersightOsCatalog -Moid '<Replace with Moid>'

$distributions1 = Get-IntersightHclOperatingsystem -Moid '<Replace with Moid>'

$os_configuration_file1 = New-IntersightOsConfigurationFile -Catalog $catalog1 -Distributions $distributions1 -Name 'os_configuration_file1'