---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightHyperflexStartReduceReSync

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightHyperflexStartReduceReSync [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClusterMoIds< System.Collections.Generic.List`1[string]>][-Moid< string>][-Operation< HyperflexStartReduceReSync.OperationEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TargetDetails< System.Collections.Generic.List`1[HyperflexReSyncClusterMoIds]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;HyperflexStartReduceReSync&apos; resource.

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

### -ClusterMoIds


```yaml
Type: System.Collections.Generic.List`1[string]
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

### -Operation
The cleanup operation to perform.\n* `NoOp` - Does not perform any operation when the API is called.\n* `StartReduceResync` - Start the execution of reduce re-sync and stale mirror cleanup for the HyperFlex clusters associated with the account.

```yaml
Type: HyperflexStartReduceReSync.OperationEnum
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

### -TargetDetails


Note :- Use Initialize-IntersightHyperflexReSyncClusterMoIds to create the object of complex type HyperflexReSyncClusterMoIds

```yaml
Type: System.Collections.Generic.List`1[HyperflexReSyncClusterMoIds]
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
PS C:\> New-IntersightHyperflexStartReduceReSync
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightHyperflexStartReduceReSync](./Get-IntersightHyperflexStartReduceReSync.md)

[Initialize-IntersightHyperflexReSyncClusterMoIds](./Initialize-IntersightHyperflexReSyncClusterMoIds.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
