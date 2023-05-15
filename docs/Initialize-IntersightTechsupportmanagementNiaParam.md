---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightTechsupportmanagementNiaParam

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightTechsupportmanagementNiaParam [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< TechsupportmanagementNiaParam.ClassIdEnum>][-CollectionClass< TechsupportmanagementNiaParam.CollectionClassEnum>][-CollectionLevel< TechsupportmanagementNiaParam.CollectionLevelEnum>][-Filename< string>][-ForceFresh< bool>][-ObjectType< TechsupportmanagementNiaParam.ObjectTypeEnum>][-Period< long>][-Pids< System.Collections.Generic.List`1[string]>][-SerialNumbers< System.Collections.Generic.List`1[string]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: TechsupportmanagementNiaParam.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CollectionClass
CollectionClass specifies which app to collect ND techsupport from - infra/NDI/NDO/NDFC.\n* `1` - Collect infra logs for Nexus Dashboard TACASSIST.\n* `2` - Collect logs for Nexus Dashboard Insights app through NDTACASSIST.\n* `3` - Collect logs for Nexus Dashboard Orchestrator app through NDTACASSIST.\n* `4` - Collect logs for Nexus Dashboard Fabric Controller app through NDTACASSIST.\n* `5` - Collect logs for Nexus Data Broker app through NDTACASSIST.\n* `6` - Collect logs for Nexus Data Broker Orchestrator app through NDTACASSIST.

```yaml
Type: TechsupportmanagementNiaParam.CollectionClassEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CollectionLevel
CollectionLevel controls the size / depth of the tech support files collected.\n* `1` - Use cached data in the returned collection.\n* `2` - Use current data in the returned collection.

```yaml
Type: TechsupportmanagementNiaParam.CollectionLevelEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Filename
Filename specifies an individual filename to collect from the endpoint.

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

### -ForceFresh
ForceFresh controls whether to return pre-collected files or force the collection of new files.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: TechsupportmanagementNiaParam.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Period
Number of days for which to collect techsupport.

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

### -Pids


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

### -SerialNumbers


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
PS C:\> Initialize-IntersightTechsupportmanagementNiaParam
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
