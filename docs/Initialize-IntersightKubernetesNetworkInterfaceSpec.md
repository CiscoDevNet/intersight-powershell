---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightKubernetesNetworkInterfaceSpec

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightKubernetesNetworkInterfaceSpec [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< KubernetesNetworkInterfaceSpec.ClassIdEnum>][-Mtu< long>][-Name< string>][-ObjectType< KubernetesNetworkInterfaceSpec.ObjectTypeEnum>][-Pools< System.Collections.Generic.List`1[Model.MoMoRef]>][-ProviderName< string>][-Vrf< Model.MoMoRef>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: KubernetesNetworkInterfaceSpec.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Mtu
The MTU for this Network Interface.  If left blank a default value will apply by the Operating System.

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

### -Name
NetworkInterfaceSpec is the specification for network interfaces - including configuration of IP Pools and VRF to determine IP configuration, the operating system device settings, and virtual adapter network settings. It can be left empty when used with VirtualMachineInfraConfigPolicy - it will be filled out based on the hypervisor platform type and will match the naming and order of interfaces provided by the hypervisor.

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
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.

```yaml
Type: KubernetesNetworkInterfaceSpec.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Pools


Note :- Use Initialize-IntersightMoMoRef to create the object of complex type MoMoRef

```yaml
Type: System.Collections.Generic.List`1[Model.MoMoRef]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProviderName
In other words, to which named network from the Instructure Provider will the port be connected.

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

### -Vrf
Allows for reusing IP Pools across disconnected L2 segments for different Kubernetes clusters within an account. If not set, the VRF named (default) will be used.

Note :- Use Initialize-IntersightMoMoRef to create the object of complex type MoMoRef

```yaml
Type: Model.MoMoRef
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
PS C:\> Initialize-IntersightKubernetesNetworkInterfaceSpec
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightMoMoRef](./Initialize-IntersightMoMoRef.md)
