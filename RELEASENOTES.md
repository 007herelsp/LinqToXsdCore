# LinqToXsdCore Release Notes

## XObjectsCore 3.0.0.7
Nuget packages: 
* https://www.nuget.org/packages/XObjectsCore/3.0.0.7
	* Fixed a regression bug with previous release.

## LinqToXsdCore 3.0.0.9 and XObjectsCore 3.0.0.6
Nuget packages: 
* https://www.nuget.org/packages/XObjectsCore/3.0.0.6
	* Fixed an issue when performing an explicit type conversion from XElement to its XTyped-equivalent when the XTyped-equivalent type was an internal class.
* https://www.nuget.org/packages/LinqToXsdCore/3.0.0.9
	* Generating a new config file no longers includes the Xml.Schema.Linq schema namespace mapping. Also generating a new config file will generate a default namespace mapping when the XSD does not target a namespace. 

## LinqToXsdCore 3.0.0.8
Nuget packages: 
* https://www.nuget.org/packages/LinqToXsdCore/3.0.0.8
	* Implemented saving merged output from multiple XSD files when generating a config file (using 'config -e' switch) using a folder as a source.

## XObjectsCore 3.0.0.5 and LinqToXsdCore 3.0.0.7
Nuget packages: 
* https://www.nuget.org/packages/XObjectsCore/3.0.0.5
	* Reversed a change made that removed the virtual keyword on properties on generated types. Added a test for it.
* https://www.nuget.org/packages/LinqToXsdCore/3.0.0.7
	* Dropped emitting errors to a custom handler. Was outputting red console text needlessly.

## XObjectsCore 3.0.0.4 and LinqToXsdCore 3.0.0.6
Nuget packages: 
* https://www.nuget.org/packages/XObjectsCore/3.0.0.4
* https://www.nuget.org/packages/LinqToXsdCore/3.0.0.6

Fixes a bug that caused XTypedElement.Clone() to fail when generated code had the `internal` visibility modifier. This manifested in the CLI tool, when attempting to use it to generate an example configuration file `linqtoxsd config 'file.xsd' -e`.