---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightVmediaMapping

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightVmediaMapping [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-AuthenticationProtocol< VmediaMapping.AuthenticationProtocolEnum>][-ClassId< VmediaMapping.ClassIdEnum>][-DeviceType< VmediaMapping.DeviceTypeEnum>][-FileLocation< string>][-HostName< string>][-MountOptions< string>][-MountProtocol< VmediaMapping.MountProtocolEnum>][-ObjectType< VmediaMapping.ObjectTypeEnum>][-Password< string>][-RemoteFile< string>][-RemotePath< string>][-Username< string>][-VolumeName< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -AuthenticationProtocol
Type of Authentication protocol when CIFS is used for communication with the remote server.\n* `none` - No authentication is used.\n* `ntlm` - NT LAN Manager (NTLM) security protocol. Use this option only with Windows 2008 R2 and Windows 2012 R2.\n* `ntlmi` - NTLMi security protocol. Use this option only when you enable Digital Signing in the CIFS Windows server.\n* `ntlmv2` - NTLMv2 security protocol. Use this option only with Samba Linux.\n* `ntlmv2i` - NTLMv2i security protocol. Use this option only with Samba Linux.\n* `ntlmssp` - NT LAN Manager Security Support Provider (NTLMSSP) protocol. Use this option only with Windows 2008 R2 and Windows 2012 R2.\n* `ntlmsspi` - NTLMSSPi protocol. Use this option only when you enable Digital Signing in the CIFS Windows server.

```yaml
Type: VmediaMapping.AuthenticationProtocolEnum
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
Type: VmediaMapping.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DeviceType
Type of remote Virtual Media device.\n* `cdd` - Uses compact disc drive as the virtual media mount device.\n* `hdd` - Uses hard disk drive as the virtual media mount device.

```yaml
Type: VmediaMapping.DeviceTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -FileLocation
Remote location of image. Preferred format is &apos;hostname/filePath/fileName&apos;.

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

### -HostName
IP address or hostname of the remote server.

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

### -MountOptions
Mount options for the Virtual Media mapping. The field can be left blank or filled in a comma separated list with the following options.\\n For NFS, supported options are ro, rw, nolock, noexec, soft, port=VALUE, timeo=VALUE, retry=VALUE.\\n For CIFS, supported options are soft, nounix, noserverino, guest.\\n For CIFS version &amp;lt; 3.0, vers=VALUE is mandatory. e.g. vers=2.0\\n For HTTP/HTTPS, the only supported option is noauto.

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

### -MountProtocol
Protocol to use to communicate with the remote server.\n* `nfs` - NFS protocol for vmedia mount.\n* `cifs` - CIFS protocol for vmedia mount.\n* `http` - HTTP protocol for vmedia mount.\n* `https` - HTTPS protocol for vmedia mount.

```yaml
Type: VmediaMapping.MountProtocolEnum
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
Type: VmediaMapping.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Password
Password associated with the username.

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

### -RemoteFile
The remote file location path for the virtual media mapping. Accepted formats are:\nHDD for CIFS/NFS: hostname-or-IP/filePath/fileName.img.\nCDD for CIFS/NFS: hostname-or-IP/filePath/fileName.iso.\nHDD for HTTP/S: http[s]://hostname-or-IP/filePath/fileName.img.\nCDD for HTTP/S: http[s]://hostname-or-IP/filePath/fileName.iso.

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

### -RemotePath
URL path to the location of the image on the remote server. The preferred format is &amp;apos;/path&amp;apos;.

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

### -Username
Username to log in to the remote server.

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

### -VolumeName
Identity of the image for Virtual Media mapping.

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
PS C:\> Initialize-IntersightVmediaMapping
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
