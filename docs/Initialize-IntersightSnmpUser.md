---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightSnmpUser

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightSnmpUser [-AdditionalProperties< Dictionary<string,object>>][-AuthPassword< string>][-AuthType< SnmpUser.AuthTypeEnum>][-ClassId< SnmpUser.ClassIdEnum>][-Name< string>][-ObjectType< SnmpUser.ObjectTypeEnum>][-PrivacyPassword< string>][-PrivacyType< SnmpUser.PrivacyTypeEnum>][-SecurityLevel< SnmpUser.SecurityLevelEnum>]

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

### -AuthPassword
Authorization password for the user.

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

### -AuthType
Authorization protocol for authenticating the user.\n* `NA` - Authentication protocol is not applicable.\n* `MD5` - MD5 protocol is used to authenticate SNMP user.\n* `SHA` - SHA protocol is used to authenticate SNMP user.\n* `SHA-224` - SHA-224 protocol is used to authenticate SNMP user.\n* `SHA-256` - SHA-256 protocol is used to authenticate SNMP user.\n* `SHA-384` - SHA-384 protocol is used to authenticate SNMP user.\n* `SHA-512` - SHA-512 protocol is used to authenticate SNMP user.

```yaml
Type: SnmpUser.AuthTypeEnum
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
Type: SnmpUser.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
SNMP username. Must have a minimum of 1 and and a maximum of 31 characters.

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
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &amp;apos;ClassId&amp;apos; property.

```yaml
Type: SnmpUser.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PrivacyPassword
Privacy password for the user.

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

### -PrivacyType
Privacy protocol for the user.\n* `NA` - Privacy protocol is not applicable.\n* `DES` - DES privacy protocol is used for SNMP user.\n* `AES` - AES privacy protocol is used for SNMP user.

```yaml
Type: SnmpUser.PrivacyTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SecurityLevel
Security mechanism used for communication between agent and manager.\n* `AuthPriv` - The user requires both an authorization password and a privacy password.\n* `NoAuthNoPriv` - The user does not require an authorization or privacy password.\n* `AuthNoPriv` - The user requires an authorization password but not a privacy password.

```yaml
Type: SnmpUser.SecurityLevelEnum
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
PS C:\> Initialize-IntersightSnmpUser
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
