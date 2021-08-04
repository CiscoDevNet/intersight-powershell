---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightSoftwarerepositoryAuthorization

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightSoftwarerepositoryAuthorization [-AdditionalProperties< Dictionary<string,object>>][-Moid< string>][-Password< string>][-RepositoryType< SoftwarerepositoryAuthorization.RepositoryTypeEnum>][-Tags< List<MoTag>>][-UserId< string>]

```

## DESCRIPTION
Create a &apos;SoftwarerepositoryAuthorization&apos; resource.

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

### -Password
The password that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account&amp;apos;s behalf.

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

### -RepositoryType
The external repository for which this authorization has been provided. The only supported repository today is cisco.com.\n* `Cisco` - External repository hosted on cisco.com.\n* `IntersightCloud` - Repository hosted by the Intersight Cloud.\n* `LocalMachine` - The file is available on the local client machine. Used as an upload source type.\n* `NetworkShare` - External repository in the customer datacenter. This will typically be a file server.

```yaml
Type: SoftwarerepositoryAuthorization.RepositoryTypeEnum
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

### -UserId
The username that will be used by Intersight to create OAuth2 tokens for interacting with the external repository, on the user account&amp;apos;s behalf.

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
PS C:\> New-IntersightSoftwarerepositoryAuthorization
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightSoftwarerepositoryAuthorization](./Get-IntersightSoftwarerepositoryAuthorization.md)

[Set-IntersightSoftwarerepositoryAuthorization](./Set-IntersightSoftwarerepositoryAuthorization.md)
