---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightVirtualizationHost

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightVirtualizationHost [-Action< VirtualizationHost.ActionEnum>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Evacuate< bool>][-HostConfig< VirtualizationBaseHostConfiguration>][-MaintenanceState< VirtualizationHost.MaintenanceStateEnum>][[-Moid]< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;VirtualizationHost&apos; resource.

## PARAMETERS

### -Action
Action to be performed on a host (Create, PowerState, Migrate, Clone etc).\n* `None` - A place holder for the default value.\n* `EnterMaintenanceMode` - Put a host into maintenance mode.\n* `ExitMaintenanceMode` - Put a host into active mode.\n* `PowerOffStorageController` - Power off HyperFlex storage controller node running on selected hypervisor host.\n* `PowerOnStorageController` - Power on HyperFlex storage controller node running on selected hypervisor host.

```yaml
Type: VirtualizationHost.ActionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

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

### -Evacuate
If true, move powered-off and suspended virtual machines to other hosts in the cluster.

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

### -HostConfig
Virtual machine configuration to provision.

Note :- Use Initialize-IntersightVirtualizationBaseHostConfiguration to create the object of complex type VirtualizationBaseHostConfiguration

```yaml
Type: VirtualizationBaseHostConfiguration
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -MaintenanceState
Expected state of host. An action on the host (e.g., Enter Maintenance) may cause the host to be put into maintenance mode.\n* `None` - A place holder for the default value.\n* `Enter` - Power action is performed on the virtual machine.\n* `Exit` - The virtual machine will be migrated from existing node to a different node in cluster. The behavior depends on the underlying hypervisor.

```yaml
Type: VirtualizationHost.MaintenanceStateEnum
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
PS C:\> Set-IntersightVirtualizationHost
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightVirtualizationHost](./Get-IntersightVirtualizationHost.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightVirtualizationBaseHostConfiguration](./Initialize-IntersightVirtualizationBaseHostConfiguration.md)
