---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightConnectorCommandControlMessage

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightConnectorCommandControlMessage [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< ConnectorCommandControlMessage.ClassIdEnum>][-Dir< string>][-EncryptedAesKey< string>][-EncryptionKey< string>][-MsgType< string>][-ObjectType< ConnectorCommandControlMessage.ObjectTypeEnum>][-RemoteUserLocale< string>][-RemoteUserName< string>][-RemoteUserRoles< string>][-RemoteUserSessionId< string>][-SecureProperties< object>][-Stream< byte[]>][-Terminal< bool>][-Timeout< long>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: ConnectorCommandControlMessage.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Dir
The working directory of the command. If empty command is executed in the same directory the device connector process was called.

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

### -EncryptedAesKey
The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property.\nThe secure properties that are encrypted using the AES key are mapped against the property name with prefix &apos;AES&apos; in SecureProperties dictionary.

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

### -EncryptionKey
The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector&apos;s public key, an error reponse with appropriate error message is thrown back.

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

### -MsgType
Message carrying the operation to perform.

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
Type: ConnectorCommandControlMessage.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RemoteUserLocale
The platform locale to assign user. A locale defines one or more organizations (domains) the user is allowed access, and access is limited to the organizations specified in the locale.

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

### -RemoteUserName
The user name passed to the platform for use in platform audit logs.

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

### -RemoteUserRoles
The list of roles to pass to the platform to validate the action against.

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

### -RemoteUserSessionId
The session Id passed to the platform for use in platforms auditing.

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

### -SecureProperties
A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a &apos;AES&apos; prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Stream
The command to execute. Commands must be in allowed list by platform implementation, if a command does not match any allowed list command patterns an error will be returned to the requesting service on command start.

Note :- Use Initialize-Intersightbyte[] to create the object of complex type byte[]

```yaml
Type: byte[]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Terminal
Indicates that a pseudo terminal should be attached to the command. Used for interactive commands. e.g A cross launch cli.

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

### -Timeout
The timeout for the command to complete and exit after starting or receiving input. If timeout is not set a default of 10 minutes will be used. If there is input to the command stream the timeout is extended.

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
PS C:\> Initialize-IntersightConnectorCommandControlMessage
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-Intersightbyte[]](./Initialize-Intersightbyte[].md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)
