---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightKubernetesHyperFlexApVirtualMachineInfraConfig

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightKubernetesHyperFlexApVirtualMachineInfraConfig [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< KubernetesHyperFlexApVirtualMachineInfraConfig.ClassIdEnum>][-DiskMode< KubernetesHyperFlexApVirtualMachineInfraConfig.DiskModeEnum>][-Interfaces< System.Collections.Generic.List`1[string]>][-NetworkInterfaces< System.Collections.Generic.List`1[Model.KubernetesNetworkInterfaceSpec]>][-ObjectType< KubernetesHyperFlexApVirtualMachineInfraConfig.ObjectTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: KubernetesHyperFlexApVirtualMachineInfraConfig.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DiskMode
Disk mode to use for volumes.\n* `Block` - It is a Block virtual disk.\n* `Filesystem` - It is a File system virtual disk.\n* `` - Disk mode is either unknown or not supported.

```yaml
Type: KubernetesHyperFlexApVirtualMachineInfraConfig.DiskModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Interfaces


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

### -NetworkInterfaces


Note :- Use Initialize-IntersightKubernetesNetworkInterfaceSpec to create the object of complex type KubernetesNetworkInterfaceSpec

```yaml
Type: System.Collections.Generic.List`1[Model.KubernetesNetworkInterfaceSpec]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.

```yaml
Type: KubernetesHyperFlexApVirtualMachineInfraConfig.ObjectTypeEnum
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
PS C:\> Initialize-IntersightKubernetesHyperFlexApVirtualMachineInfraConfig
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightKubernetesNetworkInterfaceSpec](./Initialize-IntersightKubernetesNetworkInterfaceSpec.md)
