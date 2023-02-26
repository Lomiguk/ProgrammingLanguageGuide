#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Systems/Api/ProgrammingLanguageGuide/ProgrammingLanguageGuide.csproj", "Systems/Api/ProgrammingLanguageGuide/"]
COPY ["Services/ProgrammingLanguagesGuide.Services.Settings/ProgrammingLanguageGuide.Services.Settings.csproj", "Services/ProgrammingLanguagesGuide.Services.Settings/"]
COPY ["Shared/ProgrammingLanguagesGuide.Settings/ProgrammingLanguageGuide.Settings.csproj", "Shared/ProgrammingLanguagesGuide.Settings/"]
COPY ["Shared/ProgrammingLanguagesGuide.Common/ProgrammingLanguageGuide.Common.csproj", "Shared/ProgrammingLanguagesGuide.Common/"]
COPY ["Systems/Api/ProgrammingLanguageGuide.Api.Settings/ProgrammingLanguageGuide.Api.Settings.csproj", "Systems/Api/ProgrammingLanguageGuide.Api.Settings/"]
RUN dotnet restore "Systems/Api/ProgrammingLanguageGuide/ProgrammingLanguageGuide.csproj"
COPY . .
WORKDIR "/src/Systems/Api/ProgrammingLanguageGuide"
RUN dotnet build "ProgrammingLanguageGuide.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProgrammingLanguageGuide.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProgrammingLanguageGuide.dll"]