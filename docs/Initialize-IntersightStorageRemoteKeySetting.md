---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightStorageRemoteKeySetting

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightStorageRemoteKeySetting [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AuthCredentials< Model.StorageKmipAuthCredentials>][-ClassId< StorageRemoteKeySetting.ClassIdEnum>][-ObjectType< StorageRemoteKeySetting.ObjectTypeEnum>][-PrimaryServer< Model.StorageKmipServer>][-SecondaryServer< Model.StorageKmipServer>][-ServerCertificate< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -AuthCredentials
The authentication details of the KMIP server. It is required to login to the KMIP server.

Note :- Use Initialize-IntersightStorageKmipAuthCredentials to create the object of complex type StorageKmipAuthCredentials

```yaml
Type: Model.StorageKmipAuthCredentials
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
Type: StorageRemoteKeySetting.ClassIdEnum
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
Type: StorageRemoteKeySetting.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PrimaryServer
Configuration of the primary KMIP server.

Note :- Use Initialize-IntersightStorageKmipServer to create the object of complex type StorageKmipServer

```yaml
Type: Model.StorageKmipServer
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SecondaryServer
Configuration of the secondary KMIP server.

Note :- Use Initialize-IntersightStorageKmipServer to create the object of complex type StorageKmipServer

```yaml
Type: Model.StorageKmipServer
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ServerCertificate
The certificate/ public key of the KMIP server. It is required for initiating secure communication with the server.

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
PS C:\> Initialize-IntersightStorageRemoteKeySetting
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightStorageKmipAuthCredentials](./Initialize-IntersightStorageKmipAuthCredentials.md)

[Initialize-IntersightStorageKmipServer](./Initialize-IntersightStorageKmipServer.md)
