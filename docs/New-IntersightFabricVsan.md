---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightFabricVsan

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightFabricVsan [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-DefaultZoning< FabricVsan.DefaultZoningEnum>][-FcNetworkPolicy< FabricFcNetworkPolicyRelationship>][-FcZoneSharingMode< string>][-FcoeVlan< long>][-Moid< string>][[-Name]< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-VsanId< long>][-VsanScope< FabricVsan.VsanScopeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;FabricVsan&apos; resource.

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

### -DefaultZoning
Enables or Disables the default zoning state.\n* `Enabled` - Admin configured Enabled State.\n* `Disabled` - Admin configured Disabled State.

```yaml
Type: FabricVsan.DefaultZoningEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FcNetworkPolicy
A reference to a fabricFcNetworkPolicy resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: FabricFcNetworkPolicyRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FcZoneSharingMode
Logical grouping mode for fc ports.

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

### -FcoeVlan
FCOE Vlan associated to the VSAN configuration.

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

### -Name
User given name for the VSAN configuration.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
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

### -VsanId
Virtual San Identifier in the switch.

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

### -VsanScope
Used to indicate whether the VSAN Id is defined for storage or uplink or both traffics in FI.\n* `Uplink` - Vsan associated with uplink network.\n* `Storage` - Vsan associated with storage network.\n* `Common` - Vsan that is common for uplink and storage network.

```yaml
Type: FabricVsan.VsanScopeEnum
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
PS C:\> New-IntersightFabricVsan
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Remove-IntersightFabricVsan](./Remove-IntersightFabricVsan.md)

[Set-IntersightFabricVsan](./Set-IntersightFabricVsan.md)

[Get-IntersightFabricVsan](./Get-IntersightFabricVsan.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
