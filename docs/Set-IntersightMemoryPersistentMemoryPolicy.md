---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightMemoryPersistentMemoryPolicy

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightMemoryPersistentMemoryPolicy [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Description< string>][-Goals< System.Collections.Generic.List`1[MemoryPersistentMemoryGoal]>][-LocalSecurity< MemoryPersistentMemoryLocalSecurity>][-LogicalNamespaces< System.Collections.Generic.List`1[MemoryPersistentMemoryLogicalNamespace]>][-ManagementMode< MemoryPersistentMemoryPolicy.ManagementModeEnum>][[-Moid]< string>][-Name< string>][-Organization< OrganizationOrganizationRelationship>][-Profiles< System.Collections.Generic.List`1[PolicyAbstractConfigProfileRelationship]>][-RetainNamespaces< bool>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;MemoryPersistentMemoryPolicy&apos; resource.

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

### -Goals


Note :- Use Initialize-IntersightMemoryPersistentMemoryGoal to create the object of complex type MemoryPersistentMemoryGoal

```yaml
Type: System.Collections.Generic.List`1[MemoryPersistentMemoryGoal]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LocalSecurity
Local security for the Persistent Memory Modules on the server.

Note :- Use Initialize-IntersightMemoryPersistentMemoryLocalSecurity to create the object of complex type MemoryPersistentMemoryLocalSecurity

```yaml
Type: MemoryPersistentMemoryLocalSecurity
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LogicalNamespaces


Note :- Use Initialize-IntersightMemoryPersistentMemoryLogicalNamespace to create the object of complex type MemoryPersistentMemoryLogicalNamespace

```yaml
Type: System.Collections.Generic.List`1[MemoryPersistentMemoryLogicalNamespace]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ManagementMode
Management Mode of the policy. This can be either Configured from Intersight or Configured from Operating System.\n* `configured-from-intersight` - The Persistent Memory Modules are configured from Intersight thorugh Persistent Memory policy.\n* `configured-from-operating-system` - The Persistent Memory Modules are configured from operating system thorugh OS tools.

```yaml
Type: MemoryPersistentMemoryPolicy.ManagementModeEnum
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
Name of the concrete policy.

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

### -RetainNamespaces
Persistent Memory Namespaces to be retained or not.

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
PS C:\> Set-IntersightMemoryPersistentMemoryPolicy
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightMemoryPersistentMemoryPolicy](./Get-IntersightMemoryPersistentMemoryPolicy.md)

[New-IntersightMemoryPersistentMemoryPolicy](./New-IntersightMemoryPersistentMemoryPolicy.md)

[Remove-IntersightMemoryPersistentMemoryPolicy](./Remove-IntersightMemoryPersistentMemoryPolicy.md)

[Initialize-IntersightMemoryPersistentMemoryGoal](./Initialize-IntersightMemoryPersistentMemoryGoal.md)

[Initialize-IntersightMemoryPersistentMemoryLocalSecurity](./Initialize-IntersightMemoryPersistentMemoryLocalSecurity.md)

[Initialize-IntersightMemoryPersistentMemoryLogicalNamespace](./Initialize-IntersightMemoryPersistentMemoryLogicalNamespace.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
