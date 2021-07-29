---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightComputeServerSetting

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightComputeServerSetting [-AdditionalProperties< Dictionary<string,object>>][-AdminLocatorLedState< ComputeServerSetting.AdminLocatorLedStateEnum>][-AdminPowerState< ComputeServerSetting.AdminPowerStateEnum>][[-Moid]< string>][-OneTimeBootDevice< string>][-PersistentMemoryOperation< ComputePersistentMemoryOperation>][-ServerConfig< ComputeServerConfig>][-StorageControllerOperation< ComputeStorageControllerOperation>][-StoragePhysicalDriveOperation< ComputeStoragePhysicalDriveOperation>][-StorageVirtualDriveOperation< ComputeStorageVirtualDriveOperation>][-Tags< List<MoTag>>]

```

## DESCRIPTION
Update a &apos;ComputeServerSetting&apos; resource.

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

### -AdminLocatorLedState
User configured state of the locator LED for the server.\n* `None` - No operation property for locator led.\n* `On` - The Locator Led is turned on.\n* `Off` - The Locator Led is turned off.

```yaml
Type: ComputeServerSetting.AdminLocatorLedStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AdminPowerState
User configured power state of the server.\n* `Policy` - Power state is set to the default value in the policy.\n* `PowerOn` - Power state of the server is set to On.\n* `PowerOff` - Power state is the server set to Off.\n* `PowerCycle` - Power state the server is reset.\n* `HardReset` - Power state the server is hard reset.\n* `Shutdown` - Operating system on the server is shut down.\n* `Reboot` - Power state of IMC is rebooted.

```yaml
Type: ComputeServerSetting.AdminPowerStateEnum
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

### -OneTimeBootDevice
The name of the device chosen by user for configuring One-Time Boot device.

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

### -PersistentMemoryOperation
The Persistent Memory Modules operation properties.

Note :- Use Initialize-IntersightComputePersistentMemoryOperation to create the object of complex type ComputePersistentMemoryOperation

```yaml
Type: ComputePersistentMemoryOperation
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServerConfig
The common server configurable properties between a server and a server profile.

Note :- Use Initialize-IntersightComputeServerConfig to create the object of complex type ComputeServerConfig

```yaml
Type: ComputeServerConfig
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StorageControllerOperation
The Storage Controller operation properties.

Note :- Use Initialize-IntersightComputeStorageControllerOperation to create the object of complex type ComputeStorageControllerOperation

```yaml
Type: ComputeStorageControllerOperation
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StoragePhysicalDriveOperation
The Storage Physical Drives operation properties.

Note :- Use Initialize-IntersightComputeStoragePhysicalDriveOperation to create the object of complex type ComputeStoragePhysicalDriveOperation

```yaml
Type: ComputeStoragePhysicalDriveOperation
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StorageVirtualDriveOperation
The Storage Virtual Drives operation properties.

Note :- Use Initialize-IntersightComputeStorageVirtualDriveOperation to create the object of complex type ComputeStorageVirtualDriveOperation

```yaml
Type: ComputeStorageVirtualDriveOperation
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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-IntersightComputeServerSetting
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightComputeServerSetting](./Get-IntersightComputeServerSetting.md)

[Initialize-IntersightComputePersistentMemoryOperation](./Initialize-IntersightComputePersistentMemoryOperation.md)

[Initialize-IntersightComputeServerConfig](./Initialize-IntersightComputeServerConfig.md)

[Initialize-IntersightComputeStorageControllerOperation](./Initialize-IntersightComputeStorageControllerOperation.md)

[Initialize-IntersightComputeStoragePhysicalDriveOperation](./Initialize-IntersightComputeStoragePhysicalDriveOperation.md)

[Initialize-IntersightComputeStorageVirtualDriveOperation](./Initialize-IntersightComputeStorageVirtualDriveOperation.md)
