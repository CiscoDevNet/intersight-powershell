---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightBootHttp

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightBootHttp [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< BootHttp.ClassIdEnum>][-Enabled< bool>][-InterfaceName< string>][-InterfaceSource< BootHttp.InterfaceSourceEnum>][-IpConfigType< BootHttp.IpConfigTypeEnum>][-IpType< BootHttp.IpTypeEnum>][-MacAddress< string>][-Name< string>][-ObjectType< BootHttp.ObjectTypeEnum>][-Port< long>][-Protocol< BootHttp.ProtocolEnum>][-Slot< string>][-StaticIpV4Settings< Model.BootStaticIpV4Settings>][-StaticIpV6Settings< Model.BootStaticIpV6Settings>][-Uri< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: BootHttp.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Enabled
Specifies if the boot device is enabled or disabled.

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

### -InterfaceName
The name of the underlying virtual ethernet interface used by the HTTP boot device.

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

### -InterfaceSource
Lists the supported Interface Source for HTTP device. Supported values are \&quot;name\&quot; and \&quot;mac\&quot;.\n* `name` - Use interface name to select virtual ethernet interface.\n* `mac` - Use MAC address to select virtual ethernet interface.\n* `port` - Use port to select virtual ethernet interface.

```yaml
Type: BootHttp.InterfaceSourceEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IpConfigType
The IP config type to use during the HTTP boot process. For DHCP configuration, the IP address, DNS server, netmask and gateway details are obtained from DHCP server. For static configuration, please provide the IP address, DNS server, netmask, and gateway details.\n* `DHCP` - The type of the IP config is DHCP.\n* `Static` - The type of the IP config is Static.

```yaml
Type: BootHttp.IpConfigTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IpType
The IP address family type to use during the HTTP boot process.\n* `IPv4` - The type of the IP address is IPv4.\n* `IPv6` - The type of the IP address is IPv6.

```yaml
Type: BootHttp.IpTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MacAddress
The MAC Address of the underlying virtual ethernet interface used by the HTTP boot device.

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

### -Name
A name that helps identify a boot device. It can be any string that adheres to the following constraints. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters. It cannot be a reserved keyword. However, it can be used in conjunction with other letters, numbers, underscores, and hyphens (EU_CDROM-3, etc.). Reserved words include - all, ALL, CDROM, EFI, EOD, FDD, HDD, HDDANY, HTTP, ISCSI, ISCSIANY, LOCALCDD, LOCALHDD, NULL, NVME, NVMEANY, PCHSTORAGE, PCHSTORANY, PXE, SAN, SANANY, SDANY, SDCARD, UEFISHELL, USB, USBCD, USBFDD, USBHDD, VMCIMCCD, VMCIMCHDD, VMEDIA, VMFDD, VMKVMCD, VMKVMHDD.

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
Type: BootHttp.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Port
The Port ID of the adapter on which the underlying virtual ethernet interface is present. If no port is specified, the default value is -1. Supported values are 0 to 255.

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

### -Protocol
Protocol to be used for HTTP boot. HTTPS require root certificate for authentication.\n* `HTTPS` - Secure HTTP protocol, certificate required for authentication.\n* `HTTP` - HTTP protocol without security certificate requirement.

```yaml
Type: BootHttp.ProtocolEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Slot
The slot ID of the adapter on which the underlying virtual ethernet interface is present. Supported values are ( 1 - 255, \&quot;MLOM\&quot;, \&quot;L\&quot;, \&quot;L1\&quot;, \&quot;L2\&quot;, \&quot;OCP\&quot;).

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

### -StaticIpV4Settings
The static IP config settings to use during the HTTP boot process.

Note :- Use Initialize-IntersightBootStaticIpV4Settings to create the object of complex type BootStaticIpV4Settings

```yaml
Type: Model.BootStaticIpV4Settings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StaticIpV6Settings
The static IP config settings to use during the HTTP boot process.

Note :- Use Initialize-IntersightBootStaticIpV6Settings to create the object of complex type BootStaticIpV6Settings

```yaml
Type: Model.BootStaticIpV6Settings
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Uri
Boot resource location in URI format.

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
PS C:\> Initialize-IntersightBootHttp
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightBootStaticIpV4Settings](./Initialize-IntersightBootStaticIpV4Settings.md)

[Initialize-IntersightBootStaticIpV6Settings](./Initialize-IntersightBootStaticIpV6Settings.md)
