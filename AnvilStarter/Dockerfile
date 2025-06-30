# Pull Dotnet image to build the project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ADD . /Build
WORKDIR /Build
RUN dotnet publish -c Release

# Build the final NWN server image
FROM index.docker.io/nwndotnet/anvil:8193.37.2
LABEL maintainer "admin@nwn.net.pl"

COPY --from=build /Build/bin/Release/AnvilStarter /nwn/home/anvil/Plugins/AnvilStarter
# RUN mkdir -p /nwn/data/lang/pl/data
# COPY ./tlk/dialog.tlk /nwn/data/lang/pl/data
# COPY ./res/nlog.config /nwn/home/anvil