# Zobacz https://aka.ms/customizecontainer, aby dowiedzieć się, jak dostosować kontener debugowania i jak program Visual Studio używa tego pliku Dockerfile do kompilowania obrazów w celu szybszego debugowania.

# W zależności od systemu operacyjnego maszyn hostów, które będą kompilować lub uruchamiać kontenery, może być konieczna zmiana obrazu określonego w instrukcji FROM.
# Aby uzyskać więcej informacji, zobacz https://aka.ms/containercompat

# Ten etap jest używany podczas uruchamiania z programu VS w trybie szybkim (domyślnie dla konfiguracji debugowania)
FROM mcr.microsoft.com/dotnet/runtime:8.0-nanoserver-1809 AS base
WORKDIR /app


# Ten etap służy do kompilowania projektu usługi
FROM mcr.microsoft.com/dotnet/sdk:8.0-windowsservercore-ltsc2019 AS build
# Zainstaluj narzędzia Visual Studio Build Tools. Są one wymagane do publikowania drzewa obiektów aplikacji (AOT)
# Uwaga: korzystanie z narzędzi Visual Studio Build Tools wymaga ważnej licencji programu Visual Studio.
RUN curl -SL --output vs_buildtools.exe https://aka.ms/vs/17/release/vs_buildtools.exe
RUN vs_buildtools.exe --installPath C:\BuildTools --add Microsoft.VisualStudio.Component.VC.Tools.x86.x64 Microsoft.VisualStudio.Component.Windows10SDK.19041 --quiet --wait --norestart --nocache
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["hotel.csproj", "."]
RUN dotnet restore "./hotel.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./hotel.csproj" -c %BUILD_CONFIGURATION% -o /app/build

# Ten etap służy do publikowania projektu usługi do skopiowania do etapu końcowego
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./hotel.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=true

# Ten etap jest używany w środowisku produkcyjnym lub w przypadku uruchamiania z programu VS w trybie regularnym (domyślnie, gdy nie jest używana konfiguracja debugowania)
FROM mcr.microsoft.com/dotnet/runtime:8.0-nanoserver-1809 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["hotel.exe"]