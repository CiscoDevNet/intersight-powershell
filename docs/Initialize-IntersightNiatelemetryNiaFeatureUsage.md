---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightNiatelemetryNiaFeatureUsage

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightNiatelemetryNiaFeatureUsage [-AaaLdapProviderCount< long>][-AaaRadiusProviderCount< long>][-AaaTacacsProviderCount< long>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ApicClusterHealth< string>][-ApicCount< long>][-ApicIsTelnetEnabled< bool>][-ApicNtpCount< long>][-ApicSnmpCommunityCount< long>][-ApicSysLogGrpCount< long>][-ApicSysLogSrcCount< long>][-AppCenterCount< long>][-Ave< string>][-BdCount< long>][-CallhomeSmartGroupCount< long>][-ClassId< NiatelemetryNiaFeatureUsage.ClassIdEnum>][-CloudSecPeerCount< long>][-CloudTenantCount< long>][-CompHvCount< long>][-ConfigExportpCount< long>][-ConfigJobCount< long>][-ConsistencyCheckerApp< string>][-ContractCount< long>][-DnsCount< long>][-EigrpCount< long>][-EpgCount< long>][-FabricModuleCount< long>][-FabricSetuppCount< long>][-FcoeNportCount< long>][-FcoeNportDomCount< long>][-FcoeNportVlanCount< long>][-FcoeNportVsanCount< long>][-FvSlaDefCount< long>][-HsrpCount< long>][-IbgpCount< long>][-IgmpAccessListCount< long>][-IgmpSnoop< string>][-IpEpgCount< long>][-IsBgpRouteReflectorsFeatureUsed< bool>][-IsBridgeDomainsFeatureUsed< bool>][-IsCommonLocalUserName< bool>][-IsContractsFeatureUsed< bool>][-IsEpgFeatureUsed< bool>][-IsFiltersFeatureUsed< bool>][-IsHttpConfigured< bool>][-IsHttpsConfigured< bool>][-IsNtpFeatureUsed< bool>][-IsPtpFeatureUsed< bool>][-IsSynceFeatureUsed< bool>][-IsTechSupportCollected< string>][-IsTenantsFeatureUsed< bool>][-IsVrfsFeatureUsed< bool>][-IsisCount< long>][-L2Multicast< string>][-LatencyPtpMode< string>][-LeafCount< long>][-LocalUsernameCount< long>][-LoginBlockDuration< long>][-LoginMaxFailedAttempts< long>][-LoginMaxFailedAttemptsWindow< long>][-MaintenanceModeCount< long>][-ManagementOverV6Count< long>][-MicrosoftUsegVmmEpPdCount< long>][-Moid< string>][-NetFlowCount< long>][-NiccVersion< string>][-Nir< string>][-ObjectType< NiatelemetryNiaFeatureUsage.ObjectTypeEnum>][-OpenStack< string>][-OpflexKubernetesCount< long>][-OspfCount< long>][-PasswordHistoryCount< long>][-PasswordStrengthCheck< string>][-PasswordStrengthProfileCount< long>][-PoeCount< long>][-PortSecurityCount< long>][-QinVniTunnelCount< long>][-QosCongCount< long>][-QosPfcPolCount< long>][-RealmCount< long>][-RecordType< string>][-RecordVersion< string>][-RemoteLeafCount< long>][-ScvmmCount< long>][-SharedL3OutCount< long>][-SiteName< string>][-SmartCallHome< string>][-SmartLicense< Model.NiatelemetrySmartLicense>][-SnapshotCount< long>][-Snmp< string>][-SnmpCommunityAccessCount< long>][-SnmpGroupCount< long>][-SnmpTrapCount< long>][-SnmpV3Count< long>][-SpanCount< long>][-SpanDstCount< long>][-SpanSrcCount< long>][-SpineCount< long>][-SshOverV6Count< long>][-SshV2Count< long>][-SupervisorModuleCount< long>][-SyslogGroupCount< long>][-SyslogOverV6Count< long>][-SystemControllerCount< long>][-TacacsGroupCount< long>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-TenantCount< long>][-TierTwoLeafCount< long>][-TotalCriticalFaults< long>][-Twamp< string>][-Useg< string>][-VmWareVdsCount< long>][-VmmCtrlrpCount< long>][-VmmDompCount< long>][-VmmEpPdCount< long>][-VnsmDevCount< long>][-VpodCount< long>][-WebtokenTimeoutSeconds< long>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

### -AaaLdapProviderCount
Returns the total number of AAA Ldap Providers.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AaaRadiusProviderCount
Returns the total number of AAA Radius Providers.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AaaTacacsProviderCount
Returns the total number of AAA Tacacs Providers.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AdditionalProperties


```yaml
Type: System.Collections.Generic.Dictionary`2[string,object]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ApicClusterHealth
Cluster health for the APIC controller.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ApicCount
Number of APIC controllers. This determines the value of controllers for the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ApicIsTelnetEnabled
Returns if telnet is enabled on APIC.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ApicNtpCount
Count of NTP servers configured on APIC.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ApicSnmpCommunityCount
Number of SNMP communities configured on APIC.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ApicSysLogGrpCount
Number of logging groups configured on APIC.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ApicSysLogSrcCount
Number of logging sources configured on APIC.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AppCenterCount
ACI APPs feature usage scale.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Ave
AVE feature usage. This determines if ACI virtual edge feature is enabled or disabled.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -BdCount
Number of BDs. This determines the total number of Broadcast Domains across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CallhomeSmartGroupCount
Number of call home smart monitoring policies on the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: NiatelemetryNiaFeatureUsage.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CloudSecPeerCount
Number of Cloudsec SA peers.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CloudTenantCount
Returns the total number of tenants deployed.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CompHvCount
Number of compute hypervisors on the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConfigExportpCount
Number of system backup configure export policies on the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConfigJobCount
Number of system backup configure jobs on the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConsistencyCheckerApp
Consistency checker application usage. This determines if the fabric has Consistency checker application installed.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ContractCount
Number of contracts. This determines the total number of Contracts configured across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DnsCount
DNS feature usage. This determines the total number of DNS configurations across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EigrpCount
Eigrp feature usage. This determines the total number of EIGRP sessions across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EpgCount
Number of End Point Groups. This determines the total number of End Point Groups across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FabricModuleCount
Returns the total number of fabric module slots.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FabricSetuppCount
Number of Multi-Pods per fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FcoeNportCount
Total number of FCoE N-Port for DOM, VSAn, and VLAN.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FcoeNportDomCount
Number of FCoE N-Port DOM.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FcoeNportVlanCount
Number of FCoE N-Port VLAN.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FcoeNportVsanCount
Number of FCoE N-Port VSAN.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FvSlaDefCount
Number of Internet Protocol Service Level Agreements Monitoring policy objects for object tracking.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HsrpCount
Hsrp feature usage. This determines the total number of HSRP sessions across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IbgpCount
Ibgp feature usage. This determines the total number of BGP sessions across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IgmpAccessListCount
IGMP Access List feature usage. This determines the total number of IGMP access lists configured across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IgmpSnoop
IGMP Snooping feature usage. This determines if this feature is enabled or disabled.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IpEpgCount
Number of IP based End Point Groups. This determines the total number of IP End Point Groups across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsBgpRouteReflectorsFeatureUsed
BGP route reflector usage on APIC.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsBridgeDomainsFeatureUsed
Brodge domains feature usage on APIC controller.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsCommonLocalUserName
Returns value of isCommonLocalUserName field.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsContractsFeatureUsed
Contracts feature usage on APIC controller.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsEpgFeatureUsed
EPG feature usage on APIC controller.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsFiltersFeatureUsed
Filters feature usage on APIC.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsHttpConfigured
Returns if HTTP is configured.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsHttpsConfigured
Returns if HTTPS is configured.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsNtpFeatureUsed
NTP feature usage on APIC controller.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsPtpFeatureUsed
Ptp feature usage on APIC.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsSynceFeatureUsed
Synce feature usage on APIC.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsTechSupportCollected
Status of techsupport collection.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsTenantsFeatureUsed
Tenants feature usage on APIC.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsVrfsFeatureUsed
VRF feature usage on APIC controller.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsisCount
Isis feature usage. This determines the total number of ISIS sessions across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -L2Multicast
L2Multicast feature usage. This determines if this Layer 2 Multicast feature is being enabled / disabled on the fabric.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LatencyPtpMode
Returns the Latency ptp mode for the controller.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LeafCount
Number of Leafs. This determines the total number of Leaf switches in the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LocalUsernameCount
Returns count of local users.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LoginBlockDuration
Returns login block duration value.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LoginMaxFailedAttempts
Returns the maximum failed attempts on login.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LoginMaxFailedAttemptsWindow
Returns the maximum failed attempt windows on login.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MaintenanceModeCount
Maintenance Mode feature usage. This determines the number of switches that are currently in maintenance mode.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ManagementOverV6Count
Management over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MicrosoftUsegVmmEpPdCount
Number of Microsoft microsegmentation VmmEpPD objects. Ensures that Microsoft was configured.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NetFlowCount
Number of Netflow monitor policies.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NiccVersion
NICC version. NiccVersion is used to check the compatibility.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Nir
NIR application usage. This determines if the fabric has NIR application installed.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: NiatelemetryNiaFeatureUsage.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OpenStack
Open stack feature usage.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OpflexKubernetesCount
Opflex for Kubernetes feature usage. This determines the total number of VMM sessions of type kubernetes.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OspfCount
Ospf feature usage. This determines the total number of OSPF sessions across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PasswordHistoryCount
Returns count of passwords.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PasswordStrengthCheck
Returns if the password is strong or not.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PasswordStrengthProfileCount
Returns the number of password strength profile.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PoeCount
POE feature usage. This determines the total number of POE configurations across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PortSecurityCount
Number of objects with Port Security enabled. Non-Zero value indicates the object as enabled.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -QinVniTunnelCount
QinVniTunnel feature usage. This determines if the qinVniTunnel feature is being used on the fabric and the scale of it.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -QosCongCount
Number of Quality Of Service congestion class.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -QosPfcPolCount
Number of Quality Of Service class.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RealmCount
Returns the value of count of realms.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RecordType
Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RecordVersion
Version of record being pushed. This determines what was the API version for data available from the device.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RemoteLeafCount
Number of remote Leafs. This determines the total number of remote leaf switches in the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ScvmmCount
SCVMM feature usage. This determines the total number of SCVMM configurations in the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SharedL3OutCount
SharedL3Out feature usage. This determines the total number of Shared L3 out configured across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SiteName
The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites. There will be a feature usage object per site in Multi site scenario. In multi-site scenario the site name is available in all the requests being made.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SmartCallHome
Smart callhome feature usage. This determines if this feature is being enabled or disabled.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SmartLicense
Details of smart license.

Note :- Use Initialize-IntersightNiatelemetrySmartLicense to create the object of complex type NiatelemetrySmartLicense

```yaml
Type: Model.NiatelemetrySmartLicense
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SnapshotCount
Returns count of snapshots.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Snmp
SNMP feature usage. This determines if this feature is enabled or disabled.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SnmpCommunityAccessCount
Returns count of SNMP Community Access.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SnmpGroupCount
Number of SNMP monitoring policies on the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SnmpTrapCount
Returns count of SNMP trap.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SnmpV3Count
Returns count of SNMP V3 on the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SpanCount
Number of Span Sources and Destinations.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SpanDstCount
Number of Span Destinations with valid state.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SpanSrcCount
Number of Span Sources with valid state.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SpineCount
Number of Spines. This determines the total number of spine switches in the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SshOverV6Count
Ssh over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SshV2Count
Returns count of ssh V2 on the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SupervisorModuleCount
Returns the total number of supervisor module slots.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SyslogGroupCount
Number of syslog monitoring policies on the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SyslogOverV6Count
Syslog over IPv6 feature usage. This determines the total number of IPv6 configurtaions in the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SystemControllerCount
Returns the total number of system controller slots.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TacacsGroupCount
Number of tacacs monitoring policies on the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tags


Note :- Use Initialize-IntersightMoTag to create the object of complex type MoTag

```yaml
Type: System.Collections.Generic.List`1[Model.MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TenantCount
Number of tenants. This determines the total number of tenants configured across the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TierTwoLeafCount
Number of tier 2 Leafs. This determines the total number of tier 2 Leaf switches in the fabric.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TotalCriticalFaults
Returns the total number of critical faults.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Twamp
TWAMP feature usage. This determines if this feature is enabled or disabled.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Useg
VMM uSegmentation feature usage. This determines if microsegmentation feature is enabled or disabled.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmWareVdsCount
Number of objects with VmWare vCenter 6.5 support. Checks the controller revision value.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmmCtrlrpCount
Number of Virtual Machine Monitor controller policy objects for VMware vCenter.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmmDompCount
Number of Virtual Machine Monitor domain policy model objects for VMware vCenter.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmmEpPdCount
Microsegmentation Distributed Virtual Switch feature usage. Gets the number of objects associated to VMware vCenter.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VnsmDevCount
Number of objects with L4-L7 Device Package Import enabled. Checks for the vendor and the model.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VpodCount
Virtual pod feature usage. This determines the total number of virtual POD configurations in the fabrics.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -WebtokenTimeoutSeconds
Timeout for web token in seconds.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Json
Returns the json payload received in response.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -WithHttpInfo
Returns the HTTP response with headers and content.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-IntersightNiatelemetryNiaFeatureUsage
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightNiatelemetrySmartLicense](./Initialize-IntersightNiatelemetrySmartLicense.md)
