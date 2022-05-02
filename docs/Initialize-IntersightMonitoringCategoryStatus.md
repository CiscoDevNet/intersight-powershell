---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightMonitoringCategoryStatus

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightMonitoringCategoryStatus [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-CategoryLabel< string>][-ClassId< MonitoringCategoryStatus.ClassIdEnum>][-Deeplink< string>][-Details< string>][-ObjectType< MonitoringCategoryStatus.ObjectTypeEnum>][-SourceId< string>][-Status< MonitoringCategoryStatus.StatusEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -CategoryLabel
Name of the category for which status is being reported (for e.g. &apos;Licensing&apos;, &apos;Advisories&apos;).

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: MonitoringCategoryStatus.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Deeplink
Link to the corresponding category specific page in Intersight to get additional information and troubleshoot. for e.g. &apos;Alarms&apos; category would have the deeplink as &apos;https://intersight.com/an/cond/alarms/active&apos;.

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

### -Details
Additional information regarding category status that may be displayed in UI related to the category status. Optional and currently unused.

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
Type: MonitoringCategoryStatus.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SourceId
Additional parameter to be used for traceability and troubleshooting, currently unused.

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

### -Status
Aggregated status of the category being reported. For e.g., a given Intersight account might have a combination of high and low severity Advisories applicable to managed devices. However, even if one of the devices is impacted by a high severity Advisories, the category status is reported as &apos;critical&apos;.\n* `Unknown` - The current status for the respective category cannot be determined. This may be due to some intermittent issue or due to the fact that the user making the request does not have appropriate privileges/entitlements for the concerned category.\n* `Critical` - The Intersight account is impacted by a high severity issue  for the applicable category that will need to be addressed immediately. for e.g. critical status for &apos;Advisories&apos; category would mean that the Intersight account is impacted by an urgent field notice or a vulnerability with high severity level.\n* `Warning` - The Intersight account is impacted by a high severity issue  for the applicable category that will need to be addressed soon. for e.g. warning status for &apos;Advisories&apos; category might mean that the Intersight account is impacted by an a vulnerability with moderate severity level.\n* `Healthy` - The Intersight account is not impacted by any high severity issue for the applicable category.

```yaml
Type: MonitoringCategoryStatus.StatusEnum
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
PS C:\> Initialize-IntersightMonitoringCategoryStatus
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
