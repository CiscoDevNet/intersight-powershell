---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightNotificationDistributableMoCondition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightNotificationDistributableMoCondition [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< NotificationDistributableMoCondition.ClassIdEnum>][-Enabled< bool>][-ImageType< NotificationDistributableMoCondition.ImageTypeEnum>][-MoType< string>][-ObjectType< NotificationDistributableMoCondition.ObjectTypeEnum>][-Operations< System.Collections.Generic.List`1[NotificationDistributableMoCondition.OperationsEnum]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: NotificationDistributableMoCondition.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Enabled
The condition can be switched on/off with out necessity to change the subscription\nsettings: actions, conditions, etc.\nEx.: Subscription MO can be configured, but switched off.

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

### -ImageType
Image type for which user wants to create notification.\nThe list of valid values for Image type of notification.DistributableMoCondition is software.HyperflexBundleDistributable, software.ApplianceDistributableIntelligence,\nfirmware.Distributable, software.HciBundleDistributable.\n* `None` - Default value for DistributableObjectType enum.\n* `software.ApplianceDistributableIntelligence` - Object type for Appliance Intelligence updates related distributable.\n* `firmware.Distributable` - Object type for firmware related distributable.\n* `software.HyperflexBundleDistributable` - Object type for HyperFlex related distributable.\n* `software.ApplianceDistributableConnected` - Object type for Appliance related distributable. By Choosing this, user shows intent to use the downloaded image for Connected appliance. \n* `software.ApplianceDistributablePrivate` - Object type for Appliance related distributable. By Choosing this, user shows intent to use the downloaded image for Private appliance. \n* `software.UcsdBundleDistributable` - Object type for UCSD related distributable.\n* `software.HciBundleDistributable` - Object type for HCI Bundle related distributable.

```yaml
Type: NotificationDistributableMoCondition.ImageTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MoType
MoType for which the condition is created.

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
Type: NotificationDistributableMoCondition.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Operations


```yaml
Type: System.Collections.Generic.List`1[NotificationDistributableMoCondition.OperationsEnum]
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
PS C:\> Initialize-IntersightNotificationDistributableMoCondition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
