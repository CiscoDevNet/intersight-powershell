---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightConnectorWinrmRequest

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightConnectorWinrmRequest [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AssetTargetMoid< string>][-Body< byte[]>][-ClassId< ConnectorWinrmRequest.ClassIdEnum>][-EncryptedAesKey< string>][-EncryptionKey< string>][-Filename< string>][-ObjectType< ConnectorWinrmRequest.ObjectTypeEnum>][-OpType< ConnectorWinrmRequest.OpTypeEnum>][-SecureProperties< object>][-SessionId< string>][-Timeout< long>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -AssetTargetMoid
The Target endpoint Moid which is used to fetch the previously persisted Target information in Intersight.

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

### -Body
Contains the file content to be copied or the script to be executed.

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: ConnectorWinrmRequest.ClassIdEnum
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
The public key that was used to encrypt the values present in SecureProperties dictionary.\nIf the given public key is not same as device connector&amp;apos;s public key, an error reponse with appropriate error message is thrown back.

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

### -Filename
The absolute filename to which body is to be written to.\nThis field is ignored if the opType is ExecuteScript.

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
Type: ConnectorWinrmRequest.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -OpType
The type of operation to be performed on the endpoint.\nFile copy and script execution are the possible options.\nOnly script execution is supported for now.\n* `ExecuteScript` - Executes the given script on the target windows machine.\n* `CopyToFile` - The plugin copies the body of the incoming message to the given location.

```yaml
Type: ConnectorWinrmRequest.OpTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SecureProperties
A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a &amp;apos;AES&amp;apos; prefix\nDevice connector expects the message body to be a golang template and the template can use the secure property names as placeholders.

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

### -SessionId
A unique id to track long running script executions.\nEvery execution request is identified by a unique session id. Scripts that have longer execution\ntimes can be tracked to completion by using their unique session id.

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

### -Timeout
The time within which the script execution must be completed.\nIf the script execution exceeds the given time limit an appropriate response is sent back\nto the calling service.

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
PS C:\> Initialize-IntersightConnectorWinrmRequest
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
