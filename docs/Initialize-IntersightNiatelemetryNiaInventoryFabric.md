---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightNiatelemetryNiaInventoryFabric

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightNiatelemetryNiaInventoryFabric [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AnycastGwMac< string>][-BgpEstablishedInterfaceCount< long>][-BgwCount< long>][-BgwInterfaceUpCount< long>][-BorderGatewaySpineCount< long>][-BorderLeafCount< long>][-ClassId< NiatelemetryNiaInventoryFabric.ClassIdEnum>][-CloudsecAutoconfig< bool>][-DciSubnetRange< string>][-DciSubnetTargetMask< string>][-DcnmtrackerEnabled< bool>][-EbgpEvpnLinkUpCount< long>][-FabricId< string>][-FabricName< string>][-FabricParent< string>][-FabricTechnology< string>][-FabricType< string>][-FeaturePtp< string>][-IsBgwPresent< bool>][-IsEnableNxapiHttp< bool>][-IsEnableRealTimeBackup< bool>][-IsNgoamEnabled< bool>][-IsScheduledBackUpEnabled< bool>][-IsTrmEnabled< bool>][-LeafCount< long>][-LinkStateRouting< string>][-LinkType< string>][-LogicalLinks< System.Collections.Generic.List`1[Model.NiatelemetryLogicalLink]>][-Moid< string>][-NetworkDeploymentCount< long>][-NetworkDeploymentStatus< System.Collections.Generic.List`1[Model.NiatelemetryDeploymentStatus]>][-NtpServerIpList< string>][-NxosVniBwSitesCount< long>][-NxosVrfBwSitesCount< long>][-NxosVrfCount< long>][-ObjectType< NiatelemetryNiaInventoryFabric.ObjectTypeEnum>][-OperStatus< string>][-ReplicationMode< string>][-RpMode< string>][-Serial< string>][-SiteName< string>][-SoftwareImage< string>][-SpineCount< long>][-SyslogServerIpList< string>][-SyslogSev< string>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-TemplateName< string>][-VlanVniMappings< string>][-VniIpCount< long>][-VpcDetails< System.Collections.Generic.List`1[Model.NiatelemetryVpcDetails]>][-VrfDeploymentCount< long>][-VrfDeploymentStatus< System.Collections.Generic.List`1[Model.NiatelemetryDeploymentStatus]>][-XsiteNetworkCount< long>][-XsiteVrfCount< long>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

## PARAMETERS

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

### -AnycastGwMac
Returns the aycast gateway mac.

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

### -BgpEstablishedInterfaceCount
Counts the number of BGP interfaces that are in established state.

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

### -BgwCount
Returns number of bgw switches in the fabric.

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

### -BgwInterfaceUpCount
Count number of active interfaces on border gateways.

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

### -BorderGatewaySpineCount
Count number of border gateway spines in the fabric inventory.

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

### -BorderLeafCount
Count number of border leafs in the fabric inventory.

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
Type: NiatelemetryNiaInventoryFabric.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CloudsecAutoconfig
Cloudsec autoconfig details on the fabric.

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

### -DciSubnetRange
Returns the dci subnet range.

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

### -DciSubnetTargetMask
Returns the dci subnet target mask.

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

### -DcnmtrackerEnabled
Returns the value of the dcnmtrackerEnabled field.

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

### -EbgpEvpnLinkUpCount
Count number of ebgp evpn active interfaces.

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

### -FabricId
Uniquely identifies a fabric.

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

### -FabricName
Returns the value of the Name of a fabric.

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

### -FabricParent
Parent of the fabric on DCNM.

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

### -FabricTechnology
Fabric Technology details on the fabric.

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

### -FabricType
Fabric type information string.

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

### -FeaturePtp
PTP feature details on the fabric.

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

### -IsBgwPresent
Checks if border gateway is present in the fabric inventory.

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

### -IsEnableNxapiHttp
Check if NXAPI HTTP is enabled or not on the fabric.

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

### -IsEnableRealTimeBackup
Check if real time backup is enabled or not on the fabric.

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

### -IsNgoamEnabled
Returns if ngoam is enabled.

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

### -IsScheduledBackUpEnabled
Returns if the scheduled backup is enabled.

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

### -IsTrmEnabled
Is TRM enabled for the fabric.

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

### -LeafCount
Returns total number of leafs in the fabric.

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

### -LinkStateRouting
Link state routing details on the fabric.

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

### -LinkType
Fabric oper status information.

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

### -LogicalLinks


Note :- Use Initialize-IntersightNiatelemetryLogicalLink to create the object of complex type NiatelemetryLogicalLink

```yaml
Type: System.Collections.Generic.List`1[Model.NiatelemetryLogicalLink]
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

### -NetworkDeploymentCount
No of networks deployed on a fabric.

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

### -NetworkDeploymentStatus


Note :- Use Initialize-IntersightNiatelemetryDeploymentStatus to create the object of complex type NiatelemetryDeploymentStatus

```yaml
Type: System.Collections.Generic.List`1[Model.NiatelemetryDeploymentStatus]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -NtpServerIpList
NTP server IP List on the fabric.

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

### -NxosVniBwSitesCount
Returns the count of vnis between sites.

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

### -NxosVrfBwSitesCount
Returns the count of vrfs between sites.

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

### -NxosVrfCount
Returns the value of the nxosVrfCount field.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: NiatelemetryNiaInventoryFabric.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OperStatus
Fabric oper status information.

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

### -ReplicationMode
Replication mode details on the fabric.

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

### -RpMode
RP Mode details on the fabric.

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

### -Serial
Serial number of device being inventoried. The serial number is unique per device.

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

### -SiteName
Name of fabric domain of the controller.

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

### -SoftwareImage
Software image details on the fabric.

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

### -SpineCount
Returns total number of spines in the fabric.

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

### -SyslogServerIpList
Syslog server IP list on DCNM.

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

### -SyslogSev
Syslog sev details on the fabric.

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

### -TemplateName
Template name of the fabric on DCNM.

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

### -VlanVniMappings
VLAN to VNI mappings configured in the DCNM.

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

### -VniIpCount
Count number of IP addresses configured in the DCNM networks.

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

### -VpcDetails


Note :- Use Initialize-IntersightNiatelemetryVpcDetails to create the object of complex type NiatelemetryVpcDetails

```yaml
Type: System.Collections.Generic.List`1[Model.NiatelemetryVpcDetails]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VrfDeploymentCount
No of vrfs deployed on a fabric.

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

### -VrfDeploymentStatus


Note :- Use Initialize-IntersightNiatelemetryDeploymentStatus to create the object of complex type NiatelemetryDeploymentStatus

```yaml
Type: System.Collections.Generic.List`1[Model.NiatelemetryDeploymentStatus]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -XsiteNetworkCount
Returns deployed network count for bgw/bgws switches in the MSD fabric.

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

### -XsiteVrfCount
Returns deployed vrf count for bgw/bgws switches in the MSD fabric.

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
PS C:\> Initialize-IntersightNiatelemetryNiaInventoryFabric
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

[Initialize-IntersightNiatelemetryDeploymentStatus](./Initialize-IntersightNiatelemetryDeploymentStatus.md)

[Initialize-IntersightNiatelemetryLogicalLink](./Initialize-IntersightNiatelemetryLogicalLink.md)

[Initialize-IntersightNiatelemetryVpcDetails](./Initialize-IntersightNiatelemetryVpcDetails.md)
