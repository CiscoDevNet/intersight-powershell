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
This defines whether we need to operate in an account recovery scenario or not. If yes, then most of the parameters will be populated from an internal MO. So, some of the input parameters MAY be ignored, if this value is set to true.

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
Number of iterations we want the hash to be run.

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
Key encryption key used to encrypt the DEK&apos;s on the HyperFlex cluster.

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
Resource id + time of creation used for retrieving the KEK.

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
Last known Key encryption key state for this Key.\n* `NEW` - Key Encryption key is newly created.\n* `ACTIVE` - Key Encryption key is deployed on active resource.\n* `INACTIVE` - Key Encryption key is inactive and not used.\n* `INPROGRESS` - Key Encryption key is in a state where it was used on Intersight but did not receive confirmation from platform of success/failure.

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
Initial passphrase for the encryption policy, password must contain a minimum of 12 characters, with at least 1 lowercase, 1 uppercase, 1 numeric.

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
Resource type on which this key will be applied.\n* `CLUSTER` - Encryption is per HyperFlex cluster.\n* `DATASTORE` - Encryption is per dataStore on the HyperFlex cluster.\n* `DRIVE` - Encryption is per drive on the HyperFlex cluster.

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
Copy of Key encryption key, which is used for sending the key over to the remote device endpoint. It is not persisited anywhere.

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

[Remove-IntersightHyperflexKeyEncryptionKey](./Remove-IntersightHyperflexKeyEncryptionKey.md)

[Get-IntersightHyperflexKeyEncryptionKey](./Get-IntersightHyperflexKeyEncryptionKey.md)

[New-IntersightHyperflexKeyEncryptionKey](./New-IntersightHyperflexKeyEncryptionKey.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
