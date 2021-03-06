<?xml version="1.0" encoding="UTF-8"?>
<Project DefaultTargets="Build" ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
	<ItemGroup Label="ProjectConfigurations">
		<ProjectConfiguration Include="Debug|x64">
			<Configuration>Debug</Configuration>
			<Platform>x64</Platform>
		</ProjectConfiguration>
	</ItemGroup>
	<PropertyGroup Label="Globals">
		<ProjectGuid>{F3FC6D86-508D-3FB1-96D2-995F08B142EC}</ProjectGuid>
		<Keyword>Win32Proj</Keyword>
		<Platform>x64</Platform>
		<WindowsTargetPlatformVersion>10.0.18362.0</WindowsTargetPlatformVersion>
	</PropertyGroup>
	<Import Project="$(VCTargetsPath)\Microsoft.Cpp.Default.props"/>
	<PropertyGroup>
		<PreferredToolArchitecture>x64</PreferredToolArchitecture>
	</PropertyGroup>
	<PropertyGroup Label="Configuration">
		<ConfigurationType>Utility</ConfigurationType>
		<CharacterSet>MultiByte</CharacterSet>
		<PlatformToolset>v142</PlatformToolset>
	</PropertyGroup>
	<Import Project="$(VCTargetsPath)\Microsoft.Cpp.props"/>
	<ItemDefinitionGroup>
		<PostBuildEvent>
			<Command>echo VCTargetsPath=$(VCTargetsPath)</Command>
		</PostBuildEvent>
	</ItemDefinitionGroup>
	<Import Project="$(VCTargetsPath)\Microsoft.Cpp.targets"/>
</Project>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         MRIConvert/mcverter Release Notes

Version 2.1.0
--- Bugs Fixed ---
* Add FrameReferenceTime to volids for PET scans.
* Fixed "Apply rescale slope and intercept to data", it is now applied on output, not input. Data is automatically converted to floating point.
* Fixed a typo (MRDiffusionSequence).
* Fixed error in calculation of total readout time.
--- New Features ---
* Enable drag-and-drop for OS X, now works on all platforms.
* Added option to specify precision when converting floats to strings.
--- Known Issues ---

Version 2.0.9
--- No Release ---

Version 2.0.8
--- Bugs Fixed ---
* Fix garbled output file paths and names.
--- New Features ---
* Add new means of formatting output filenames to mcverter.
* Support for Unicode within DICOM files. Output supports UTF-8.
* Added echo spacing, effective echo spacing, and total readout time to Series Info output (for syngo files only).
--- Known Issues ---

Version 2.0.7
--- Bugs Fixed ---
* Crash on converting Siemens ASL DICOM files.
* Remove spurious warning message.
--- Known Issues ---
* Incomplete support for non-ASCII characters. If path contains such characters, some files are saved in a path with garbled characters.
* Siemens ASL files present as single-slice, so pixdim[4] is not correctly populated in NIfTI headers. This also appears in the AcquisitonOrder list in _info.txt files, which is not incremented correctly.

Version 2.0.6
--- Bugs Fixed ---
* Crash on converting some DICOM files.
* Slow to open .dmg file on OS X Lion.
--- New Features ---
* Support for Unicode, e.g. those with diacritics, characters in DICOM elements and file and directory names.
* Add Patient birth date to *info.txt files and Series info dialog.
--- Known Issues ---
* Unable to load files with non-ASCII characters in the path under OS X.
* Unable to load files with non-ASCII characters in the path with mcverter.

Version 2.0.5
--- Bugs Fixed ---
* Fix crash at launch in OS X.
* Fix Options dialogs bug that caused file naming component changes to be ignored if checkboxes were changed.
--- New Features ---
* Add ability to select multiple items for displaying DICOM and Series information.
* Add ability to select multiple items for displaying DICOM images.
--- Known Issues ---
* No support for non-US character sets.

Version 2.0.4
* Fix bug in mcverter output directory specification.  The -x option was treated as always enabled.
* Fix bug in naming of _bvecs and _bvals files, removing a trailing .txt.
* "Add files" dialog remembers last directory, like "Add folder" dialog.
* Improved About dialog.
* Add ability to select multiple items to remove in Remove dialog.
* Fix bug in calculating the value of NIfTI pixdim[4].
* Add quiet option for mcverter, suppresses output to stdout, overrides verbose option.

                                                                                               