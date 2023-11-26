#!/bin/bash

# This script builds KS and packs the artifacts. Use when you have MSBuild installed.
version=$(cat version)

# Check for dependencies
zippath=`which zip`
if [ ! $? == 0 ]; then
	echo zip is not found.
	exit 1
fi

# Pack binary
echo Packing binary...
cd "../Addresstigator/bin/$releaseconf/netstandard2.0/" && "$zippath" -r /tmp/$version-bin.zip . && cd -
cd "../Addresstigator.Console/bin/$releaseconf/net8.0/" && "$zippath" -r /tmp/$version-demo.zip . && cd -
if [ ! $? == 0 ]; then
	echo Packing failed.
	exit 1
fi

# Inform success
mv /tmp/$version-bin.zip .
mv /tmp/$version-demo.zip .
echo Build and pack successful.
exit 0
