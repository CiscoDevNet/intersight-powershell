#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2021-02-05T15:05:56Z.
# Version: 1.0.9-3562
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

A reference to a REST resource, uniquely identified by object type and Moid.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the remote type referred by this relationship.
.PARAMETER Link
A URL to an instance of the 'mo.MoRef' class.
.OUTPUTS

MoMoRef<PSCustomObject>
#>

function Initialize-IntersightMoMoRef {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("mo.MoRef")]
        [String]
        ${ClassId} = "mo.MoRef",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("aaa.AuditRecord", "access.Policy", "adapter.ConfigPolicy", "adapter.ExtEthInterface", "adapter.HostEthInterface", "adapter.HostFcInterface", "adapter.HostIscsiInterface", "adapter.Unit", "appliance.AppStatus", "appliance.Backup", "appliance.BackupPolicy", "appliance.CertificateSetting", "appliance.DataExportPolicy", "appliance.DeviceCertificate", "appliance.DeviceClaim", "appliance.DiagSetting", "appliance.ExternalSyslogSetting", "appliance.FileSystemStatus", "appliance.GroupStatus", "appliance.ImageBundle", "appliance.NodeInfo", "appliance.NodeStatus", "appliance.ReleaseNote", "appliance.Restore", "appliance.SetupInfo", "appliance.SystemInfo", "appliance.SystemStatus", "appliance.Upgrade", "appliance.UpgradePolicy", "asset.ClusterMember", "asset.DeviceClaim", "asset.DeviceConfiguration", "asset.DeviceConnectorManager", "asset.DeviceContractInformation", "asset.DeviceRegistration", "asset.SubscriptionDeviceContractInformation", "asset.Target", "bios.BootDevice", "bios.BootMode", "bios.Policy", "bios.SystemBootOrder", "bios.Unit", "boot.CddDevice", "boot.DeviceBootMode", "boot.DeviceBootSecurity", "boot.HddDevice", "boot.IscsiDevice", "boot.NvmeDevice", "boot.PchStorageDevice", "boot.PrecisionPolicy", "boot.PxeDevice", "boot.SanDevice", "boot.SdDevice", "boot.UefiShellDevice", "boot.UsbDevice", "boot.VmediaDevice", "capability.AdapterUnitDescriptor", "capability.Catalog", "capability.ChassisDescriptor", "capability.ChassisManufacturingDef", "capability.CimcFirmwareDescriptor", "capability.EquipmentPhysicalDef", "capability.EquipmentSlotArray", "capability.FanModuleDescriptor", "capability.FanModuleManufacturingDef", "capability.IoCardCapabilityDef", "capability.IoCardDescriptor", "capability.IoCardManufacturingDef", "capability.PortGroupAggregationDef", "capability.PsuDescriptor", "capability.PsuManufacturingDef", "capability.SiocModuleCapabilityDef", "capability.SiocModuleDescriptor", "capability.SiocModuleManufacturingDef", "capability.SwitchCapability", "capability.SwitchDescriptor", "capability.SwitchManufacturingDef", "chassis.ConfigChangeDetail", "chassis.ConfigImport", "chassis.ConfigResult", "chassis.ConfigResultEntry", "chassis.IomProfile", "chassis.Profile", "comm.HttpProxyPolicy", "compute.Blade", "compute.BladeIdentity", "compute.Board", "compute.PhysicalSummary", "compute.RackUnit", "compute.RackUnitIdentity", "compute.ServerSetting", "compute.Vmedia", "cond.Alarm", "cond.AlarmAggregation", "cond.HclStatus", "cond.HclStatusDetail", "cond.HclStatusJob", "config.ExportedItem", "config.Exporter", "config.ImportedItem", "config.Importer", "connectorpack.ConnectorPackUpgrade", "connectorpack.UpgradeImpact", "deviceconnector.Policy", "equipment.Chassis", "equipment.ChassisIdentity", "equipment.ChassisOperation", "equipment.DeviceSummary", "equipment.Fan", "equipment.FanModule", "equipment.Fex", "equipment.FexIdentity", "equipment.FexOperation", "equipment.IdentitySummary", "equipment.IoCard", "equipment.IoCardOperation", "equipment.IoExpander", "equipment.LocatorLed", "equipment.Psu", "equipment.PsuControl", "equipment.RackEnclosure", "equipment.RackEnclosureSlot", "equipment.SharedIoModule", "equipment.SwitchCard", "equipment.SystemIoController", "equipment.Tpm", "equipment.Transceiver", "ether.HostPort", "ether.NetworkPort", "ether.PhysicalPort", "ether.PortChannel", "externalsite.Authorization", "fabric.AppliancePcRole", "fabric.ApplianceRole", "fabric.ConfigChangeDetail", "fabric.ConfigResult", "fabric.ConfigResultEntry", "fabric.EstimateImpact", "fabric.EthNetworkControlPolicy", "fabric.EthNetworkGroupPolicy", "fabric.EthNetworkPolicy", "fabric.FcNetworkPolicy", "fabric.FcUplinkPcRole", "fabric.FcUplinkRole", "fabric.FcoeUplinkPcRole", "fabric.FcoeUplinkRole", "fabric.MulticastPolicy", "fabric.PcMember", "fabric.PcOperation", "fabric.PortMode", "fabric.PortOperation", "fabric.PortPolicy", "fabric.ServerRole", "fabric.SwitchClusterProfile", "fabric.SwitchControlPolicy", "fabric.SwitchProfile", "fabric.SystemQosPolicy", "fabric.UplinkPcRole", "fabric.UplinkRole", "fabric.Vlan", "fabric.Vsan", "fault.Instance", "fc.PhysicalPort", "fc.PortChannel", "fcpool.FcBlock", "fcpool.Lease", "fcpool.Pool", "fcpool.PoolMember", "fcpool.Universe", "feedback.FeedbackPost", "firmware.BiosDescriptor", "firmware.BoardControllerDescriptor", "firmware.ChassisUpgrade", "firmware.CimcDescriptor", "firmware.DimmDescriptor", "firmware.Distributable", "firmware.DistributableMeta", "firmware.DriveDescriptor", "firmware.DriverDistributable", "firmware.Eula", "firmware.FirmwareSummary", "firmware.GpuDescriptor", "firmware.HbaDescriptor", "firmware.IomDescriptor", "firmware.MswitchDescriptor", "firmware.NxosDescriptor", "firmware.PcieDescriptor", "firmware.PsuDescriptor", "firmware.RunningFirmware", "firmware.SasExpanderDescriptor", "firmware.ServerConfigurationUtilityDistributable", "firmware.StorageControllerDescriptor", "firmware.SwitchUpgrade", "firmware.UnsupportedVersionUpgrade", "firmware.Upgrade", "firmware.UpgradeImpact", "firmware.UpgradeImpactStatus", "firmware.UpgradeStatus", "forecast.Catalog", "forecast.Definition", "forecast.Instance", "graphics.Card", "graphics.Controller", "hcl.CompatibilityStatus", "hcl.DriverImage", "hcl.ExemptedCatalog", "hcl.HyperflexSoftwareCompatibilityInfo", "hcl.OperatingSystem", "hcl.OperatingSystemVendor", "hcl.SupportedDriverName", "hyperflex.Alarm", "hyperflex.AppCatalog", "hyperflex.AutoSupportPolicy", "hyperflex.BackupCluster", "hyperflex.CapabilityInfo", "hyperflex.CiscoHypervisorManager", "hyperflex.Cluster", "hyperflex.ClusterBackupPolicy", "hyperflex.ClusterBackupPolicyDeployment", "hyperflex.ClusterHealthCheckExecutionSnapshot", "hyperflex.ClusterNetworkPolicy", "hyperflex.ClusterProfile", "hyperflex.ClusterReplicationNetworkPolicy", "hyperflex.ClusterReplicationNetworkPolicyDeployment", "hyperflex.ClusterStoragePolicy", "hyperflex.ConfigResult", "hyperflex.ConfigResultEntry", "hyperflex.DevicePackageDownloadState", "hyperflex.ExtFcStoragePolicy", "hyperflex.ExtIscsiStoragePolicy", "hyperflex.FeatureLimitExternal", "hyperflex.FeatureLimitInternal", "hyperflex.Health", "hyperflex.HealthCheckDefinition", "hyperflex.HealthCheckExecution", "hyperflex.HealthCheckExecutionSnapshot", "hyperflex.HealthCheckPackageChecksum", "hyperflex.HxapCluster", "hyperflex.HxapDatacenter", "hyperflex.HxapEvent", "hyperflex.HxapHost", "hyperflex.HxapVirtualDisk", "hyperflex.HxapVirtualMachine", "hyperflex.HxdpVersion", "hyperflex.LocalCredentialPolicy", "hyperflex.Node", "hyperflex.NodeConfigPolicy", "hyperflex.NodeProfile", "hyperflex.ProxySettingPolicy", "hyperflex.ServerFirmwareVersion", "hyperflex.ServerFirmwareVersionEntry", "hyperflex.ServerModel", "hyperflex.SoftwareVersionPolicy", "hyperflex.SysConfigPolicy", "hyperflex.UcsmConfigPolicy", "hyperflex.VcenterConfigPolicy", "hyperflex.VmBackupInfo", "hyperflex.VmRestoreOperation", "hyperflex.VmSnapshotInfo", "iaas.ConnectorPack", "iaas.DeviceStatus", "iaas.DiagnosticMessages", "iaas.LicenseInfo", "iaas.MostRunTasks", "iaas.ServiceRequest", "iaas.UcsdInfo", "iaas.UcsdManagedInfra", "iaas.UcsdMessages", "iam.Account", "iam.AccountExperience", "iam.ApiKey", "iam.AppRegistration", "iam.BannerMessage", "iam.Certificate", "iam.CertificateRequest", "iam.DomainGroup", "iam.EndPointPrivilege", "iam.EndPointRole", "iam.EndPointUser", "iam.EndPointUserPolicy", "iam.EndPointUserRole", "iam.Idp", "iam.IdpReference", "iam.IpAccessManagement", "iam.IpAddress", "iam.LdapGroup", "iam.LdapPolicy", "iam.LdapProvider", "iam.LocalUserPassword", "iam.LocalUserPasswordPolicy", "iam.OAuthToken", "iam.Permission", "iam.PrivateKeySpec", "iam.Privilege", "iam.PrivilegeSet", "iam.Qualifier", "iam.ResourceLimits", "iam.ResourcePermission", "iam.ResourceRoles", "iam.Role", "iam.SecurityHolder", "iam.ServiceProvider", "iam.Session", "iam.SessionLimits", "iam.System", "iam.TrustPoint", "iam.User", "iam.UserGroup", "iam.UserPreference", "inventory.DeviceInfo", "inventory.DnMoBinding", "inventory.GenericInventory", "inventory.GenericInventoryHolder", "inventory.Request", "ipmioverlan.Policy", "ippool.BlockLease", "ippool.IpLease", "ippool.Pool", "ippool.PoolMember", "ippool.ShadowBlock", "ippool.ShadowPool", "ippool.Universe", "iqnpool.Block", "iqnpool.Lease", "iqnpool.Pool", "iqnpool.PoolMember", "iqnpool.Universe", "iwotenant.TenantStatus", "kubernetes.AciCniApic", "kubernetes.AciCniProfile", "kubernetes.AciCniTenantClusterAllocation", "kubernetes.Addon", "kubernetes.AddonDefinition", "kubernetes.AddonPolicy", "kubernetes.AddonRepository", "kubernetes.Catalog", "kubernetes.Cluster", "kubernetes.ClusterProfile", "kubernetes.ContainerRuntimePolicy", "kubernetes.DaemonSet", "kubernetes.Deployment", "kubernetes.Ingress", "kubernetes.NetworkPolicy", "kubernetes.Node", "kubernetes.NodeGroupProfile", "kubernetes.Pod", "kubernetes.Service", "kubernetes.StatefulSet", "kubernetes.SysConfigPolicy", "kubernetes.TrustedRegistriesPolicy", "kubernetes.Version", "kubernetes.VersionPolicy", "kubernetes.VirtualMachineInfrastructureProvider", "kubernetes.VirtualMachineInstanceType", "kubernetes.VirtualMachineNodeProfile", "kvm.Policy", "kvm.Session", "kvm.Tunnel", "kvm.VmConsole", "license.AccountLicenseData", "license.CustomerOp", "license.IwoCustomerOp", "license.IwoLicenseCount", "license.LicenseInfo", "license.LicenseReservationOp", "license.SmartlicenseToken", "ls.ServiceProfile", "macpool.IdBlock", "macpool.Lease", "macpool.Pool", "macpool.PoolMember", "macpool.Universe", "management.Controller", "management.Entity", "management.Interface", "memory.Array", "memory.PersistentMemoryConfigResult", "memory.PersistentMemoryConfiguration", "memory.PersistentMemoryNamespace", "memory.PersistentMemoryNamespaceConfigResult", "memory.PersistentMemoryPolicy", "memory.PersistentMemoryRegion", "memory.PersistentMemoryUnit", "memory.Unit", "meta.Definition", "network.Element", "network.ElementSummary", "network.FcZoneInfo", "network.VlanPortInfo", "networkconfig.Policy", "niaapi.ApicCcoPost", "niaapi.ApicFieldNotice", "niaapi.ApicHweol", "niaapi.ApicLatestMaintainedRelease", "niaapi.ApicReleaseRecommend", "niaapi.ApicSweol", "niaapi.DcnmCcoPost", "niaapi.DcnmFieldNotice", "niaapi.DcnmHweol", "niaapi.DcnmLatestMaintainedRelease", "niaapi.DcnmReleaseRecommend", "niaapi.DcnmSweol", "niaapi.FileDownloader", "niaapi.NiaMetadata", "niaapi.NibFileDownloader", "niaapi.NibMetadata", "niaapi.VersionRegex", "niatelemetry.ApicFanDetails", "niatelemetry.ApicFexDetails", "niatelemetry.ApicPsuDetails", "niatelemetry.ApicUiPageCounts", "niatelemetry.AppDetails", "niatelemetry.Epg", "niatelemetry.Fault", "niatelemetry.Lc", "niatelemetry.MsoSchemaDetails", "niatelemetry.MsoSiteDetails", "niatelemetry.MsoTenantDetails", "niatelemetry.NexusDashboardControllerDetails", "niatelemetry.NexusDashboardDetails", "niatelemetry.NexusDashboardMemoryDetails", "niatelemetry.NexusDashboards", "niatelemetry.NiaFeatureUsage", "niatelemetry.NiaInventory", "niatelemetry.NiaInventoryDcnm", "niatelemetry.NiaInventoryFabric", "niatelemetry.NiaLicenseState", "niatelemetry.Tenant", "ntp.Policy", "organization.Organization", "os.Catalog", "os.ConfigurationFile", "os.Distribution", "os.Install", "os.OsSupport", "os.SupportedVersion", "os.TemplateFile", "os.ValidInstallTarget", "pci.CoprocessorCard", "pci.Device", "pci.Link", "pci.Switch", "port.Group", "port.MacBinding", "port.SubGroup", "processor.Unit", "recommendation.CapacityRunway", "recommendation.PhysicalItem", "recovery.BackupConfigPolicy", "recovery.BackupProfile", "recovery.ConfigResult", "recovery.ConfigResultEntry", "recovery.OnDemandBackup", "recovery.Restore", "recovery.ScheduleConfigPolicy", "resource.Group", "resource.GroupMember", "resource.LicenseResourceCount", "resource.Membership", "resource.MembershipHolder", "sdcard.Policy", "sdwan.Profile", "sdwan.RouterNode", "sdwan.RouterPolicy", "sdwan.VmanageAccountPolicy", "search.SearchItem", "search.SuggestItem", "search.TagItem", "security.Unit", "server.ConfigChangeDetail", "server.ConfigImport", "server.ConfigResult", "server.ConfigResultEntry", "server.Profile", "smtp.Policy", "snmp.Policy", "software.ApplianceDistributable", "software.HclMeta", "software.HyperflexBundleDistributable", "software.HyperflexDistributable", "software.SolutionDistributable", "software.UcsdBundleDistributable", "software.UcsdDistributable", "softwarerepository.Authorization", "softwarerepository.CachedImage", "softwarerepository.Catalog", "softwarerepository.CategoryMapper", "softwarerepository.CategoryMapperModel", "softwarerepository.CategorySupportConstraint", "softwarerepository.DownloadSpec", "softwarerepository.OperatingSystemFile", "softwarerepository.Release", "sol.Policy", "ssh.Policy", "storage.Controller", "storage.DiskGroup", "storage.DiskGroupPolicy", "storage.Enclosure", "storage.EnclosureDisk", "storage.EnclosureDiskSlotEp", "storage.FlexFlashController", "storage.FlexFlashControllerProps", "storage.FlexFlashPhysicalDrive", "storage.FlexFlashVirtualDrive", "storage.FlexUtilController", "storage.FlexUtilPhysicalDrive", "storage.FlexUtilVirtualDrive", "storage.HitachiArray", "storage.HitachiController", "storage.HitachiDisk", "storage.HitachiHost", "storage.HitachiHostLun", "storage.HitachiParityGroup", "storage.HitachiPool", "storage.HitachiPort", "storage.HitachiVolume", "storage.HyperFlexStorageContainer", "storage.HyperFlexVolume", "storage.Item", "storage.NetAppAggregate", "storage.NetAppBaseDisk", "storage.NetAppCluster", "storage.NetAppEthernetPort", "storage.NetAppExportPolicy", "storage.NetAppFcInterface", "storage.NetAppFcPort", "storage.NetAppInitiatorGroup", "storage.NetAppIpInterface", "storage.NetAppLicense", "storage.NetAppLun", "storage.NetAppLunMap", "storage.NetAppNode", "storage.NetAppStorageVm", "storage.NetAppVolume", "storage.NetAppVolumeSnapshot", "storage.PhysicalDisk", "storage.PhysicalDiskExtension", "storage.PhysicalDiskUsage", "storage.PureArray", "storage.PureController", "storage.PureDisk", "storage.PureHost", "storage.PureHostGroup", "storage.PureHostLun", "storage.PurePort", "storage.PureProtectionGroup", "storage.PureProtectionGroupSnapshot", "storage.PureReplicationSchedule", "storage.PureSnapshotSchedule", "storage.PureVolume", "storage.PureVolumeSnapshot", "storage.SasExpander", "storage.SasPort", "storage.Span", "storage.StoragePolicy", "storage.VdMemberEp", "storage.VirtualDrive", "storage.VirtualDriveContainer", "storage.VirtualDriveExtension", "syslog.Policy", "tam.AdvisoryCount", "tam.AdvisoryDefinition", "tam.AdvisoryInfo", "tam.AdvisoryInstance", "tam.SecurityAdvisory", "task.HitachiScopedInventory", "task.NetAppScopedInventory", "task.PureScopedInventory", "techsupportmanagement.CollectionControlPolicy", "techsupportmanagement.Download", "techsupportmanagement.TechSupportBundle", "techsupportmanagement.TechSupportStatus", "terminal.AuditLog", "top.System", "ucsd.BackupInfo", "uuidpool.Block", "uuidpool.Pool", "uuidpool.PoolMember", "uuidpool.Universe", "uuidpool.UuidLease", "virtualization.Host", "virtualization.VirtualDisk", "virtualization.VirtualMachine", "virtualization.VmwareCluster", "virtualization.VmwareDatacenter", "virtualization.VmwareDatastore", "virtualization.VmwareHost", "virtualization.VmwareVcenter", "virtualization.VmwareVirtualMachine", "vmedia.Policy", "vmrc.Console", "vnic.EthAdapterPolicy", "vnic.EthIf", "vnic.EthNetworkPolicy", "vnic.EthQosPolicy", "vnic.FcAdapterPolicy", "vnic.FcIf", "vnic.FcNetworkPolicy", "vnic.FcQosPolicy", "vnic.IscsiAdapterPolicy", "vnic.IscsiBootPolicy", "vnic.IscsiStaticTargetPolicy", "vnic.LanConnectivityPolicy", "vnic.LcpStatus", "vnic.SanConnectivityPolicy", "vnic.ScpStatus", "vrf.Vrf", "workflow.BatchApiExecutor", "workflow.BuildTaskMeta", "workflow.BuildTaskMetaOwner", "workflow.Catalog", "workflow.CustomDataTypeDefinition", "workflow.ErrorResponseHandler", "workflow.PendingDynamicWorkflowInfo", "workflow.RollbackWorkflow", "workflow.TaskDefinition", "workflow.TaskInfo", "workflow.TaskMetadata", "workflow.WorkflowDefinition", "workflow.WorkflowInfo", "workflow.WorkflowMeta", "workflow.WorkflowMetadata")]
        [String]
        ${ObjectType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Link}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightMoMoRef' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "link" = ${Link}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to MoMoRef<PSCustomObject>

.DESCRIPTION

Convert from JSON to MoMoRef<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

MoMoRef<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToMoMoRef {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightMoMoRef' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightMoMoRef
        $AllProperties = ("ClassId", "ObjectType", "Moid", "Selector", "link")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property 'ClassId' missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassId"))) {
            throw "Error! JSON cannot be serialized due to the required property 'ClassId' missing."
        } else {
            $ClassId = $JsonParameters.PSobject.Properties["ClassId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) {
            throw "Error! JSON cannot be serialized due to the required property 'ObjectType' missing."
        } else {
            $ObjectType = $JsonParameters.PSobject.Properties["ObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Moid"))) { #optional property not found
            $Moid = $null
        } else {
            $Moid = $JsonParameters.PSobject.Properties["Moid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Selector"))) { #optional property not found
            $Selector = $null
        } else {
            $Selector = $JsonParameters.PSobject.Properties["Selector"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "link"))) { #optional property not found
            $Link = $null
        } else {
            $Link = $JsonParameters.PSobject.Properties["link"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Moid" = ${Moid}
            "Selector" = ${Selector}
            "link" = ${Link}
        }

        return $PSO
    }

}

