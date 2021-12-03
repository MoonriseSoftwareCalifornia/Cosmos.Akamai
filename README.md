# Akamai CDN helper

[![.NET Build and Unit Tests](https://github.com/CosmosSoftware/Cosmos.Akamai/actions/workflows/dotnet.yml/badge.svg)](https://github.com/CosmosSoftware/Cosmos.Akamai/actions/workflows/dotnet.yml) [![Publish NuGet Pkg](https://github.com/CosmosSoftware/Cosmos.Akamai/actions/workflows/main.yml/badge.svg)](https://github.com/CosmosSoftware/Cosmos.Akamai/actions/workflows/main.yml)
[![NuGet Badge](https://buildstats.info/nuget/CDT.Akamai.Cdn)](https://www.nuget.org/packages/CDT.Akamai.Cdn/)

This is a (Nuget Package)[https://www.nuget.org/packages/CDT.Akamai.Cdn/] built for the (Cosmos CMS)[https://github.com/CosmosSoftware/Cosmos.Cms], but can be used by any .Net core version 6 application to purge an Akamai CDN.

It purges by CP Code or bay a series of URLs.  CP Code is equivalent to purging all paths where purging by URL is more efficient, and is best for websites under high load.

This repository is derived from (AkamaiOPEN-edgegrid-C-Sharp)[https://github.com/akamai/AkamaiOPEN-edgegrid-C-Sharp].
