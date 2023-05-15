---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightTamMilestone

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightTamMilestone [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< TamMilestone.ClassIdEnum>][-Date< DateTime>][-Description< string>][-EndOffset< int>][-LabelHint< TamMilestone.LabelHintEnum>][-MilestoneType< TamMilestone.MilestoneTypeEnum>][-Name< string>][-ObjectType< TamMilestone.ObjectTypeEnum>][-StartOffset< int>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: TamMilestone.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Date
Date when the specified end-of-life milestone advisory is reached.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
A description of the milestone defined by an end-of-life advisory.

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

### -EndOffset
Number of days (exclusive) relative to the milestone date when the milestone is considered to be not in effect. A nagative number indicates number of days ahead of the milestone date. The default is 2147483647 (0x7FFFFFFF) which means the milestone date range&apos;s upper bound is omitted.

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

### -LabelHint
Extra hint to the type of label to be used in display in addition to severity and effective date. How to use it is at UI&apos;s descretion.\n* `upcoming` - This end-of-life (EOL) milestone is upcoming. The label may be changed to more urgent type such as &apos;imminent&apos; as time progress approaching effective date.\n* `imminent` - This end-of-life (EOL) milestone is imminent. There will be no label change before the effective date.\n* `past` - This end-of-life (EOL) milestone has past the effective date.\n* `info` - This end-of-life (EOL) milestone for informative purpose.

```yaml
Type: TamMilestone.LabelHintEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MilestoneType
Milestone type as defined in Cisco end-of-life (EOL) policy (https://www.cisco.com/c/en/us/products/eos-eol-policy.html) when the specified end-of-life milestone advisory is reached.\n* `unknown` - The type of end-of-life milestone is not defined.\n* `endOfSoftwareMaintenanceDate` - The last date that Cisco Engineering may release any final software maintenance releases or bug fixes. After this date, Cisco Engineering may no longer develop, repair, maintain, or test the product software and only critical security updates will be provided on this release train. \n* `lastDateOfSupport` - The last date to receive service and support for the software. After this date, all support services for the software are unavailable, and the software becomes obsolete. \n* `endOfLifeAnnouncementDate` - The date the document that announces the end-of-sale and end-of-life of a product is distributed to the general public.

```yaml
Type: TamMilestone.MilestoneTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
A milestone defined by an end-of-life advisory.

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
Type: TamMilestone.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StartOffset
Number of days (inclusive) relative to the milestone date when the milestone is considered to be in effect. A nagative number indicates number of days ahead of the milestone date. The default is 0 which means the milestone take effect exactly on the same date as the specified milestone date. A negative value of -2147483648 (0x80000000) indicates the milestone date range&apos;s lower bound is omitted.

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
PS C:\> Initialize-IntersightTamMilestone
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightDateTime](./Initialize-IntersightDateTime.md)
