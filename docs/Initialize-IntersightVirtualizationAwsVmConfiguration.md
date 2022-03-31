---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightVirtualizationAwsVmConfiguration

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightVirtualizationAwsVmConfiguration [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AvailabilityZoneId< string>][-ClassId< VirtualizationAwsVmConfiguration.ClassIdEnum>][-Compute< Model.VirtualizationCloudVmComputeConfiguration>][-ImageId< string>][-KeyPairName< string>][-Network< Model.VirtualizationCloudVmNetworkConfiguration>][-ObjectType< VirtualizationAwsVmConfiguration.ObjectTypeEnum>][-RegionId< string>][-SecurityGroups< System.Collections.Generic.List`1[string]>][-Storage< Model.VirtualizationCloudVmStorageConfiguration>][-VmId< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -AvailabilityZoneId
Availability zone for the VM.

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
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type.

```yaml
Type: VirtualizationAwsVmConfiguration.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Compute
Cloud virtual machine compute specifications.

Note :- Use Initialize-IntersightVirtualizationCloudVmComputeConfiguration to create the object of complex type VirtualizationCloudVmComputeConfiguration

```yaml
Type: Model.VirtualizationCloudVmComputeConfiguration
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ImageId
Virtual machine image used by this VM.

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

### -KeyPairName
Keypair for accessing the VM.

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

### -Network
Cloud virtual machine network specifications.

Note :- Use Initialize-IntersightVirtualizationCloudVmNetworkConfiguration to create the object of complex type VirtualizationCloudVmNetworkConfiguration

```yaml
Type: Model.VirtualizationCloudVmNetworkConfiguration
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type.

```yaml
Type: VirtualizationAwsVmConfiguration.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RegionId
Region where the VM instance is created.

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

### -SecurityGroups


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

### -Storage
Cloud Virtual machine disk information.

Note :- Use Initialize-IntersightVirtualizationCloudVmStorageConfiguration to create the object of complex type VirtualizationCloudVmStorageConfiguration

```yaml
Type: Model.VirtualizationCloudVmStorageConfiguration
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmId
Unique Identifier of the cloud VM.

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
PS C:\> Initialize-IntersightVirtualizationAwsVmConfiguration
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightVirtualizationCloudVmComputeConfiguration](./Initialize-IntersightVirtualizationCloudVmComputeConfiguration.md)

[Initialize-IntersightVirtualizationCloudVmNetworkConfiguration](./Initialize-IntersightVirtualizationCloudVmNetworkConfiguration.md)

[Initialize-IntersightVirtualizationCloudVmStorageConfiguration](./Initialize-IntersightVirtualizationCloudVmStorageConfiguration.md)
