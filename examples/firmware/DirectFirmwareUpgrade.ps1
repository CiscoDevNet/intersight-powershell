# Uncomment the following script and provide the below information to set up Intersight environment.
<#
    $intersightEnv = @{
    BasePath = if ($env:INTERSIGHT_ENDPOINT) { $env:INTERSIGHT_ENDPOINT } else { "https://intersight.com" }
    ApiKeyId = "xxxxxxxxxxxxxxxxxx/xxxxxxxxxxxxxxxx/xxxxxxxxxxxxxxxxxx"
    ApiKeyFilePath = "C:\\Users\\admin\\Downloads\\ProductionSecretKey.txt" 
    HttpSigningHeader =  @("(request-target)", "Host", "Date", "Digest")
}

Set-IntersightConfiguration @intersightEnv
#>

# Initialize the NFS server source pointing to the HUU firmware ISO file.
$NfsSource = Initialize-IntersightSoftwarerepositoryNfsServer -FileLocation "10.xx.xx.xx/shared/ucsc-845a-m8-huu-2.0.1.250000D.iso" -ObjectType "SoftwarerepositoryNfsServer"

# Retrieve the organization under which the firmware distributable will be created.
$Organization = Get-IntersightOrganizationOrganization -Name "test_new_org"

# Retrieve the user's software repository catalog scoped to the organization.
$Catalog = Get-IntersightSoftwarerepositoryCatalog -Name "user-catalog" -Organization $Organization

# Create a new firmware distributable entry in the catalog with the NFS source.
$FirmwareDistributable = New-IntersightFirmwareDistributable -Name "ucsc-845a-m8-huu-2.0.1.250000D" -ImportAction "None" -SupportedModels @("CAI-845A-M8") -Version "-" -Origin "User" -Source $NfsSource -Catalog $Catalog

# Update the firmware distributable with the correct version info and description.
$UpdatedFirmwareDistributable = $FirmwareDistributable | Set-IntersightFirmwareDistributable -Source $NfsSource -Version "2.0(1.250000D)" -Catalog $Catalog -Name "ucsc-845a-m8-huu-2.0.1.250000D" -SupportedModels @("CAI-845A-M8") -Description "invalid CIFS image"

# Initialize direct download and network share options for the firmware upgrade.
$DirectDownload = Initialize-IntersightFirmwareDirectDownload -ObjectType "FirmwareDirectDownload"
$NetworkShare = Initialize-IntersightFirmwareNetworkShare -Upgradeoption "NwUpgradeFull" -MapType "Nfs" -ObjectType "FirmwareNetworkShare"

# Retrieve the target rack server to upgrade by name. Replace with your server's name.
$Server = Get-IntersightComputeRackUnit -Name "RackServer-3"

# Trigger the firmware upgrade on the server using the network share method.
$FirmwareUpgrade = New-IntersightFirmwareUpgrade -UpgradeType "NetworkUpgrade" -Distributable $UpdatedFirmwareDistributable -DirectDownload $DirectDownload -NetworkShare $NetworkShare -Server $Server -ExcludeComponentList @()