---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightCondAlarmRule

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightCondAlarmRule [-Account< IamAccountRelationship>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Description< string>][-Devices< System.Collections.Generic.List`1[MoBaseMoRelationship]>][[-Moid]< string>][-Name< string>][-State< CondAlarmRule.StateEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-ThresholdDefinitionStates< System.Collections.Generic.List`1[CondThresholdDefinitionState]>][-ThresholdDefinitions< System.Collections.Generic.List`1[CondThresholdDefinitionRelationship]>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;CondAlarmRule&apos; resource.

## PARAMETERS

### -Account
A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IamAccountRelationship
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

### -Description
Informative description of AlarmRule.

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

### -Devices
An array of relationships to moBaseMo resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[MoBaseMoRelationship]
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
A unique name assigned by the user to AlarmRule. This user-defined name acts as the identity field, ensuring that AlarmRule is distinctly identifiable within the account.

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

### -State
Controls the behavior of alarm processing depending upon the state. If Enabled, which is also the default behavior, the alarm is evaluated for the device based on the conditions specified in the ThresholdDefinition objects attached to it. If Disabled or SystemDisabled, alarm is not evaluated for the device and the existing alarms raised against the device is cleared.\n* `Enabled` - User initiated action which is also the default action that enables alarm evaluation for any condition that meets the criteria.\n* `Disabled` - User initiated action that disables alarm evaluation temporarily and clears the existing alarms.\n* `SystemDisabled` - System initiated action that disables alarm evaluation temporarily and clears the existing alarms once alarm limit per alarm rule is reached.

```yaml
Type: CondAlarmRule.StateEnum
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

### -ThresholdDefinitionStates


Note :- Use Initialize-IntersightCondThresholdDefinitionState to create the object of complex type CondThresholdDefinitionState

```yaml
Type: System.Collections.Generic.List`1[CondThresholdDefinitionState]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ThresholdDefinitions
An array of relationships to condThresholdDefinition resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[CondThresholdDefinitionRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IfMatch
For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
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
PS C:\> Set-IntersightCondAlarmRule
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightCondAlarmRule](./Get-IntersightCondAlarmRule.md)

[Initialize-IntersightCondThresholdDefinitionState](./Initialize-IntersightCondThresholdDefinitionState.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightCondAlarmRule](./New-IntersightCondAlarmRule.md)

[Remove-IntersightCondAlarmRule](./Remove-IntersightCondAlarmRule.md)
