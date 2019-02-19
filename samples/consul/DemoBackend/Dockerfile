FROM microsoft/dotnet:sdk as build-env
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /src/publish

FROM microsoft/dotnet:aspnetcore-runtime
COPY --from=build-env /src/publish /app
WORKDIR /app

EXPOSE 80

ENTRYPOINT [ "dotnet", "DemoBackend.dll" ]