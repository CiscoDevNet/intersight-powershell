# ConnectorFileMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.FileMessage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.FileMessage"]
**MsgType** | **String** | Message type carrying the file operation to perform. * &#x60;OpenFile&#x60; - Open a file for write to on the platforms file system. Must be the first message sent to the plugin when writing files, attempting to write to or close a file that has not been opened will return error. If file does not exist file will be created, if it does exist file will be truncated. If the files parent directory does not exist an error will be returned. * &#x60;FileContent&#x60; - Carries content to write to an open file. The complete file content can be buffered across many FileContent messages, with each subsequent message received appending to the end of the file. If the total size of FileContent messages exceeds the file size limit of 5MB the plugin will return error and remove the opened file. * &#x60;CloseFile&#x60; - Close the file. Close message must be sent at the end of file transfer. If no close is sent and no input is received after a timeout of 10 minutes the file will be removed. After a CloseFile is received no further FileContent messages will be accepted and will return error. * &#x60;DeleteFile&#x60; - Delete a file from the filesystem. If the file does not exist operation is a no-op and no error is returned. File must be within one of the platforms allowed writable directories. * &#x60;ListDir&#x60; - Open a directory and return a list of files in the directory. Does not recursively walk subdirectories, returns only the top level files in the directory. Output will be a list of json encoded FileInfos. * &#x60;&#x60; - Open a file and read the contents into a response message. The response message body is the entire contents of the file with no encoding or compression. If the file does not exist an error will be returned. If the size of the file exceeds 500KB an error will be returned without reading any file contents. * &#x60;PopulateRemoteTemplateFile&#x60; - Populates data driven template file with input values to generate textual output. Inputs are - the path of the template file on the device and values to populate. An error will be returned if the file does not exist or if there is an error while executing the templates. * &#x60;GetFreeSpace&#x60; - Check the disk space availability of folder and returns the free disk space in percentage. Output will be a list of encoded FileInfos. | [optional] [default to "OpenFile"]
**Path** | **String** | The absolute path of the file to open on the platforms file system. Must be a sub-directory of a directory defined within the platform configurations WriteableDirectories. The file system device to write to must also have sufficient free space to write to (&lt;75% full). Must be set for each message that is sent. | [optional] 
**Stream** | [**SystemByte**](SystemByte.md) | The stream of bytes to write to file when message type is FileContent. Ignored for OpenFile and CloseFile messages. This field holds the input values (key-value pairs) to be populated in the template file when message type is PopulateTemplateFile. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorFileMessageAllOf = Initialize-IntersightConnectorFileMessageAllOf  -ClassId null `
 -ObjectType null `
 -MsgType null `
 -Path null `
 -Stream null
```

- Convert the resource to JSON
```powershell
$ConnectorFileMessageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

