---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightIamCertificateRequest

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightIamCertificateRequest [-AdditionalProperties< Dictionary<string,object>>][-Certificate< IamCertificateRelationship>][-EmailAddress< string>][-Moid< string>][[-Name]< string>][-PrivateKeySpec< IamPrivateKeySpecRelationship>][-SelfSigned< bool>][-Subject< PkixDistinguishedName>][-SubjectAlternateName< PkixSubjectAlternateName>][-Tags< List<MoTag>>]

```

## DESCRIPTION
Create a &amp;apos;IamCertificateRequest&amp;apos; resource.

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

### -Certificate
A reference to a iamCertificate resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IamCertificateRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EmailAddress
User input email address, an optional part of the subject of the certificate request.

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
Name of the certificate request.

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

### -PrivateKeySpec
A reference to a iamPrivateKeySpec resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IamPrivateKeySpecRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SelfSigned
Whether the user wants the generated CSR to be self-signed by the appliance.

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

### -Subject
The x.509 distinguished name of the subject of the certificate request.

Note :- Use Initialize-IntersightPkixDistinguishedName to create the object of complex type PkixDistinguishedName

```yaml
Type: PkixDistinguishedName
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SubjectAlternateName
The x.509 subject alternate name values of the certificate request.

Note :- Use Initialize-IntersightPkixSubjectAlternateName to create the object of complex type PkixSubjectAlternateName

```yaml
Type: PkixSubjectAlternateName
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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> New-IntersightIamCertificateRequest
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightIamCertificateRequest](./Get-IntersightIamCertificateRequest.md)

[Remove-IntersightIamCertificateRequest](./Remove-IntersightIamCertificateRequest.md)

[Set-IntersightIamCertificateRequest](./Set-IntersightIamCertificateRequest.md)

[Initialize-IntersightPkixDistinguishedName](./Initialize-IntersightPkixDistinguishedName.md)

[Initialize-IntersightPkixSubjectAlternateName](./Initialize-IntersightPkixSubjectAlternateName.md)
