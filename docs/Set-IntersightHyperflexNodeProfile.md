---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightHyperflexNodeProfile

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightHyperflexNodeProfile [-Action< string>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AssignedServer< ComputePhysicalRelationship>][-ClusterProfile< HyperflexClusterProfileRelationship>][-ConfigContext< PolicyConfigContext>][-Description< string>][-HxdpDataIp< string>][-HxdpMgmtIp< string>][-HxdpStorageClientIp< string>][-HypervisorControlIp< string>][-HypervisorDataIp< string>][-HypervisorMgmtIp< string>][[-Moid]< string>][-Name< string>][-PolicyBucket< System.Collections.Generic.List`1[PolicyAbstractPolicyRelationship]>][-SrcTemplate< PolicyAbstractProfileRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Type< HyperflexNodeProfile.TypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;HyperflexNodeProfile&apos; resource.

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

### -ClusterProfile
A reference to a hyperflexClusterProfile resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: HyperflexClusterProfileRelationship
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

### -HxdpDataIp
IP address for storage data network (Controller VM interface).

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

### -HxdpMgmtIp
IP address for HyperFlex management network.

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

### -HxdpStorageClientIp
IP address for storage client network (Controller VM interface).

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

### -HypervisorControlIp
IP address for hypervisor control such as VM migration or pod management.

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

### -HypervisorDataIp
IP address for storage data network (Hypervisor interface).

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

### -HypervisorMgmtIp
IP address for Hypervisor management network.

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

Required: true
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

### -Type
Defines the type of the profile. Accepted values are instance or template.\n* `instance` - The profile defines the configuration for a specific instance of a target.

```yaml
Type: HyperflexNodeProfile.TypeEnum
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
PS C:\> Set-IntersightHyperflexNodeProfile
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Remove-IntersightHyperflexNodeProfile](./Remove-IntersightHyperflexNodeProfile.md)

[New-IntersightHyperflexNodeProfile](./New-IntersightHyperflexNodeProfile.md)

[Get-IntersightHyperflexNodeProfile](./Get-IntersightHyperflexNodeProfile.md)

[Initialize-IntersightPolicyConfigContext](./Initialize-IntersightPolicyConfigContext.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
