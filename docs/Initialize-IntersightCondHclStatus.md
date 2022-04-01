---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightCondHclStatus

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightCondHclStatus [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< CondHclStatus.ClassIdEnum>][-ComponentStatus< CondHclStatus.ComponentStatusEnum>][-HardwareStatus< CondHclStatus.HardwareStatusEnum>][-HclFirmwareVersion< string>][-HclModel< string>][-HclOsVendor< string>][-HclOsVersion< string>][-HclProcessor< string>][-InvFirmwareVersion< string>][-InvModel< string>][-InvOsVendor< string>][-InvOsVersion< string>][-InvProcessor< string>][-Moid< string>][-ObjectType< CondHclStatus.ObjectTypeEnum>][-Reason< CondHclStatus.ReasonEnum>][-ServerReason< CondHclStatus.ServerReasonEnum>][-SoftwareStatus< CondHclStatus.SoftwareStatusEnum>][-Status< CondHclStatus.StatusEnum>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: CondHclStatus.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ComponentStatus
The overall status for the components found in the HCL. This will provide the HCL validation status for all the components. It can be one of the following. \&quot;Validated\&quot; - all the components hardware/software profiles are listed in the HCL. \&quot;Not-Listed\&quot; - one or more components hardware/software profiles are not listed in the HCL \&quot;Incomplete\&quot; - the components are not evaluated as the server&apos;s software/hardware profiles are not listed in the HCL. \&quot;Not-Evaluated\&quot; - The components are not evaluated against the HCL because it is exempted.\n* `Incomplete` - This means we do not have os information in Intersight for this server. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Not-Found` - At HclStatus level, this means that one of the components has failed validation. At HclStatusDetail level, this means that his component&apos;s hardware or software profile was not found in the HCL.\n* `Not-Listed` - At the HclStatus level, this means that some part of the HCL validation has failed. This could be that either the server&apos;s hardware or software profile was not listed in the HCL or one of the components&apos; hardware or software profile was not found in the HCL.\n* `Validated` - At the HclStatus level, this means that all of the components have passed validation. At HclStatusDetail level, this means that the component&apos;s hardware or software profile was found in the HCL.\n* `Not-Evaluated` - At the HclStatus level this means that this means that SW or Component status has not been evaluated as the previous evaluation step has not passed yet. At the HclStatusDetail level this means that either HW or SW status has not been evaluted because a previous evaluation step has not passed yet.

```yaml
Type: CondHclStatus.ComponentStatusEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HardwareStatus
The server model, processor and firmware are considered as part of the hardware profile for the server. This will provide the HCL validation status for the hardware profile. For the failure reason see the serverReason property. The status can be one of the following \&quot;Validated\&quot; - The server model, processor and firmware combination is listed in the HCL \&quot;Not-Listed\&quot; - The server model, processor and firmware combination is not listed in the HCL. \&quot;Not-Evaluated\&quot; - The server is not evaluated against the HCL because it is exempted.\n* `Incomplete` - This means we do not have os information in Intersight for this server. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Not-Found` - At HclStatus level, this means that one of the components has failed validation. At HclStatusDetail level, this means that his component&apos;s hardware or software profile was not found in the HCL.\n* `Not-Listed` - At the HclStatus level, this means that some part of the HCL validation has failed. This could be that either the server&apos;s hardware or software profile was not listed in the HCL or one of the components&apos; hardware or software profile was not found in the HCL.\n* `Validated` - At the HclStatus level, this means that all of the components have passed validation. At HclStatusDetail level, this means that the component&apos;s hardware or software profile was found in the HCL.\n* `Not-Evaluated` - At the HclStatus level this means that this means that SW or Component status has not been evaluated as the previous evaluation step has not passed yet. At the HclStatusDetail level this means that either HW or SW status has not been evaluted because a previous evaluation step has not passed yet.

```yaml
Type: CondHclStatus.HardwareStatusEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HclFirmwareVersion
The current CIMC version for the server normalized for querying HCL data. It is empty if we are missing this information.

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

### -HclModel
The managed object&apos;s model to validate normalized for querying HCL data. It is empty if we are missing this information.

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

### -HclOsVendor
The OS Vendor for the managed object to validate normalized for querying HCL data. It is empty if we are missing this information.

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

### -HclOsVersion
The OS Version for the managed object to validate normalized for querying HCL data. It is empty if we are missing this information.

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

### -HclProcessor
The managed object&apos;s processor to validate if applicable normalized for querying HCL data. It is empty if we are missing this information.

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

### -InvFirmwareVersion
The current CIMC version for the server as received from inventory. It is empty if we are missing this information.

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

### -InvModel
The managed object&apos;s model to validate as received from the inventory. It is empty if we are missing this information.

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

### -InvOsVendor
The OS Vendor for the managed object to validate as received from inventory. It is empty if we are missing this information.

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

### -InvOsVersion
The OS Version for the managed object to validate as received from inventory. It is empty if we are missing this information.

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

### -InvProcessor
The managed object&apos;s processor to validate if applicable as received from inventory. It is empty if we are missing this information.

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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: CondHclStatus.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Reason
The reason for the HCL status. It will be one of the following \&quot;Missing-Os-Info\&quot; - we are missing os information in the inventory from the device connector \&quot;Incompatible-Components\&quot; - we have 1 or more components with \&quot;Not-Validated\&quot; status \&quot;Compatible\&quot; - all the components have \&quot;Validated\&quot; status. \&quot;Not-Evaluated\&quot; - The server is not evaluated against the HCL because it is exempted.\n* `Missing-Os-Info` - This means the HclStatus for the sever failed HCL validation because we have missing os information. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Components` - This means the HclStatus for the sever failed HCL validation because one or more of its components failed validation. To see why components failed check the related HclStatusDetails.\n* `Compatible` - This means the HclStatus for the sever has passed HCL validation for all of its related components.\n* `Not-Evaluated` - This means the HclStatus for the sever has not been evaluated because it is exempted.

```yaml
Type: CondHclStatus.ReasonEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServerReason
The reason generated by the server&apos;s HCL validation. For HCL the evaluation can be seen in three logical stages 1. Evaluate the server&apos;s hardware status 2. Evaluate the server&apos;s software status 3. Evaluate the server&apos;s components (each component has its own hardware/software evaluation) The evaluation does not proceed to the next stage until the previous stage is evaluated. Therefore there can be only one validation reason. \&quot;Incompatible-Server\&quot; - the server model is not listed in the HCL. \&quot;Incompatible-Processor\&quot; - the server model and processor combination is not listed in HCL. \&quot;Incompatible-Firmware\&quot; - the server model, processor and server firmware is not listed in HCL. \&quot;Missing-Os-Info\&quot; - the os vendor and version is not listed in HCL with the HW profile. \&quot;Incompatible-Os-Info\&quot; - the os vendor and version is not listed in HCL with the HW profile. \&quot;Incompatible-Components\&quot; - there is one or more components with \&quot;Not-Validated\&quot; status \&quot;Service-Unavailable\&quot; - HCL data service is unavailable at the moment (try again later). \&quot;Compatible\&quot; - the server and all its components are validated. \&quot;Not-Evaluated\&quot; - The server is not evaluated against the HCL because it is exempted.\n* `Missing-Os-Driver-Info` - The validation failed becaue the given server has no OS driver information available in the inventory. Either install UCS Tools VIB on the host ESXi or use OS Discovery Tool scripts to provide proper OS information.\n* `Incompatible-Server` - The validation failed for this server because the server&apos;s model was not listed in the HCL.\n* `Incompatible-Processor` - The validation failed because the given processor was not listed for the given server model.\n* `Incompatible-Os-Info` - The validation failed because the given OS vendor or version was not listed in HCL for the server PID and processor combination.\n* `Incompatible-Firmware` - The validation failed because the given server firmware was not listed in the HCL for the given server PID, processor, OS vendor and version.\n* `Service-Unavailable` - The validation has failed because HCL data service is temporarily not available. The server will be re-evaluated once HCL data service is back online or finished importing new HCL data.\n* `Service-Error` - The validation has failed because the HCL data service has returned a service error or unrecognized result.\n* `Not-Evaluated` - This means the HclStatus for the sever has not been evaluated because it is exempted.\n* `Incompatible-Components` - The validation has failed for this server because one or more components have \&quot;Not-Listed\&quot; status.\n* `Compatible` - The validation has passed for this server&apos;s model, processor, OS vendor and version.

```yaml
Type: CondHclStatus.ServerReasonEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SoftwareStatus
The OS vendor and version are considered part of the software profile for the server. This will provide the HCL validation status for the software profile. For the failure reason see the serverReason property. The status can be be one of the following \&quot;Validated\&quot; - The os vendor/version is listed in the HCL for the server model, processor and firmware \&quot;Not-Listed\&quot; - The os vendor/version is not listed in the HCL for the server model, processor and firmware \&quot;Incomplete\&quot; - The inventory is missing os vendor/version and HCL validation was not performed. \&quot;Not-Evaluated\&quot; - The server is not evaluated against the HCL because it is exempted.\n* `Incomplete` - This means we do not have os information in Intersight for this server. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Not-Found` - At HclStatus level, this means that one of the components has failed validation. At HclStatusDetail level, this means that his component&apos;s hardware or software profile was not found in the HCL.\n* `Not-Listed` - At the HclStatus level, this means that some part of the HCL validation has failed. This could be that either the server&apos;s hardware or software profile was not listed in the HCL or one of the components&apos; hardware or software profile was not found in the HCL.\n* `Validated` - At the HclStatus level, this means that all of the components have passed validation. At HclStatusDetail level, this means that the component&apos;s hardware or software profile was found in the HCL.\n* `Not-Evaluated` - At the HclStatus level this means that this means that SW or Component status has not been evaluated as the previous evaluation step has not passed yet. At the HclStatusDetail level this means that either HW or SW status has not been evaluted because a previous evaluation step has not passed yet.

```yaml
Type: CondHclStatus.SoftwareStatusEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Status
The HCL compatibility status of the managed object. The status can be one of the following \&quot;Incomplete\&quot; - there is no enough information to evaluate against the HCL data \&quot;Validated\&quot; - all components have been evaluated against the HCL and they all have \&quot;Validated\&quot; status \&quot;Not-Listed\&quot; - all components have been evaluated against the HCL and one or more have \&quot;Not-Listed\&quot; status. \&quot;Not-Evaluated\&quot; - server is not evaluated against the HCL because it is exempted.\n* `Incomplete` - This means we do not have os information in Intersight for this server. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Not-Found` - At HclStatus level, this means that one of the components has failed validation. At HclStatusDetail level, this means that his component&apos;s hardware or software profile was not found in the HCL.\n* `Not-Listed` - At the HclStatus level, this means that some part of the HCL validation has failed. This could be that either the server&apos;s hardware or software profile was not listed in the HCL or one of the components&apos; hardware or software profile was not found in the HCL.\n* `Validated` - At the HclStatus level, this means that all of the components have passed validation. At HclStatusDetail level, this means that the component&apos;s hardware or software profile was found in the HCL.\n* `Not-Evaluated` - At the HclStatus level this means that this means that SW or Component status has not been evaluated as the previous evaluation step has not passed yet. At the HclStatusDetail level this means that either HW or SW status has not been evaluted because a previous evaluation step has not passed yet.

```yaml
Type: CondHclStatus.StatusEnum
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
PS C:\> Initialize-IntersightCondHclStatus
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)
