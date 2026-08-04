---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightAuditdLogMonitorType

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightAuditdLogMonitorType [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-All< AuditdLogMonitorType.AllEnum>][-AuthLogFiles< AuditdLogMonitorType.AuthLogFilesEnum>][-ClassId< AuditdLogMonitorType.ClassIdEnum>][-CronFiles< AuditdLogMonitorType.CronFilesEnum>][-DnsClientFiles< AuditdLogMonitorType.DnsClientFilesEnum>][-Docker< AuditdLogMonitorType.DockerEnum>][-KernelModuleMgmt< AuditdLogMonitorType.KernelModuleMgmtEnum>][-ObjectType< AuditdLogMonitorType.ObjectTypeEnum>][-ProcessAudit< AuditdLogMonitorType.ProcessAuditEnum>][-SystemLogFiles< AuditdLogMonitorType.SystemLogFilesEnum>][-SystemLoginReboot< AuditdLogMonitorType.SystemLoginRebootEnum>][-SystemSoftware< AuditdLogMonitorType.SystemSoftwareEnum>][-SystemTimeChange< AuditdLogMonitorType.SystemTimeChangeEnum>][-UserGroupConfigFiles< AuditdLogMonitorType.UserGroupConfigFilesEnum>][-UserPrivilegeMgmt< AuditdLogMonitorType.UserPrivilegeMgmtEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -All
It can be configured to monitor all the log events.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.AllEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -AuthLogFiles
It can be configured to monitor log events only w.r.t auth log files changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.AuthLogFilesEnum
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
Type: AuditdLogMonitorType.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CronFiles
It can be configured to monitor log events only w.r.t cron files changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.CronFilesEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DnsClientFiles
It can be configured to monitor log events only w.r.t dns client files changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.DnsClientFilesEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Docker
It can be configured to monitor log events only w.r.t Docker executions and file changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.DockerEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -KernelModuleMgmt
It can be configured to monitor log events only w.r.t kernel module files changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.KernelModuleMgmtEnum
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
Type: AuditdLogMonitorType.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ProcessAudit
It can be configured to monitor log events only w.r.t process execution audit.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.ProcessAuditEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SystemLogFiles
It can be configured to monitor log events only w.r.t system log files changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.SystemLogFilesEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SystemLoginReboot
It can be configured to monitor log events only w.r.t system login reboot file changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.SystemLoginRebootEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SystemSoftware
It can be configured to monitor log events only w.r.t system software&apos;s binaries changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.SystemSoftwareEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SystemTimeChange
It can be configured to monitor log events only w.r.t system time file changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.SystemTimeChangeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UserGroupConfigFiles
It can be configured to monitor log events only w.r.t User Group Config Files changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.UserGroupConfigFilesEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -UserPrivilegeMgmt
It can be configured to monitor log events only w.r.t User Privilege management file changes.\n* `no` - Value to disable the specific monitoring rule.\n* `yes` - Value to enable the specific monitoring rule.

```yaml
Type: AuditdLogMonitorType.UserPrivilegeMgmtEnum
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
PS C:\> Initialize-IntersightAuditdLogMonitorType
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
