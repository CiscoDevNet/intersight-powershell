---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightCertificatemanagementKmipClientConfigurationBundle

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightCertificatemanagementKmipClientConfigurationBundle [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-BundlePassword< string>][-BundleType< CertificatemanagementKmipClientConfigurationBundle.BundleTypeEnum>][-Certificate< Model.X509Certificate>][-CertificateBundle< string>][-ClassId< CertificatemanagementKmipClientConfigurationBundle.ClassIdEnum>][-Enabled< bool>][-ObjectType< CertificatemanagementKmipClientConfigurationBundle.ObjectTypeEnum>][-Privatekey< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -BundlePassword
Password for the certificate bundle/Private Key. It&apos;s required when the bundle type is PKCS#8/PKCS#12.

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

### -BundleType
Type of the KMIP client certificate bundle.\n* `PKCS1` - The private key is in PKCS#1 format and does not contain certificate chain.\n* `PKCS8` - The private key here is in PKCS#8 format and may be password protected.\n* `PKCS12` - The bundle is in PKCS#12 format that contains client certificate, private key. This Bundle is password protected.

```yaml
Type: CertificatemanagementKmipClientConfigurationBundle.BundleTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Certificate
Certificate that is used for verifying the authorization.

Note :- Use Initialize-IntersightX509Certificate to create the object of complex type X509Certificate

```yaml
Type: Model.X509Certificate
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CertificateBundle
Certificate Bundle that contains client certificate and Private Key. This Bundle is password protected.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: CertificatemanagementKmipClientConfigurationBundle.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Enabled
Enable/Disable the certificate in Certificate Management policy.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: CertificatemanagementKmipClientConfigurationBundle.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Privatekey
Private Key which is used to validate the certificate.

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
PS C:\> Initialize-IntersightCertificatemanagementKmipClientConfigurationBundle
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightX509Certificate](./Initialize-IntersightX509Certificate.md)
