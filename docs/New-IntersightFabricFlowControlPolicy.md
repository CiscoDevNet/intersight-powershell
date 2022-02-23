---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightFabricFlowControlPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightFabricFlowControlPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Description< string>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-PriorityFlowControlMode< FabricFlowControlPolicy.PriorityFlowControlModeEnum>][-ReceiveDirection< FabricFlowControlPolicy.ReceiveDirectionEnum>][-SendDirection< FabricFlowControlPolicy.SendDirectionEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;FabricFlowControlPolicy&apos; resource.

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

### -PriorityFlowControlMode
Configure PFC on a per-port basis to enable the no-drop behavior for the CoS as defined by the active network qos policy.\n* `auto` - Enables the no-drop CoS values to be advertised by the DCBXP and negotiated with the peer.A successful negotiation enables PFC on the no-drop CoS.Any failures because of a mismatch in the capability of peers causes the PFC not to be enabled.\n* `on` - Enables PFC on the local port regardless of the capability of the peers.

```yaml
Type: FabricFlowControlPolicy.PriorityFlowControlModeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ReceiveDirection
Link-level Flow Control configured in the receive direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State.

```yaml
Type: FabricFlowControlPolicy.ReceiveDirectionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SendDirection
Link-level Flow Control configured in the send direction.\n* `Disabled` - Admin configured Disabled State.\n* `Enabled` - Admin configured Enabled State.

```yaml
Type: FabricFlowControlPolicy.SendDirectionEnum
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
PS C:\> New-IntersightFabricFlowControlPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightFabricFlowControlPolicy](./Get-IntersightFabricFlowControlPolicy.md)

[Set-IntersightFabricFlowControlPolicy](./Set-IntersightFabricFlowControlPolicy.md)

[Remove-IntersightFabricFlowControlPolicy](./Remove-IntersightFabricFlowControlPolicy.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
