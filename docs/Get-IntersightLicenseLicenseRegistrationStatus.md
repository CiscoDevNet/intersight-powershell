---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Get-IntersightLicenseLicenseRegistrationStatus

## SYNOPSIS
Get the LicenseLicenseRegistrationStatus

## SYNTAX

### CmdletParam (Default)
```
Get-IntersightLicenseLicenseRegistrationStatus [-Name <String>] [-Organization <OrganizationOrganizationRelationship>]
 [<CommonParameters>]
```

### QueryParam
```
Get-IntersightLicenseLicenseRegistrationStatus [-Count <Boolean>] [-InlineCount <String>] [-Select <String>] [-Filter <String>]
 [-Expand <String>] [-Skip <Int32>] [-Top <Int32>] [-At <String>] [-Orderby <String>] [-Apply <String>]
 [-Tag <String>] [<CommonParameters>]
```
## DESCRIPTION
Read a &apos;LicenseLicenseRegistrationStatus&apos; resource.
A maximum of 10,000 objects can be retrieved in a single invocation.

Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet.


## EXAMPLES

### Example 1
```powershell
PS C:\> $result = Get-IntersightLicenseLicenseRegistrationStatus
```
Above example returns the list of LicenseLicenseRegistrationStatus.

### Example 2
```powershell
PS C:\> $result = Get-IntersightLicenseLicenseRegistrationStatus -Name "MoName"
```
Above example returns the LicenseLicenseRegistrationStatus matched with name.

### Example 3
```powershell
PS C:\> $result = Get-IntersightLicenseLicenseRegistrationStatus -Organization $organization
```
Above example returns the list of LicenseLicenseRegistrationStatus available under the $organization .

### Example 4
```powershell
PS C:\> $result = Get-IntersightLicenseLicenseRegistrationStatus -InlineCount allpages
```
Above example returns the list of LicenseLicenseRegistrationStatus along with count.

## PARAMETERS

### -Apply
Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a
transformation being used as input for the subsequent transformation. The ""$apply"" query takes a sequence of set transformations, separated by forward slashes
to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are
""aggregate"" and ""groupby"". The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a
result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two
parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first
parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and
cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the
intermediate result sets into one result set. A groupby transformation affects the structure of the result set.

```yaml
Type: String
Parameter Sets: QueryParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -At
Similar to ""$filter"", but ""at"" is specifically used to filter versioning information properties for resources to return. A URI with an ""at"" Query Option
identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only
the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to
properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal
representations shown in the Abstract Type System section.

```yaml
Type: String
Parameter Sets: QueryParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Count
The $count query specifies the service should return the count of the matching resources, instead of returning the resources.

```yaml
Type: Boolean
Parameter Sets: QueryParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Expand
Specify additional attributes or related resources to return in addition to the primary resources.

```yaml
Type: String
Parameter Sets: QueryParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is
determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter
queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false).

```yaml
Type: String
Parameter Sets: QueryParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InlineCount
The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response.

```yaml
Type: String
Parameter Sets: QueryParam
Aliases:
Accepted values: allpages, none

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Specifies the name of the LicenseLicenseRegistrationStatus.

```yaml
Type: String
Parameter Sets: CmdletParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Orderby
Determines what properties are used to sort the collection of resources.

```yaml
Type: String
Parameter Sets: QueryParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Organization
Specifies the organization, to fetch the LicenseLicenseRegistrationStatus under it.

```yaml
Type: OrganizationOrganizationRelationship
Parameter Sets: CmdletParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName, ByValue)
Accept wildcard characters: False
```

### -Select
Specifies a subset of properties to return.

```yaml
Type: String
Parameter Sets: QueryParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Ignores the specified number of objects and then gets the remaining objects.
Enter the number of objects to skip.

```yaml
Type: Int32
Parameter Sets: QueryParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list
of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key.

```yaml
Type: String
Parameter Sets: QueryParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Specifies the maximum number of resources to return in the response.

```yaml
Type: Int32
Parameter Sets: QueryParam
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Intersight.Model.OrganizationOrganizationRelationship

## OUTPUTS

### System.Object
## NOTES

## RELATED LINKS

[Set-IntersightLicenseLicenseRegistrationStatus](./Set-IntersightLicenseLicenseRegistrationStatus.md)

