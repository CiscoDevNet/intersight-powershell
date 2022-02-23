---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightVirtualizationVmwareResourceAllocationSystemTrafficTypes

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightVirtualizationVmwareResourceAllocationSystemTrafficTypes [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< VirtualizationVmwareResourceAllocationSystemTrafficTypes.ClassIdEnum>][-Limit< long>][-ObjectType< VirtualizationVmwareResourceAllocationSystemTrafficTypes.ObjectTypeEnum>][-Reservation< long>][-Shares< VirtualizationVmwareResourceAllocationSystemTrafficTypes.SharesEnum>][-SharesValue< int>][-TrafficType< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: VirtualizationVmwareResourceAllocationSystemTrafficTypes.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Limit
The maximum allowed usage for a traffic class belonging to this resource pool per host physical NIC. The utilization of a traffic class will not exceed the specified limit even if there are available network resources. If this value is unset or set to -1 in an update operation, then there is no limit on the network resource usage (only bounded by available resource and shares). Units are in Mbits/sec.

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
Type: VirtualizationVmwareResourceAllocationSystemTrafficTypes.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Reservation
Amount of bandwidth resource that is guaranteed available to the host infrastructure traffic class. If the utilization is less than the reservation, the extra bandwidth is used for other host infrastructure traffic class types.

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

### -Shares
Network share. The value is used as a relative weight in competing for shared bandwidth, in case of resource contention.\n* `low` - Share of the traffic in the overall flow through a physical adapter.\n* `high` - Share of the traffic in the overall flow through a physical adapter.\n* `normal` - Share of the traffic in the overall flow through a physical adapter.\n* `custom` - Share of the traffic in the overall flow through a physical adapter.

```yaml
Type: VirtualizationVmwareResourceAllocationSystemTrafficTypes.SharesEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SharesValue
The number of shares allocated. Used to determine resource allocation in case of resource contention. Shares value is only set if level is set to custom. If level is not set to custom, this value is ignored. Therefore, only shares with custom values can be compared.

```yaml
Type: int
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TrafficType
Key of the host infrastructure resource.

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
PS C:\> Initialize-IntersightVirtualizationVmwareResourceAllocationSystemTrafficTypes
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
