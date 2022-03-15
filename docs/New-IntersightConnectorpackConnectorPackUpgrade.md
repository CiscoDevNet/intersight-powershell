---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightConnectorpackConnectorPackUpgrade

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightConnectorpackConnectorPackUpgrade [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ConnectorPackOpType< ConnectorpackConnectorPackUpgrade.ConnectorPackOpTypeEnum>][-Moid< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-UcsdInfo< IaasUcsdInfoRelationship>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &amp;apos;ConnectorpackConnectorPackUpgrade&amp;apos; resource.

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

### -ConnectorPackOpType
The type of operation to be performed on UCS Director.\n* `Install` - Installs the requisite connector packs on UCS Director.\n* `Push` - Pushes the requisite connector packs to UCS Director.

```yaml
Type: ConnectorpackConnectorPackUpgrade.ConnectorPackOpTypeEnum
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

### -UcsdInfo
A reference to a iaasUcsdInfo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IaasUcsdInfoRelationship
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
PS C:\> New-IntersightConnectorpackConnectorPackUpgrade
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightConnectorpackConnectorPackUpgrade](./Get-IntersightConnectorpackConnectorPackUpgrade.md)

[Remove-IntersightConnectorpackConnectorPackUpgrade](./Remove-IntersightConnectorpackConnectorPackUpgrade.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
