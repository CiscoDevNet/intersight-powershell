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

# Retrieve the target rack server by name. Replace with your server's name.
$Server = Get-IntersightComputeRackUnit -Name "RackServer-1"

# Validate the server as a supported OS install target.
$ValidInstallTarget = New-IntersightOsValidInstallTarget -Servers @($Server)

# Check if the desired OS version is supported.
$OsSupport = New-IntersightOsOsSupport -OsVersion "ESXi 8.0"

# Retrieve the user's organization under which the OS install will be performed.
# Replace "Org-Auto-8332" with your own organization name.
$Organization = Get-IntersightOrganizationOrganization -Name "Org-Auto-8332"

# Retrieve the user's software repository catalog scoped to the organization.
$Catalog = Get-IntersightSoftwarerepositoryCatalog -Name "user-catalog" -Organization $Organization

# Retrieve the OS image and SCU (Server Configuration Utility) image from the catalog.
$OsImage = Get-IntersightSoftwarerepositoryOperatingSystemFile -Name "Esxi80u2_embedded" -Catalog $Catalog
$ScuImage = Get-IntersightFirmwareServerConfigurationUtilityDistributable -Name "ucsxe-scu-7.1.7.260010.iso" -Catalog $Catalog

# Configure the IPv4 network settings for the OS installation.
$IpV4Config = Initialize-IntersightCommIpV4Interface -ObjectType "CommIpV4Interface" -Gateway "" -IpAddress "" -Netmask ""
$IpConfiguration = Initialize-IntersightOsIpv4Configuration -ObjectType "OsIpv4Configuration" -IpV4Config $IpV4Config

# Set up the OS install answers including hostname, IP config type, and root password.
$Answers = Initialize-IntersightOsAnswers -ObjectType "OsAnswers" -Hostname "google" -IpConfigType "DHCP" -IpConfiguration $IpConfiguration -IsRootPasswordCrypted $false -Nameserver "" -NetworkDevice "" -ProductKey "" -Source "Template" -RootPassword "123456"

# Retrieve the organization that owns the "shared" OS catalog containing system-provided configuration files.
# NOTE: The Moid below is specific to this Intersight account and will NOT work in other environments.
# Replace it with your own organization's Moid, or use -Name to look up by name instead.
$SharedOrganization = Get-IntersightOrganizationOrganization -Moid "5da9f0b76972652d30b3bae7"
if ($SharedOrganization) {
    $SharedCatalog = Get-IntersightOsCatalog -Name "shared" -Organization $SharedOrganization
} else {
    $SharedCatalog = Get-IntersightOsCatalog -Name "shared"
}

# Retrieve the OS configuration file (kickstart/autoinstall template) from the shared catalog.
$ConfigurationFile = Get-IntersightOsConfigurationFile -Name "ESXi8.0ConfigFile" -Catalog $SharedCatalog

# Define the physical disk install target with disk name, serial number, and storage controller slot.
$InstallTarget = Initialize-IntersightOsPhysicalDisk -ObjectType "OsPhysicalDisk" -Name "Disk 1" -SerialNumber "W0K40V960000K141L1Z5" -StorageControllerSlotId "MRAID"

# Build the OS install request body with all the configuration gathered above.
$OsInstallBody = Initialize-IntersightOsInstall -Description "" -InstallMethod "VMedia" -Image $OsImage -OsduImage $ScuImage -OverrideSecureBoot $true -Organization $Organization -Answers $Answers -ConfigurationFile $ConfigurationFile -InstallTarget $InstallTarget -Server $Server

# Wrap the install request as a bulk REST sub-request and submit it via the Bulk API.
$BulkSubRequest = Initialize-IntersightBulkRestSubRequest -ObjectType "BulkRestSubRequest" -Body $OsInstallBody
$BulkInstallRequest = New-IntersightBulkRequest -Verb "POST" -Uri "/v1/os/Installs" -Requests @($BulkSubRequest)