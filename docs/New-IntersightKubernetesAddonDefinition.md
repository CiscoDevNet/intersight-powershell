---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightKubernetesAddonDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightKubernetesAddonDefinition [-AdditionalProperties< Dictionary<string,object>>][-Catalog< KubernetesCatalogRelationship>][-ChartUrl< string>][-DefaultInstallStrategy< KubernetesAddonDefinition.DefaultInstallStrategyEnum>][-DefaultNamespace< string>][-DefaultUpgradeStrategy< KubernetesAddonDefinition.DefaultUpgradeStrategyEnum>][-Description< string>][-Digest< string>][-IconUrl< string>][-Labels< List<string>>][-Moid< string>][[-Name]< string>][-Organization< OrganizationOrganizationRelationship>][-Tags< List<MoTag>>][-Version< string>]

```

## DESCRIPTION
Create a &apos;KubernetesAddonDefinition&apos; resource.

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

### -Catalog
A reference to a kubernetesCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: KubernetesCatalogRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ChartUrl
Description of the addon component.

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

### -DefaultInstallStrategy
Default installation strategy for the release.\n* `None` - Unspecified install strategy.\n* `NoAction` - No install action performed.\n* `InstallOnly` - Only install in green field. No action in case of failure or removal.\n* `Always` - Attempt install if chart is not already installed.

```yaml
Type: KubernetesAddonDefinition.DefaultInstallStrategyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DefaultNamespace
Default namespace to install the release.

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

### -DefaultUpgradeStrategy
Default upgrade strategy for the release.\n* `None` - Unspecified upgrade strategy.\n* `NoAction` - This choice enables No upgrades to be performed.\n* `UpgradeOnly` - Attempt upgrade if chart or overrides options change, no action on upgrade failure.\n* `ReinstallOnFailure` - Attempt upgrade first. Remove and install on upgrade failure.\n* `AlwaysReinstall` - Always remove older release and reinstall.

```yaml
Type: KubernetesAddonDefinition.DefaultUpgradeStrategyEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
Description of the addon component.

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

### -Digest
Digest used to verify the integrity of an addon.

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

### -IconUrl
Icon used to represent the addon in UI.

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

### -Labels


```yaml
Type: System.Collections.Generic.List`1[string]
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
Name of an addon component.

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

### -Organization
A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: OrganizationOrganizationRelationship
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

### -Version
Version of the addon component.

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


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> New-IntersightKubernetesAddonDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Set-IntersightKubernetesAddonDefinition](./Set-IntersightKubernetesAddonDefinition.md)

[Remove-IntersightKubernetesAddonDefinition](./Remove-IntersightKubernetesAddonDefinition.md)

[Get-IntersightKubernetesAddonDefinition](./Get-IntersightKubernetesAddonDefinition.md)
