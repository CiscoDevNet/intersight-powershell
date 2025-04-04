---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightServerProfile

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightServerProfile [-Action< string>][-ActionParams< System.Collections.Generic.List`1[PolicyActionParam]>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AssignedServer< ComputePhysicalRelationship>][-AssociatedServerPool< ResourcepoolPoolRelationship>][-ConfigContext< PolicyConfigContext>][-Description< string>][-LeasedServer< ComputePhysicalRelationship>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-PmcDeployedSecurePassphrase< string>][-PolicyBucket< System.Collections.Generic.List`1[PolicyAbstractPolicyRelationship]>][-ReservationReferences< System.Collections.Generic.List`1[PoolReservationReference]>][-ScheduledActions< System.Collections.Generic.List`1[PolicyScheduledAction]>][-ServerAssignmentMode< ServerProfile.ServerAssignmentModeEnum>][-ServerPool< ResourcepoolPoolRelationship>][-ServerPreAssignBySerial< string>][-ServerPreAssignBySlot< ServerServerAssignTypeSlot>][-SrcTemplate< PolicyAbstractProfileRelationship>][-StaticUuidAddress< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TargetPlatform< ServerProfile.TargetPlatformEnum>][-TemplateActions< System.Collections.Generic.List`1[MotemplateActionEntry]>][-Type< ServerProfile.TypeEnum>][-UserLabel< string>][-UuidAddressType< ServerProfile.UuidAddressTypeEnum>][-UuidPool< UuidpoolPoolRelationship>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;ServerProfile&apos; resource.

## PARAMETERS

### -Action
User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign.

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

### -ActionParams


Note :- Use Initialize-IntersightPolicyActionParam to create the object of complex type PolicyActionParam

```yaml
Type: System.Collections.Generic.List`1[PolicyActionParam]
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

### -AssignedServer
A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: ComputePhysicalRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AssociatedServerPool
A reference to a resourcepoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: ResourcepoolPoolRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ConfigContext
The configuration state and results of the last configuration operation.

Note :- Use Initialize-IntersightPolicyConfigContext to create the object of complex type PolicyConfigContext

```yaml
Type: PolicyConfigContext
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Description of the profile.

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

### -LeasedServer
A reference to a computePhysical resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: ComputePhysicalRelationship
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

### -Name
Name of the profile instance or profile template.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True False
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

### -PmcDeployedSecurePassphrase
Secure passphrase that is already deployed on all the Persistent Memory Modules on the server. This deployed passphrase is required during deploy of server profile if secure passphrase is changed or security is disabled in the attached persistent memory policy.

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

### -PolicyBucket
An array of relationships to policyAbstractPolicy resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[PolicyAbstractPolicyRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ReservationReferences


Note :- Use Initialize-IntersightPoolReservationReference to create the object of complex type PoolReservationReference

```yaml
Type: System.Collections.Generic.List`1[PoolReservationReference]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ScheduledActions


Note :- Use Initialize-IntersightPolicyScheduledAction to create the object of complex type PolicyScheduledAction

```yaml
Type: System.Collections.Generic.List`1[PolicyScheduledAction]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServerAssignmentMode
Source of the server assigned to the Server Profile. Values can be Static, Pool or None. Static is used if a server is attached directly to a Server Profile. Pool is used if a resource pool is attached to a Server Profile. None is used if no server or resource pool is attached to a Server Profile. Slot or Serial pre-assignment is also considered to be None as it is different form of Assign Later.\n* `None` - No server is assigned to the server profile.\n* `Static` - Server is directly assigned to server profile using assign server.\n* `Pool` - Server is assigned from a resource pool.

```yaml
Type: ServerProfile.ServerAssignmentModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServerPool
A reference to a resourcepoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: ResourcepoolPoolRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServerPreAssignBySerial
Serial number of the server that would be assigned to this pre-assigned Server Profile. It can be any string that adheres to the following constraints:\nIt should start and end with an alphanumeric character.\nIt cannot be more than 20 characters.

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

### -ServerPreAssignBySlot
Server profile is pre-assigned to a server using slot.

Note :- Use Initialize-IntersightServerServerAssignTypeSlot to create the object of complex type ServerServerAssignTypeSlot

```yaml
Type: ServerServerAssignTypeSlot
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SrcTemplate
A reference to a policyAbstractProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: PolicyAbstractProfileRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StaticUuidAddress
The UUID address for the server must include UUID prefix xxxxxxxx-xxxx-xxxx along with the UUID suffix of format xxxx-xxxxxxxxxxxx.

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

### -TargetPlatform
The platform for which the server profile is applicable. It can either be a server that is operating in standalone mode or which is attached to a Fabric Interconnect managed by Intersight.\n* `Standalone` - Servers which are operating in standalone mode i.e. not connected to a Fabric Interconnected.\n* `FIAttached` - Servers which are connected to a Fabric Interconnect that is managed by Intersight.

```yaml
Type: ServerProfile.TargetPlatformEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -TemplateActions


Note :- Use Initialize-IntersightMotemplateActionEntry to create the object of complex type MotemplateActionEntry

```yaml
Type: System.Collections.Generic.List`1[MotemplateActionEntry]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Type
Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target.

```yaml
Type: ServerProfile.TypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UserLabel
User label assigned to the server profile.

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

### -UuidAddressType
UUID address allocation type selected to assign an UUID address for the server.\n* `NONE` - The user did not assign any UUID address.\n* `STATIC` - The user assigns a static UUID address.\n* `POOL` - The user selects a pool from which the address will be leased.

```yaml
Type: ServerProfile.UuidAddressTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UuidPool
A reference to a uuidpoolPool resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: UuidpoolPoolRelationship
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
PS C:\> New-IntersightServerProfile
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightServerProfile](./Get-IntersightServerProfile.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightMotemplateActionEntry](./Initialize-IntersightMotemplateActionEntry.md)

[Initialize-IntersightMotemplateSyncError](./Initialize-IntersightMotemplateSyncError.md)

[Initialize-IntersightPolicyActionParam](./Initialize-IntersightPolicyActionParam.md)

[Initialize-IntersightPolicyConfigChange](./Initialize-IntersightPolicyConfigChange.md)

[Initialize-IntersightPolicyConfigChangeContext](./Initialize-IntersightPolicyConfigChangeContext.md)

[Initialize-IntersightPolicyConfigContext](./Initialize-IntersightPolicyConfigContext.md)

[Initialize-IntersightPolicyScheduledAction](./Initialize-IntersightPolicyScheduledAction.md)

[Initialize-IntersightPoolReservationReference](./Initialize-IntersightPoolReservationReference.md)

[Initialize-IntersightServerServerAssignTypeSlot](./Initialize-IntersightServerServerAssignTypeSlot.md)

[Remove-IntersightServerProfile](./Remove-IntersightServerProfile.md)

[Set-IntersightServerProfile](./Set-IntersightServerProfile.md)
