---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightBulkMoDeepCloner

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightBulkMoDeepCloner [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ExcludeProperties< System.Collections.Generic.List`1[string]>][-Moid< string>][-Organization< OrganizationOrganizationRelationship>][-ReferenceNameSuffix< string>][-ReferencePolicy< BulkMoDeepCloner.ReferencePolicyEnum>][-Source< MoMoRef>][-Tags< System.Collections.Generic.List`1[MoTag]>][-Targets< System.Collections.Generic.List`1[MoBaseMo]>][-WorkflowNameSuffix< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;BulkMoDeepCloner&apos; resource.

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

### -ExcludeProperties


```yaml
Type: System.Collections.Generic.List`1[string]
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

### -ReferenceNameSuffix
Name suffix to be applied to all the MOs being cloned when ReferencePolicy chosen is CreateNew. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_).

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

### -ReferencePolicy
User selected reference clone behavior. Applies to all the MOs being cloned.\n* `ReuseAll` - Any policies in the destination organization whose name matches the policy referenced in the cloned policy will be attached. If no policyin the destination organization matches by name, a policy will be cloned with the same name.Pool references will always be matched by name. If not found, the pool will be cloned in the destination organization, but no identifierblocks will be created.\n* `CreateNew` - New policies will be created for the source and all the attached policies. If a policy of the same name and type already exists in thedestination organization or any organization from which it shares policies, a clone will be created with the provided suffix added to the name.Pool references will always be matched by name. If not found, the pool will be cloned in the destination organization, but no identifierblocks will be created.

```yaml
Type: BulkMoDeepCloner.ReferencePolicyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Source
MoRef of the source instance.

Note :- Use Initialize-IntersightMoMoRef to create the object of complex type MoMoRef

```yaml
Type: MoMoRef
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

### -Targets


Note :- Use Initialize-IntersightMoBaseMo to create the object of complex type MoBaseMo

```yaml
Type: System.Collections.Generic.List`1[MoBaseMo]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -WorkflowNameSuffix
A user-friendly short name to identify the workflow. Name can only contain letters (a-z, A-Z),\nnumbers (0-9), hyphen (-), period (.), colon (:), space ( ), forward slash (/), comma or an underscore (_).

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
PS C:\> New-IntersightBulkMoDeepCloner
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightBulkMoDeepCloner](./Get-IntersightBulkMoDeepCloner.md)

[Initialize-IntersightMoBaseMo](./Initialize-IntersightMoBaseMo.md)

[Initialize-IntersightMoMoRef](./Initialize-IntersightMoMoRef.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
