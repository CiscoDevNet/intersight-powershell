---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightComputeServerSetting

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightComputeServerSetting [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AdminLocatorLedState< ComputeServerSetting.AdminLocatorLedStateEnum>][-AdminPowerState< ComputeServerSetting.AdminPowerStateEnum>][-CertificatesAction< Model.CertificatemanagementCertificateBase>][-ClassId< ComputeServerSetting.ClassIdEnum>][-CmosReset< ComputeServerSetting.CmosResetEnum>][-FrontPanelLockState< ComputeServerSetting.FrontPanelLockStateEnum>][-KvmReset< ComputeServerSetting.KvmResetEnum>][-Moid< string>][-ObjectType< ComputeServerSetting.ObjectTypeEnum>][-OneTimeBootDevice< string>][-PersistentMemoryOperation< Model.ComputePersistentMemoryOperation>][-ServerConfig< Model.ComputeServerConfig>][-ServerOpStatus< System.Collections.Generic.List`1[Model.ComputeServerOpStatus]>][-StorageControllerOperation< Model.ComputeStorageControllerOperation>][-StoragePhysicalDriveOperation< Model.ComputeStoragePhysicalDriveOperation>][-StorageVirtualDriveOperation< Model.ComputeStorageVirtualDriveOperation>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-TunneledKvmState< ComputeServerSetting.TunneledKvmStateEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -CertificatesAction
Certificates Action configures the Certificate and PrivateKey at the endpoint.

Note :- Use Initialize-IntersightCertificatemanagementCertificateBase to create the object of complex type CertificatemanagementCertificateBase

```yaml
Type: Model.CertificatemanagementCertificateBase
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
Type: ComputeServerSetting.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CmosReset
The allowed actions on the CMOS Reset.\n* `Ready` - CMOS Reset operation is allowed to be done on the server in this state.\n* `Pending` - The identifier to state that the previous CMOS Reset operation on this server has not completed due to a pending power cycle. CMOS Reset operation cannot be done on the server when in this state.\n* `Reset` - The value that the UI/API needs to provide to trigger a CMOS Reset operation on a server.

```yaml
Type: ComputeServerSetting.CmosResetEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FrontPanelLockState
The allowed actions on the Front Panel Lock.\n* `Unlock` - Front Panel of the server is set to Unlocked state.\n* `Lock` - Front Panel of the server is set to Locked state.

```yaml
Type: ComputeServerSetting.FrontPanelLockStateEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -KvmReset
The allowed actions on the vKVM Reset.\n* `Ready` - Reset vKVM operation is allowed to be done on the server in this state.\n* `Reset` - The value that the UI/API needs to provide to trigger a Reset vKVM operation on a server.

```yaml
Type: ComputeServerSetting.KvmResetEnum
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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.

```yaml
Type: ComputeServerSetting.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
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
Type: Model.ComputePersistentMemoryOperation
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
Type: Model.ComputeServerConfig
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServerOpStatus


Note :- Use Initialize-IntersightComputeServerOpStatus to create the object of complex type ComputeServerOpStatus

```yaml
Type: System.Collections.Generic.List`1[Model.ComputeServerOpStatus]
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
Type: Model.ComputeStorageControllerOperation
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
Type: Model.ComputeStoragePhysicalDriveOperation
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
Type: Model.ComputeStorageVirtualDriveOperation
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
Type: System.Collections.Generic.List`1[Model.MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TunneledKvmState
By default, the tunneled vKVM property appears in Ready state. The property can be configured by performing allowed actions. Once the property is configured, it reverts to Ready state.\n* `Ready` - Tunneled vKVM is ready to be configured on the server.\n* `Enable` - Tunneled vKVM is enabled for the server.\n* `Disable` - Tunneled vKVM is disabled for the server.

```yaml
Type: ComputeServerSetting.TunneledKvmStateEnum
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
PS C:\> Initialize-IntersightComputeServerSetting
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightCertificatemanagementCertificateBase](./Initialize-IntersightCertificatemanagementCertificateBase.md)

[Initialize-IntersightComputePersistentMemoryOperation](./Initialize-IntersightComputePersistentMemoryOperation.md)

[Initialize-IntersightComputeServerConfig](./Initialize-IntersightComputeServerConfig.md)

[Initialize-IntersightComputeServerOpStatus](./Initialize-IntersightComputeServerOpStatus.md)

[Initialize-IntersightComputeStorageControllerOperation](./Initialize-IntersightComputeStorageControllerOperation.md)

[Initialize-IntersightComputeStoragePhysicalDriveOperation](./Initialize-IntersightComputeStoragePhysicalDriveOperation.md)

[Initialize-IntersightComputeStorageVirtualDriveOperation](./Initialize-IntersightComputeStorageVirtualDriveOperation.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)
