FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PsychologicalAssistance/PsychologicalAssistance.Web.csproj", "PsychologicalAssistance/"]
RUN dotnet restore "PsychologicalAssistance/PsychologicalAssistance.Web.csproj"
COPY . .
WORKDIR "/src/PsychologicalAssistance"
RUN dotnet build "PsychologicalAssistance.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PsychologicalAssistance.Web.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "PsychologicalAssistance.Web.dll"]
