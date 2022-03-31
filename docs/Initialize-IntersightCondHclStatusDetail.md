---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightCondHclStatusDetail

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightCondHclStatusDetail [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< CondHclStatusDetail.ClassIdEnum>][-HardwareStatus< CondHclStatusDetail.HardwareStatusEnum>][-HclCimcVersion< string>][-HclDriverName< string>][-HclDriverVersion< string>][-HclFirmwareVersion< string>][-HclModel< string>][-InvCimcVersion< string>][-InvDriverName< string>][-InvDriverVersion< string>][-InvFirmwareVersion< string>][-InvModel< string>][-Moid< string>][-ObjectType< CondHclStatusDetail.ObjectTypeEnum>][-Reason< CondHclStatusDetail.ReasonEnum>][-SoftwareStatus< CondHclStatusDetail.SoftwareStatusEnum>][-Status< CondHclStatusDetail.StatusEnum>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: CondHclStatusDetail.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HardwareStatus
The model is considered as part of the hardware profile for the component. This will provide the HCL validation status for the hardware profile. The reasons can be one of the following \&quot;Incompatible-Server-With-Component\&quot; - the server model and component combination is not listed in HCL \&quot;Incompatible-Firmware\&quot; - The server&apos;s firmware is not listed for this component&apos;s hardware profile \&quot;Incompatible-Component\&quot; - the component&apos;s model is not listed in the HCL \&quot;Service-Unavailable\&quot; - HCL data service is unavailable at the moment (try again later). This could be due to HCL data updating \&quot;Not-Evaluated\&quot; - the hardware profile was not evaulated for the component because the server&apos;s hw/sw status is not listed or server is exempted. \&quot;Compatible\&quot; - this component&apos;s hardware profile is listed in the HCL.\n* `Missing-Os-Driver-Info` - The validation failed becaue the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Server-With-Component` - The validation failed for this component because he server model and component model combination was not found in the HCL.\n* `Incompatible-Processor` - The validation failed because the given processor was not found for the given server PID.\n* `Incompatible-Os-Info` - The validation failed because the given OS vendor and version was not found in HCL for the server PID and processor combination.\n* `Incompatible-Component-Model` - The validation failed because the given Component model was not found in the HCL for the given server PID, processor, server Firmware and OS vendor and version.\n* `Incompatible-Firmware` - The validation failed because the given server firmware or adapter firmware was not found in the HCL for the given server PID, processor, OS vendor and version and component model.\n* `Incompatible-Driver` - The validation failed because the given driver version was not found in the HCL for the given Server PID, processor, OS vendor and version, server firmware and component firmware.\n* `Incompatible-Firmware-Driver` - The validation failed because the given component firmware and driver version was not found in the HCL for the given Server PID, processor, OS vendor and version and server firmware.\n* `Service-Unavailable` - The validation has failed because HCL data service is temporarily not available. The server will be re-evaluated once HCL data service is back online or finished importing new HCL data.\n* `Service-Error` - The validation has failed because the HCL data service has return a service error or unrecognized result.\n* `Unrecognized-Protocol` - The validation has failed for the HCL component because the HCL data service has return a validation reason that is unknown to this service. This reason is used as a default failure reason reason in case we cannot map the error reason received from the HCL data service unto one of the other enum values.\n* `Not-Evaluated` - The validation for the hardware or software HCL status was not yet evaluated because some previous validation had failed. For example if a server&apos;s hardware profile fails to validate with HCL, then the server&apos;s software status will not be evaluated.\n* `Compatible` - The validation has passed for this server PID, processor, OS vendor and version, component model, component firmware and driver version.

```yaml
Type: CondHclStatusDetail.HardwareStatusEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -HclCimcVersion
The current CIMC version for the server normalized for querying HCL data.

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

### -HclDriverName
The current driver name of the component we are validating normalized for querying HCL data.

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

### -HclDriverVersion
The current driver version of the component we are validating normalized for querying HCL data.

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

### -HclFirmwareVersion
The current firmware version of the component model normalized for querying HCL data.

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
The component model we are trying to validate normalized for querying HCL data.

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

### -InvCimcVersion
The current CIMC version for the server as received from inventory.

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

### -InvDriverName
The current driver name of the component we are validating as received from inventory.

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

### -InvDriverVersion
The current driver version of the component we are validating as received from inventory.

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
The current firmware version of the component model as received from inventory.

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
The component model we are trying to validate as received from inventory.

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
Type: CondHclStatusDetail.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Reason
The reason for the status. The reason can be one of \&quot;Incompatible-Server-With-Component\&quot; - HCL validation has failed because the server model is not validated with this component \&quot;Incompatible-Processor\&quot; - HCL validation has failed because the processor is not validated with this server \&quot;Incompatible-Os-Info\&quot; - HCL validation has failed because the os vendor and version is not validated with this server \&quot;Incompatible-Component-Model\&quot; - HCL validation has failed because the component model is not validated \&quot;Incompatible-Firmware\&quot; - HCL validation has failed because the component or server firmware version is not validated \&quot;Incompatible-Driver\&quot; - HCL validation has failed because the driver version is not validated \&quot;Incompatible-Firmware-Driver\&quot; - HCL validation has failed because the firmware version and driver version is not validated \&quot;Missing-Os-Driver-Info\&quot; - HCL validation was not performed because we are missing os driver information form the inventory \&quot;Service-Unavailable\&quot; - HCL data service is unavailable at the moment (try again later). This could be due to HCL data updating \&quot;Service-Error\&quot; - HCL data service is available but an error occured when making the request or parsing the response \&quot;Unrecognized-Protocol\&quot; - This service does not recognize the reason code in the response from the HCL data service \&quot;Compatible\&quot; - this component&apos;s inventory data has \&quot;Validated\&quot; status with the HCL. \&quot;Not-Evaluated\&quot; - The component is not evaluated against the HCL because the server is exempted.\n* `Missing-Os-Driver-Info` - The validation failed becaue the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Server-With-Component` - The validation failed for this component because he server model and component model combination was not found in the HCL.\n* `Incompatible-Processor` - The validation failed because the given processor was not found for the given server PID.\n* `Incompatible-Os-Info` - The validation failed because the given OS vendor and version was not found in HCL for the server PID and processor combination.\n* `Incompatible-Component-Model` - The validation failed because the given Component model was not found in the HCL for the given server PID, processor, server Firmware and OS vendor and version.\n* `Incompatible-Firmware` - The validation failed because the given server firmware or adapter firmware was not found in the HCL for the given server PID, processor, OS vendor and version and component model.\n* `Incompatible-Driver` - The validation failed because the given driver version was not found in the HCL for the given Server PID, processor, OS vendor and version, server firmware and component firmware.\n* `Incompatible-Firmware-Driver` - The validation failed because the given component firmware and driver version was not found in the HCL for the given Server PID, processor, OS vendor and version and server firmware.\n* `Service-Unavailable` - The validation has failed because HCL data service is temporarily not available. The server will be re-evaluated once HCL data service is back online or finished importing new HCL data.\n* `Service-Error` - The validation has failed because the HCL data service has return a service error or unrecognized result.\n* `Unrecognized-Protocol` - The validation has failed for the HCL component because the HCL data service has return a validation reason that is unknown to this service. This reason is used as a default failure reason reason in case we cannot map the error reason received from the HCL data service unto one of the other enum values.\n* `Not-Evaluated` - The validation for the hardware or software HCL status was not yet evaluated because some previous validation had failed. For example if a server&apos;s hardware profile fails to validate with HCL, then the server&apos;s software status will not be evaluated.\n* `Compatible` - The validation has passed for this server PID, processor, OS vendor and version, component model, component firmware and driver version.

```yaml
Type: CondHclStatusDetail.ReasonEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SoftwareStatus
The firmware, driver name and driver version are considered as part of the software profile for the component. This will provide the HCL validation status for the software profile. The reasons can be one of the following \&quot;Incompatible-Firmware\&quot; - the component&amp;apos;s firmware is not listed under the server&amp;apos;s hardware and software profile and the component&amp;apos;s hardware profile \&quot;Incompatible-Driver\&quot; - the component&amp;apos;s driver is not listed under the server&amp;apos;s hardware and software profile and the component&amp;apos;s hardware profile \&quot;Incompatible-Firmware-Driver\&quot; - the component&amp;apos;s firmware and driver are not listed under the server&amp;apos;s hardware and software profile and the component&amp;apos;s hardware profile \&quot;Service-Unavailable\&quot; - HCL data service is unavailable at the moment (try again later). This could be due to HCL data updating \&quot;Not-Evaluated\&quot; - the component&amp;apos;s hardware status was not evaluated because the server&amp;apos;s hardware or software profile is not listed or server is exempted. \&quot;Compatible\&quot; - this component&amp;apos;s hardware profile is listed in the HCL.\n* `Missing-Os-Driver-Info` - The validation failed becaue the given server has no OS driver information available in the inventory. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Incompatible-Server-With-Component` - The validation failed for this component because he server model and component model combination was not found in the HCL.\n* `Incompatible-Processor` - The validation failed because the given processor was not found for the given server PID.\n* `Incompatible-Os-Info` - The validation failed because the given OS vendor and version was not found in HCL for the server PID and processor combination.\n* `Incompatible-Component-Model` - The validation failed because the given Component model was not found in the HCL for the given server PID, processor, server Firmware and OS vendor and version.\n* `Incompatible-Firmware` - The validation failed because the given server firmware or adapter firmware was not found in the HCL for the given server PID, processor, OS vendor and version and component model.\n* `Incompatible-Driver` - The validation failed because the given driver version was not found in the HCL for the given Server PID, processor, OS vendor and version, server firmware and component firmware.\n* `Incompatible-Firmware-Driver` - The validation failed because the given component firmware and driver version was not found in the HCL for the given Server PID, processor, OS vendor and version and server firmware.\n* `Service-Unavailable` - The validation has failed because HCL data service is temporarily not available. The server will be re-evaluated once HCL data service is back online or finished importing new HCL data.\n* `Service-Error` - The validation has failed because the HCL data service has return a service error or unrecognized result.\n* `Unrecognized-Protocol` - The validation has failed for the HCL component because the HCL data service has return a validation reason that is unknown to this service. This reason is used as a default failure reason reason in case we cannot map the error reason received from the HCL data service unto one of the other enum values.\n* `Not-Evaluated` - The validation for the hardware or software HCL status was not yet evaluated because some previous validation had failed. For example if a server&amp;apos;s hardware profile fails to validate with HCL, then the server&amp;apos;s software status will not be evaluated.\n* `Compatible` - The validation has passed for this server PID, processor, OS vendor and version, component model, component firmware and driver version.

```yaml
Type: CondHclStatusDetail.SoftwareStatusEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Status
The status for the component model, firmware version, driver name, and driver version after validating against the HCL. The status can be one of the following \&quot;Unknown\&quot; - we do not have enough information to evaluate against the HCL data \&quot;Validated\&quot; - we have validated this component against the HCL and it has \&quot;Validated\&quot; status \&quot;Not-Validated\&quot; - we have validated this component against the HCL and it has \&quot;Not-Validated\&quot; status. \&quot;Not-Evaluated\&quot; - The component is not evaluated against the HCL because the server is exempted.\n* `Incomplete` - This means we do not have os information in Intersight for this server. Either install ucstools vib or use power shell scripts to tag proper OS information.\n* `Not-Found` - At HclStatus level, this means that one of the components has failed validation. At HclStatusDetail level, this means that his component&apos;s hardware or software profile was not found in the HCL.\n* `Not-Listed` - At the HclStatus level, this means that some part of the HCL validation has failed. This could be that either the server&apos;s hardware or software profile was not listed in the HCL or one of the components&apos; hardware or software profile was not found in the HCL.\n* `Validated` - At the HclStatus level, this means that all of the components have passed validation. At HclStatusDetail level, this means that the component&apos;s hardware or software profile was found in the HCL.\n* `Not-Evaluated` - At the HclStatus level this means that this means that SW or Component status has not been evaluated as the previous evaluation step has not passed yet. At the HclStatusDetail level this means that either HW or SW status has not been evaluted because a previous evaluation step has not passed yet.

```yaml
Type: CondHclStatusDetail.StatusEnum
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
PS C:\> Initialize-IntersightCondHclStatusDetail
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
