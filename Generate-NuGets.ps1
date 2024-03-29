<#
.SYNOPSIS
	Evergine bindings NuGet Packages generator script, (c) 2022 Javier Cantón Ferrero
.DESCRIPTION
	This script generates NuGet packages for Evergine OpenGL (and OpenGL ES) bindings.
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script> -version 2021.11.17.1-local
.LINK
	https://evergine.com/
#>

param (
	[Parameter(mandatory=$true)][string]$version,
	[string]$outputFolderBase = "nupkgs",
	[string]$buildVerbosity = "minimal",
	[string]$buildConfiguration = "Release",
	[string]$openGLcsprojPath = "OpenGLGen\Evergine.Bindings.OpenGL\Evergine.Bindings.OpenGL.csproj",
	[string]$openGLEScsprojPath = "OpenGLGen\Evergine.Bindings.OpenGLES\Evergine.Bindings.OpenGLES.csproj"
)

# Utility functions
function LogDebug($line)
{ Write-Host "##[debug] $line" -Foreground Blue -Background Black
}

# Locate build tools
$msbuildPath = tools\vswhere.exe -latest -prerelease -products * -requires Microsoft.Component.MSBuild -property installationPath
if(-Not $?)
{ exit $lastexitcode
}
$msbuildPath = Resolve-Path (Join-Path $msbuildPath 'MSBuild\*\Bin\MSBuild.exe')
if (-Not (Test-Path $msbuildPath))
{ throw "MSBuild not found."
}

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Version.............: $version"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "Output folder.......: $outputFolderBase"
LogDebug "#######################################"

# Create output folder
$outputFolder = Join-Path $outputFolderBase $versionWithSuffix
New-Item -ItemType Directory -Force -Path $outputFolder
$absoluteOutputFolder = Resolve-Path $outputFolder

# Create temporal solution
$tempSolutionName = "tempsolution_deleteme"
Remove-Item "$tempSolutionName.sln" -ErrorAction Ignore
dotnet new sln -n "$tempSolutionName"

# Add projects to the solution
dotnet sln "$tempSolutionName.sln" add $openGLcsprojPath
dotnet sln "$tempSolutionName.sln" add $openGLEScsprojPath

# Generate packages
LogDebug "START packaging process"
& $msbuildPath /nologo "$tempSolutionName.sln" /t:restore,build,pack /p:Configuration=$buildConfiguration /v:$buildVerbosity /p:PackageOutputPath="$absoluteOutputFolder" /p:IncludeSymbols=true /p:Version=$version

# Post-script tasks
Remove-Item "$tempSolutionName.sln" -ErrorAction Ignore

LogDebug "END packaging process"