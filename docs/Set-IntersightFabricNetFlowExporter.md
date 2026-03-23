---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightFabricNetFlowExporter

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightFabricNetFlowExporter [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Destination< string>][-Dscp< long>][-GatewayIp< string>][[-Moid]< string>][-Name< string>][-NetFlowPolicy< FabricNetFlowPolicyRelationship>][-OptionExporterStatsTimeout< long>][-OptionInterfaceTableTimeout< long>][-SourceInterface< FabricVlanExportInterface>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TemplateDataTimeout< long>][-UdpPort< long>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;FabricNetFlowExporter&apos; resource.

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

### -Destination
Netflow collector IP address, The Netflow collector receives flow records from one or more exporters.  It processes the received export packets and stores the flow record information.

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

### -Dscp
DSCP value for export packets to ensure they receive proper QoS treatment. By default, NetFlow export packets may use the default DSCP value (usually 0, equivalent to Best Effort).

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

### -GatewayIp
Gateway IP address for the export interface network.

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

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
Name of netflow exporter. Must be a maximum of 31 characters, without spacing.

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

### -NetFlowPolicy
A reference to a fabricNetFlowPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FabricNetFlowPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OptionExporterStatsTimeout
The time interval, in seconds, during which a NetFlow collector maintains an option template after it has been received from an exporter. An Option Template Record is a special type of template in NetFlow used to export metadata or control information, rather than flow data such as sampling parameters or exporter statistics.

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

### -OptionInterfaceTableTimeout
The time interval, in seconds, during which a NetFlow collector maintains an interface option template after it has been received from an exporter. The optionInterfaceTable refers to an option data record exported by NetFlow exporters that provides metadata about network interfaces such as interface names, types, and speeds.

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

### -SourceInterface
Netflow exporter source interface, used as the source address for netflow export packet.

Note :- Use Initialize-IntersightFabricVlanExportInterface to create the object of complex type FabricVlanExportInterface

```yaml
Type: FabricVlanExportInterface
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
Type: System.Collections.Generic.List`1[MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TemplateDataTimeout
The time interval, in seconds, during which a NetFlow collector maintains a template after it has been received from an exporter. templateData refers to the actual flow record data that is exported from a exporter to a collector, using a previously defined template. The template specifies the structure and the templateData provides the corresponding values for those fields for each flow.

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

### -UdpPort
NetFlow export packets are encapsulated within UDP datagrams for transmission to the NetFlow collector.

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

### -IfMatch
For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
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
PS C:\> Set-IntersightFabricNetFlowExporter
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightFabricNetFlowExporter](./Get-IntersightFabricNetFlowExporter.md)

[Initialize-IntersightFabricVlanExportInterface](./Initialize-IntersightFabricVlanExportInterface.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightFabricNetFlowExporter](./New-IntersightFabricNetFlowExporter.md)

[Remove-IntersightFabricNetFlowExporter](./Remove-IntersightFabricNetFlowExporter.md)
