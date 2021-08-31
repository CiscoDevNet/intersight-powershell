---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightKubernetesVirtualMachineInfraConfigPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightKubernetesVirtualMachineInfraConfigPolicy [-AdditionalProperties< Dictionary<string,object>>][-Description< string>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-Profiles< List<KubernetesVirtualMachineInfrastructureProviderRelationship>>][-Tags< List<MoTag>>][-Target< AssetDeviceRegistrationRelationship>][-VmConfig< KubernetesBaseVirtualMachineInfraConfig>]

```

## DESCRIPTION
Update a &apos;KubernetesVirtualMachineInfraConfigPolicy&apos; resource.

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

### -Description
Description of the policy.

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

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
Name of the concrete policy.

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

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OrganizationOrganizationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Profiles
An array of relationships to kubernetesVirtualMachineInfrastructureProvider resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[KubernetesVirtualMachineInfrastructureProviderRelationship]
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

### -Target
A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: AssetDeviceRegistrationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -VmConfig
Virtual machine infrastucture provider allocation properties.

Note :- Use Initialize-IntersightKubernetesBaseVirtualMachineInfraConfig to create the object of complex type KubernetesBaseVirtualMachineInfraConfig

```yaml
Type: KubernetesBaseVirtualMachineInfraConfig
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-IntersightKubernetesVirtualMachineInfraConfigPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Remove-IntersightKubernetesVirtualMachineInfraConfigPolicy](./Remove-IntersightKubernetesVirtualMachineInfraConfigPolicy.md)

[Get-IntersightKubernetesVirtualMachineInfraConfigPolicy](./Get-IntersightKubernetesVirtualMachineInfraConfigPolicy.md)

[New-IntersightKubernetesVirtualMachineInfraConfigPolicy](./New-IntersightKubernetesVirtualMachineInfraConfigPolicy.md)

[Initialize-IntersightKubernetesBaseVirtualMachineInfraConfig](./Initialize-IntersightKubernetesBaseVirtualMachineInfraConfig.md)
