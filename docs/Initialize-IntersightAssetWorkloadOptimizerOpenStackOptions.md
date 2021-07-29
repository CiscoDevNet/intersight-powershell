---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightAssetWorkloadOptimizerOpenStackOptions

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightAssetWorkloadOptimizerOpenStackOptions [-AdditionalProperties< Dictionary<string,object>>][-ClassId< AssetWorkloadOptimizerOpenStackOptions.ClassIdEnum>][-Domain< string>][-ObjectType< AssetWorkloadOptimizerOpenStackOptions.ObjectTypeEnum>][-Tenant< string>]

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
Type: AssetWorkloadOptimizerOpenStackOptions.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Domain
OpenStack Identity Service (keystone) domain name. Domain is an additional namespaces you can create in keystone to partition users, groups, and projects. Default domain name value is \&quot;Default\&quot;.

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
Type: AssetWorkloadOptimizerOpenStackOptions.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tenant
The name of tenant which has assigned administrator role this OpenStack target user is in. A tenant or project is referred to as a group of users of OpenStack. Each tenant can be assigned a role which gives all its member users their rights and privileges to perform a specific set of operations.

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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Initialize-IntersightAssetWorkloadOptimizerOpenStackOptions
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
