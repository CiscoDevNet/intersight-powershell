---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightHyperflexKeyEncryptionKey

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightHyperflexKeyEncryptionKey [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClusterProfile< HyperflexClusterProfileRelationship>][-IsAccountRecovery< bool>][-Iteration< long>][-Kek< string>][-KeyId< string>][-KeyState< HyperflexKeyEncryptionKey.KeyStateEnum>][[-Moid]< string>][-Passphrase< string>][-ResourceMo< MoBaseMoRelationship>][-ResourceType< HyperflexKeyEncryptionKey.ResourceTypeEnum>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TransitKek< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;HyperflexKeyEncryptionKey&apos; resource.

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

### -IsAccountRecovery
Account recovery scenario flag determining parameter population from internal MO, with possibility of ignoring of input parameters when this value is true.

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

### -Iteration
Number of hash iterations to run.

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

### -Kek
Key Encryption Key used to encrypt the DEK&apos;s on the HyperFlex cluster.

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

### -KeyId
Resource ID and time for Kek retrieval.

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

### -KeyState
Last known state of the Key Encryption Key.\n* `NEW` - Newly created Key Encryption Key (KEK).\n* `ACTIVE` - Deployed Key Encryption Key on active resources.\n* `INACTIVE` - Inactive and unused Key Encryption Key.\n* `INPROGRESS` - Unconfirmed Key Encryption Key usage on Intersight platform.

```yaml
Type: HyperflexKeyEncryptionKey.KeyStateEnum
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

### -Passphrase
Initial passphrase for encryption policy, requiring a minimum of 12 characters, including 1 lowercase, 1 uppercase, and 1 numeric character.

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

### -ResourceMo
A reference to a moBaseMo resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: MoBaseMoRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ResourceType
Resource type for key application.\n* `CLUSTER` - Cluster specific encryption per HyperFlex cluster.\n* `DATASTORE` - Data store encryption on the HyperFlex cluster.\n* `DRIVE` - Drive specific encryption on the HyperFlex cluster.

```yaml
Type: HyperflexKeyEncryptionKey.ResourceTypeEnum
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

### -TransitKek
Temporary copy of KEK used for transfer to remote device endpoint, not persisted anywhere.

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
PS C:\> Set-IntersightHyperflexKeyEncryptionKey
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightHyperflexKeyEncryptionKey](./Get-IntersightHyperflexKeyEncryptionKey.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)

[New-IntersightHyperflexKeyEncryptionKey](./New-IntersightHyperflexKeyEncryptionKey.md)

[Remove-IntersightHyperflexKeyEncryptionKey](./Remove-IntersightHyperflexKeyEncryptionKey.md)
