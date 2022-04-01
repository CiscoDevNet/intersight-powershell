---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightSnmpPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightSnmpPolicy [-AccessCommunityString< string>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-CommunityAccess< SnmpPolicy.CommunityAccessEnum>][-Description< string>][-Enabled< bool>][-EngineId< string>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-Profiles< System.Collections.Generic.List`1[PolicyAbstractConfigProfileRelationship]>][-SnmpPort< long>][-SnmpTraps< System.Collections.Generic.List`1[SnmpTrap]>][-SnmpUsers< System.Collections.Generic.List`1[SnmpUser]>][-SysContact< string>][-SysLocation< string>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TrapCommunity< string>][-V2Enabled< bool>][-V3Enabled< bool>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;SnmpPolicy&apos; resource.

## PARAMETERS

### -AccessCommunityString
The default SNMPv1, SNMPv2c community name or SNMPv3 username to include on any trap messages sent to the SNMP host. The name can be 18 characters long.

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

### -CommunityAccess
Controls access to the information in the inventory tables. Applicable only for SNMPv1 and SNMPv2c users.\n* `Disabled` - Blocks access to the information in the inventory tables.\n* `Limited` - Partial access to read the information in the inventory tables.\n* `Full` - Full access to read the information in the inventory tables.

```yaml
Type: SnmpPolicy.CommunityAccessEnum
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

### -Enabled
State of the SNMP Policy on the endpoint. If enabled, the endpoint sends SNMP traps to the designated host.

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

### -EngineId
User-defined unique identification of the static engine.

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

### -Name
Name of the concrete policy.

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

### -Profiles
An array of relationships to policyAbstractConfigProfile resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[PolicyAbstractConfigProfileRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SnmpPort
Port on which Cisco IMC SNMP agent runs. Enter a value between 1-65535. Reserved ports not allowed (22, 23, 80, 123, 389, 443, 623, 636, 2068, 3268, 3269).

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

### -SnmpTraps


Note :- Use Initialize-IntersightSnmpTrap to create the object of complex type SnmpTrap

```yaml
Type: System.Collections.Generic.List`1[SnmpTrap]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SnmpUsers


Note :- Use Initialize-IntersightSnmpUser to create the object of complex type SnmpUser

```yaml
Type: System.Collections.Generic.List`1[SnmpUser]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SysContact
Contact person responsible for the SNMP implementation. Enter a string up to 64 characters, such as an email address or a name and telephone number.

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

### -SysLocation
Location of host on which the SNMP agent (server) runs.

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

### -TrapCommunity
SNMP community group used for sending SNMP trap to other devices. Valid only for SNMPv2c users.

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

### -V2Enabled
State of the SNMP v2c on the endpoint. If enabled, the endpoint sends SNMP v2c properties to the designated host.

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

### -V3Enabled
State of the SNMP v3 on the endpoint. If enabled, the endpoint sends SNMP v3 properties to the designated host.

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
PS C:\> New-IntersightSnmpPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightSnmpPolicy](./Get-IntersightSnmpPolicy.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[Initialize-IntersightSnmpTrap](./Initialize-IntersightSnmpTrap.md)

[Initialize-IntersightSnmpUser](./Initialize-IntersightSnmpUser.md)

[Remove-IntersightSnmpPolicy](./Remove-IntersightSnmpPolicy.md)

[Set-IntersightSnmpPolicy](./Set-IntersightSnmpPolicy.md)
