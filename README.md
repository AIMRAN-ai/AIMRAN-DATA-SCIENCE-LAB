<div align="center">

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                     ANIMATED HERO HEADER                              -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:0d1117,25:161b22,50:1f6feb,75:58a6ff,100:79c0ff&height=300&section=header&text=AIMRAN%20Data%20Science%20Lab&fontSize=42&fontColor=ffffff&animation=fadeIn&fontAlignY=35&desc=Full-Stack%20AI%20%E2%80%A2%20Cross-Platform%20%E2%80%A2%20Cloud-Native&descSize=18&descAlignY=55&descAlign=50" width="100%" />

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                    ANIMATED TYPING TAGLINE                            -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

<a href="https://github.com/AIMRAN-ai/AIMRAN-DATA-SCIENCE-LAB">
  <img src="https://readme-typing-svg.demolab.com?font=Fira+Code&weight=600&size=24&duration=3000&pause=1000&color=58A6FF&center=true&vCenter=true&multiline=true&repeat=true&width=900&height=80&lines=%F0%9F%94%AC+The+Ultimate+Data+Science+Workbench;%F0%9F%9A%80+Desktop+%E2%80%A2+Web+%E2%80%A2+Mobile+%E2%80%A2+Cloud;%F0%9F%A7%A0+Powered+by+.NET+10+%2B+Python+%2B+Rust" alt="Typing Animation" />
</a>

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                       BADGE RIBBON                                    -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

[![.NET](https://img.shields.io/badge/.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com)
[![Blazor](https://img.shields.io/badge/Blazor-512BD4?style=for-the-badge&logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![Python](https://img.shields.io/badge/Python_3.10+-3776AB?style=for-the-badge&logo=python&logoColor=white)](https://python.org)
[![FastAPI](https://img.shields.io/badge/FastAPI-009688?style=for-the-badge&logo=fastapi&logoColor=white)](https://fastapi.tiangolo.com)
[![Rust](https://img.shields.io/badge/Rust-000000?style=for-the-badge&logo=rust&logoColor=white)](https://www.rust-lang.org)
[![PyTorch](https://img.shields.io/badge/PyTorch-EE4C2C?style=for-the-badge&logo=pytorch&logoColor=white)](https://pytorch.org)
[![TensorFlow](https://img.shields.io/badge/TensorFlow-FF6F00?style=for-the-badge&logo=tensorflow&logoColor=white)](https://www.tensorflow.org)
[![Azure](https://img.shields.io/badge/Azure-0078D4?style=for-the-badge&logo=microsoftazure&logoColor=white)](https://azure.microsoft.com)
[![SQLite](https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white)](https://www.sqlite.org)
[![License](https://img.shields.io/badge/License-MIT-22c55e?style=for-the-badge)](LICENSE)

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                        QUICK STATS                                    -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

<img src="https://img.shields.io/badge/Languages-3-blue?style=flat-square&labelColor=0d1117&color=1f6feb" />
<img src="https://img.shields.io/badge/Engines-3-blue?style=flat-square&labelColor=0d1117&color=238636" />
<img src="https://img.shields.io/badge/Platforms-5-blue?style=flat-square&labelColor=0d1117&color=a371f7" />
<img src="https://img.shields.io/badge/ML_Frameworks-6+-blue?style=flat-square&labelColor=0d1117&color=f78166" />

</div>

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                      CINEMATIC DIVIDER                                -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif" width="100%">

<br/>

## <img src="https://media.giphy.com/media/iY8CRBdQXODJSCERIr/giphy.gif" width="30"> &nbsp;Vision

> **AIMRAN Data Science Lab** is a **full-stack data science workbench** that runs as both a
> **native desktop app** *(MAUI Blazor Hybrid — Windows / macOS / Android / iOS)* and a
> **web application** *(ASP.NET Core Blazor Server)*. A single Razor Class Library supplies
> every UI component and service — **100% code reuse** across all platforms.

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                    ARCHITECTURE OVERVIEW                              -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## <img src="https://media.giphy.com/media/QssGEmpkyEOhBCb7e1/giphy.gif" width="28"> &nbsp;System Architecture

<div align="center">

```mermaid
%%{init: {'theme': 'dark', 'themeVariables': { 'primaryColor': '#1f6feb', 'primaryTextColor': '#ffffff', 'primaryBorderColor': '#58a6ff', 'lineColor': '#58a6ff', 'secondaryColor': '#161b22', 'tertiaryColor': '#0d1117', 'fontSize': '14px'}}}%%
graph TB
    subgraph UI["🖥️ User Interface Layer"]
        direction LR
        MAUI["📱 MAUI Blazor Hybrid<br/><i>Desktop & Mobile</i><br/>Windows · macOS · Android · iOS"]
        WEB["🌐 Blazor Server<br/><i>Web Application</i><br/>Any Browser"]
    end

    subgraph RCL["📦 Shared Razor Class Library"]
        direction LR
        COMP["🧩 Components<br/>& Pages"]
        SVC["⚙️ Services<br/>& Interfaces"]
        MDL["📊 Models<br/>& DTOs"]
    end

    subgraph CORE["🔧 Engine Core"]
        direction LR
        DB["🗄️ SQLite<br/>Persistence"]
        OPT["⚡ Engine<br/>Options"]
        RES["✅ Result‹T›<br/>Pattern"]
    end

    subgraph GW["🌉 Gateway Layer"]
        direction LR
        PY_C["🐍 Python<br/>Client"]
        RS_C["🦀 Rust<br/>Client"]
        R_C["📊 R<br/>Client"]
    end

    subgraph EXT["🚀 External Engines"]
        direction LR
        PY["🐍 Python FastAPI<br/><b>AI Engine :8100</b><br/>Training · Profiling · Cleaning"]
        RS["🦀 Rust Actix-Web<br/><b>Resource Engine :8200</b><br/>Monitoring · Delta · Hashing"]
    end

    subgraph CLOUD["☁️ Azure Cloud"]
        direction LR
        BLOB["📦 Blob<br/>Storage"]
        ML["🧠 ML<br/>Workspace"]
    end

    UI --> RCL
    RCL --> CORE
    RCL --> GW
    GW --> EXT
    RCL --> CLOUD

    style UI fill:#1a1b27,stroke:#58a6ff,stroke-width:2px,color:#ffffff
    style RCL fill:#1a1b27,stroke:#a371f7,stroke-width:2px,color:#ffffff
    style CORE fill:#1a1b27,stroke:#238636,stroke-width:2px,color:#ffffff
    style GW fill:#1a1b27,stroke:#f78166,stroke-width:2px,color:#ffffff
    style EXT fill:#1a1b27,stroke:#f0883e,stroke-width:2px,color:#ffffff
    style CLOUD fill:#1a1b27,stroke:#3fb950,stroke-width:2px,color:#ffffff
```

</div>

<br/>

<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif" width="100%">

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                    FEATURE SHOWCASE                                   -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## <img src="https://media.giphy.com/media/WUlplcMpOCEmTGBtBW/giphy.gif" width="30"> &nbsp;Feature Showcase

<div align="center">
<table>
<tr>
<td width="50%" valign="top">

### 🔬 Data Science Pipeline

| Feature | Description |
|:---:|:---|
| 📊 **Dashboard** | Live stats, resource meters, quick actions |
| 📁 **Dataset Manager** | Import CSV, Parquet, JSON, Excel |
| 🔄 **Version Control** | Binary delta snapshots, SHA-256 verification |
| 🧹 **Cleaning Studio** | AI-powered rule-based cleaning pipeline |
| 📈 **Profiling** | Column stats, distributions, correlations |
| 🎯 **Outlier Detection** | IQR & Z-score methods |

</td>
<td width="50%" valign="top">

### 🧠 Machine Learning

| Feature | Description |
|:---:|:---|
| 🧪 **Experiment Tracker** | Runs, hyperparameters, metrics |
| 🏗️ **Model Lab** | Train, compare, deploy models |
| 🐍 **AI Engine** | FastAPI with PyTorch & TensorFlow |
| 📦 **Plugin Hub** | pip/cargo package management |
| 📡 **Resource Monitor** | CPU, RAM, GPU, disk in real-time |
| ☁️ **Azure Integration** | Blob Storage & ML Workspace |

</td>
</tr>
</table>
</div>

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                   PLATFORM SUPPORT                                    -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

<div align="center">

### 🌍 One Codebase — Every Platform

```mermaid
%%{init: {'theme': 'dark', 'themeVariables': { 'primaryColor': '#238636', 'primaryTextColor': '#ffffff', 'primaryBorderColor': '#3fb950', 'lineColor': '#3fb950', 'secondaryColor': '#161b22', 'tertiaryColor': '#0d1117'}}}%%
graph LR
    SRC["🧬 Single<br/>Codebase"] --> WIN["🪟 Windows"]
    SRC --> MAC["🍎 macOS"]
    SRC --> AND["🤖 Android"]
    SRC --> IOS["📱 iOS"]
    SRC --> BROWSER["🌐 Browser"]

    style SRC fill:#238636,stroke:#3fb950,stroke-width:3px,color:#ffffff
    style WIN fill:#1a1b27,stroke:#58a6ff,stroke-width:2px,color:#ffffff
    style MAC fill:#1a1b27,stroke:#58a6ff,stroke-width:2px,color:#ffffff
    style AND fill:#1a1b27,stroke:#58a6ff,stroke-width:2px,color:#ffffff
    style IOS fill:#1a1b27,stroke:#58a6ff,stroke-width:2px,color:#ffffff
    style BROWSER fill:#1a1b27,stroke:#58a6ff,stroke-width:2px,color:#ffffff
```

</div>

<br/>

<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif" width="100%">

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                     PROJECT MAP                                       -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## <img src="https://media.giphy.com/media/ln7z2eWriiQAllfVcn/giphy.gif" width="28"> &nbsp;Project Map

<div align="center">

```
AIMRAN-DATA-SCIENCE-LAB/
│
├── 🔷 AimranDataScienceLab.Engine/          ← .NET Core • SQLite persistence & engine core
│   ├── Data/
│   │   ├── DatabaseInitializer.cs           ← Schema setup & initialization
│   │   └── SqliteConnectionFactory.cs       ← Connection pool management
│   └── Engine/
│       ├── EngineOptions.cs                 ← LocalOnly │ LocalFirst │ CloudFirst │ Hybrid
│       └── EngineResult.cs                  ← Result<T> pattern for error handling
│
├── 🔷 AimranDataScienceLab.Gateway/         ← .NET Core • HTTP gateway for external engines
│   ├── Clients/
│   │   ├── PythonEngineClient.cs            ← FastAPI HTTP client
│   │   ├── RustEngineClient.cs              ← Actix-Web HTTP client
│   │   ├── REngineClient.cs                 ← R engine HTTP client
│   │   ├── EngineProcessManager.cs          ← Start/stop engine processes
│   │   ├── GatewayManager.cs                ← Orchestration facade
│   │   ├── AuthTokenDelegatingHandler.cs    ← JWT/Bearer authentication
│   │   └── RetryDelegatingHandler.cs        ← Retry logic (3× with backoff)
│   ├── Interfaces/
│   │   ├── IPythonEngineClient.cs           ← Python client contract
│   │   ├── IRustEngineClient.cs             ← Rust client contract
│   │   ├── IREngineClient.cs                ← R engine client contract
│   │   └── IGatewayManager.cs               ← Gateway manager contract
│   └── Configuration/
│       └── GatewayOptions.cs                ← Gateway settings
│
├── 🐍 ai-engine/                            ← Python FastAPI • ML/AI workload engine
│   ├── main.py                              ← FastAPI server (:8100)
│   ├── schemas.py                           ← Pydantic request/response models
│   ├── requirements.txt                     ← 58 ML/AI dependencies
│   └── routers/
│       ├── experiments.py                   ← Experiment tracking
│       ├── models.py                        ← Model management
│       ├── profiling.py                     ← Data profiling
│       ├── cleaning.py                      ← Data cleaning
│       ├── code_execution.py                ← Safe code evaluation
│       └── visualization.py                 ← Chart/plot generation
│
├── 🧪 AimranDataScienceLab.Engine.Tests.csproj  ← xUnit test project
├── 📋 AIMRAN_DATA_SCIENCE_LAB_ARCHITECTURE.md   ← Detailed architecture guide
├── 📄 LICENSE                                    ← MIT License
└── 📖 README.md                                  ← You are here!
```

</div>

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                  ENGINE MODE PIPELINE                                 -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## ⚡ Engine Modes

<div align="center">

```mermaid
%%{init: {'theme': 'dark', 'themeVariables': { 'primaryColor': '#f78166', 'primaryTextColor': '#ffffff', 'primaryBorderColor': '#f0883e', 'lineColor': '#f78166', 'secondaryColor': '#161b22', 'tertiaryColor': '#0d1117'}}}%%
flowchart LR
    SELECT{{"⚙️ Engine Mode"}} -->|LocalOnly| LO["🔒 All C# In-Process<br/>In-Memory Storage"]
    SELECT -->|LocalFirst| LF["💾 SQLite Persistence<br/>C# Processing<br/><b>DEFAULT</b>"]
    SELECT -->|CloudFirst| CF["☁️ Prefer Azure ML<br/>When Configured"]
    SELECT -->|Hybrid| HY["🔀 AI → Python Engine<br/>Resources → Rust Engine<br/>Core → C# In-Process"]

    style SELECT fill:#f78166,stroke:#f0883e,stroke-width:3px,color:#ffffff
    style LO fill:#1a1b27,stroke:#8b949e,stroke-width:2px,color:#ffffff
    style LF fill:#238636,stroke:#3fb950,stroke-width:3px,color:#ffffff
    style CF fill:#1a1b27,stroke:#58a6ff,stroke-width:2px,color:#ffffff
    style HY fill:#1a1b27,stroke:#a371f7,stroke-width:2px,color:#ffffff
```

</div>

<br/>

<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif" width="100%">

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                 DETAILED FEATURES (COLLAPSIBLE)                       -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## <img src="https://media.giphy.com/media/VgCDAzcKvsR6OM0uWg/giphy.gif" width="28"> &nbsp;Deep Dive

<details>
<summary><b>📊 Page-by-Page Feature Guide</b> &nbsp;(click to expand)</summary>

<br/>

| Route | Page | Features |
|:---:|:---|:---|
| `/` | **Dashboard** | Real-time project/dataset/experiment/model counts, live CPU/RAM/disk usage bars, quick-action buttons |
| `/projects` | **Project Management** | CRUD with status (Active/Archived/Completed), tag-based filtering, Azure workspace binding |
| `/projects/{id}` | **Project Workspace** | Unified view of datasets/experiments/models, link/unlink assets, scoped experiments |
| `/datasets` | **Dataset Manager** | Import CSV/Parquet/JSON/Excel, row/column counts, preview first N rows, format detection |
| `/versioning` | **Dataset Versioning** | Point-in-time snapshots, binary delta compression, SHA-256 verification, diff visualization |
| `/data-cleaning` | **Cleaning Studio** | Column-level profiling, outlier detection (IQR/Z-score), rule-based pipeline, before/after comparison |
| `/experiments` | **Experiment Tracker** | Create experiments, track runs with hyperparameters, compare metrics, submit to AI engine |
| `/models` | **Model Lab** | Register models, version management, performance comparisons, deploy to Azure ML |
| `/ai-engine` | **AI Engine Manager** | Health status, start/stop engines, stream real-time logs, process monitoring |
| `/plugins` | **Plugin Hub** | Browse pip/cargo packages, install/upgrade/uninstall, model version registry |
| `/resources` | **Resource Monitor** | Live CPU per core, RAM used/available, disk I/O, GPU detection via Rust engine |
| `/azure` | **Azure Integration** | Configure subscription, test connectivity, upload to Blob, submit to Azure ML |

</details>

<details>
<summary><b>🌉 Service Gateway Architecture</b> &nbsp;(click to expand)</summary>

<br/>

```mermaid
%%{init: {'theme': 'dark', 'themeVariables': { 'primaryColor': '#1f6feb', 'primaryTextColor': '#ffffff', 'primaryBorderColor': '#58a6ff', 'lineColor': '#58a6ff', 'secondaryColor': '#161b22', 'tertiaryColor': '#0d1117'}}}%%
graph TB
    GM["🌉 IGatewayManager<br/>CheckHealth · StartEngines · StopEngines<br/>GetProcessStates · GetEngineLogs"]

    GM --> PYC["🐍 IPythonEngineClient"]
    GM --> RSC["🦀 IRustEngineClient"]
    GM --> RC["📊 IREngineClient"]

    PYC --> PY_PIPE["🔗 HttpClient Pipeline<br/>AuthToken → Retry 3×"]
    RSC --> RS_PIPE["🔗 HttpClient Pipeline<br/>AuthToken → Retry 3×"]
    RC --> R_PIPE["🔗 HttpClient Pipeline<br/>AuthToken → Retry 3×"]

    PY_PIPE --> PY_ENG["🐍 Python FastAPI :8100<br/>Experiments · Training · Profiling<br/>Cleaning · Code Execution · Visualization"]
    RS_PIPE --> RS_ENG["🦀 Rust Actix-Web :8200<br/>Resource Monitoring · Delta Compute<br/>CSV Parsing · File Hashing"]
    R_PIPE --> R_ENG["📊 R Engine<br/>Statistical Analysis<br/>Advanced Visualization"]

    style GM fill:#1f6feb,stroke:#58a6ff,stroke-width:3px,color:#ffffff
    style PYC fill:#1a1b27,stroke:#3572A5,stroke-width:2px,color:#ffffff
    style RSC fill:#1a1b27,stroke:#dea584,stroke-width:2px,color:#ffffff
    style RC fill:#1a1b27,stroke:#276DC3,stroke-width:2px,color:#ffffff
    style PY_ENG fill:#238636,stroke:#3fb950,stroke-width:2px,color:#ffffff
    style RS_ENG fill:#238636,stroke:#3fb950,stroke-width:2px,color:#ffffff
    style R_ENG fill:#238636,stroke:#3fb950,stroke-width:2px,color:#ffffff
```

</details>

<details>
<summary><b>🗄️ Data Model</b> &nbsp;(click to expand)</summary>

<br/>

```mermaid
%%{init: {'theme': 'dark', 'themeVariables': { 'primaryColor': '#a371f7', 'primaryTextColor': '#ffffff', 'primaryBorderColor': '#bc8cff', 'lineColor': '#a371f7', 'secondaryColor': '#161b22', 'tertiaryColor': '#0d1117'}}}%%
erDiagram
    PROJECT ||--o{ DATASET : contains
    PROJECT ||--o{ EXPERIMENT : contains
    PROJECT ||--o{ ML_MODEL : contains
    DATASET ||--o{ DATASET_VERSION : versioned
    DATASET_VERSION ||--|| DELTA_DATA : stores
    EXPERIMENT ||--o{ EXPERIMENT_RUN : tracks
    EXPERIMENT_RUN ||--|| METRICS : measures
    ML_MODEL ||--|| HYPERPARAMETERS : configured
    ML_MODEL ||--|| PERFORMANCE_METRICS : evaluated
    DATASET ||--o{ DATA_PROFILE : profiled
    DATA_PROFILE ||--o{ COLUMN_PROFILE : details
    COLUMN_PROFILE ||--o{ OUTLIER_RESULT : detects
    CLEANING_RULE ||--o{ CLEANING_OPERATION : applies

    PROJECT {
        string Id PK
        string Name
        string Status
        string[] Tags
        string AzureWorkspace
    }

    DATASET {
        string Id PK
        string Name
        string Format
        int RowCount
        int ColumnCount
    }

    EXPERIMENT {
        string Id PK
        string Name
        string DatasetId FK
    }

    ML_MODEL {
        string Id PK
        string Name
        string Version
        string Endpoint
    }
```

</details>

<details>
<summary><b>🔧 DI Registration — Single Entry Point</b> &nbsp;(click to expand)</summary>

<br/>

Both hosts register the entire service graph with **one call**:

```csharp
// MauiProgram.cs  OR  Web Program.cs
builder.Services.AddAimranDataScienceLab();
```

| Layer | Registered Services |
|:---|:---|
| **Engine Core** | `IAimranEngine`, `EngineOptions` |
| **SQLite Persistence** | `SqliteConnectionFactory`, `DatabaseInitializer` |
| **Core CRUD** | `IProjectService`, `IDatasetService`, `IExperimentService`, `IModelService` |
| **Resource Monitoring** | `IResourceMonitorService` |
| **Data Cleaning** | `IDataProfilingService`, `IOutlierDetectionService`, `IDataCleaningService`, `ICleaningRuleService` |
| **Dataset Versioning** | `IDatasetStorageProvider`, `IDeltaEngine`, `IDatasetVersionService` |
| **Azure Cloud** | `IAzureConfigService`, `IAzureStorageService`, `IAzureMlService` |
| **Service Gateway** | `IGatewayManager`, `IPythonEngineClient`, `IRustEngineClient`, `EngineProcessManager` |
| **Plugin Manager** | `IPluginManagerService` |

</details>

<br/>

<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif" width="100%">

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                    TECHNOLOGY STACK                                    -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## <img src="https://media2.giphy.com/media/QssGEmpkyEOhBCb7e1/giphy.gif" width="28"> &nbsp;Technology Stack

<div align="center">

<table>
<tr><td colspan="4" align="center"><b>🏗️ Core Platform</b></td></tr>
<tr>
<td align="center"><img src="https://img.shields.io/badge/-.NET_10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" /><br/><sub>Runtime</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-Blazor-512BD4?style=for-the-badge&logo=blazor&logoColor=white" /><br/><sub>UI Framework</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-.NET_MAUI-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" /><br/><sub>Desktop Host</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-ASP.NET_Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" /><br/><sub>Web Host</sub></td>
</tr>

<tr><td colspan="4" align="center"><b>🐍 AI / ML Engine</b></td></tr>
<tr>
<td align="center"><img src="https://img.shields.io/badge/-FastAPI-009688?style=for-the-badge&logo=fastapi&logoColor=white" /><br/><sub>API Server</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-PyTorch-EE4C2C?style=for-the-badge&logo=pytorch&logoColor=white" /><br/><sub>Deep Learning</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-TensorFlow-FF6F00?style=for-the-badge&logo=tensorflow&logoColor=white" /><br/><sub>Deep Learning</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-scikit--learn-F7931E?style=for-the-badge&logo=scikitlearn&logoColor=white" /><br/><sub>ML Library</sub></td>
</tr>
<tr>
<td align="center"><img src="https://img.shields.io/badge/-XGBoost-006600?style=for-the-badge" /><br/><sub>Boosting</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-LightGBM-9ACD32?style=for-the-badge" /><br/><sub>Boosting</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-MLflow-0194E2?style=for-the-badge&logo=mlflow&logoColor=white" /><br/><sub>Tracking</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-Optuna-4B0082?style=for-the-badge" /><br/><sub>HPO</sub></td>
</tr>

<tr><td colspan="4" align="center"><b>📊 Data & Visualization</b></td></tr>
<tr>
<td align="center"><img src="https://img.shields.io/badge/-pandas-150458?style=for-the-badge&logo=pandas&logoColor=white" /><br/><sub>DataFrames</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-NumPy-013243?style=for-the-badge&logo=numpy&logoColor=white" /><br/><sub>Numerical</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-Plotly-3F4F75?style=for-the-badge&logo=plotly&logoColor=white" /><br/><sub>Interactive Viz</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-Matplotlib-11557C?style=for-the-badge" /><br/><sub>Static Viz</sub></td>
</tr>

<tr><td colspan="4" align="center"><b>🦀 Performance & Cloud</b></td></tr>
<tr>
<td align="center"><img src="https://img.shields.io/badge/-Rust-000000?style=for-the-badge&logo=rust&logoColor=white" /><br/><sub>Resource Engine</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-Actix_Web-000000?style=for-the-badge" /><br/><sub>HTTP Server</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-Azure-0078D4?style=for-the-badge&logo=microsoftazure&logoColor=white" /><br/><sub>Cloud Services</sub></td>
<td align="center"><img src="https://img.shields.io/badge/-SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white" /><br/><sub>Local Database</sub></td>
</tr>
</table>

</div>

<br/>

<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif" width="100%">

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                    DATA SCIENCE PIPELINE                              -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## 🔬 End-to-End Data Science Pipeline

<div align="center">

```mermaid
%%{init: {'theme': 'dark', 'themeVariables': { 'primaryColor': '#238636', 'primaryTextColor': '#ffffff', 'primaryBorderColor': '#3fb950', 'lineColor': '#58a6ff', 'secondaryColor': '#161b22', 'tertiaryColor': '#0d1117'}}}%%
flowchart TB
    A["📂 Import Data<br/><i>CSV · Parquet · JSON · Excel</i>"] --> B["🔍 Profile & Explore<br/><i>Stats · Distributions · Correlations</i>"]
    B --> C["🧹 Clean & Transform<br/><i>Rules · Outliers · Null Handling</i>"]
    C --> D["📸 Version Snapshot<br/><i>Delta Compression · SHA-256</i>"]
    D --> E["🧪 Design Experiment<br/><i>Hyperparameters · Dataset Binding</i>"]
    E --> F["🚀 Train Model<br/><i>PyTorch · TensorFlow · XGBoost</i>"]
    F --> G["📊 Evaluate & Compare<br/><i>Metrics · Visualization · SHAP</i>"]
    G --> H["🏆 Register Best Model<br/><i>Version · Metadata · Endpoint</i>"]
    H --> I["☁️ Deploy to Azure<br/><i>ML Workspace · Blob Storage</i>"]

    style A fill:#1f6feb,stroke:#58a6ff,stroke-width:2px,color:#ffffff
    style B fill:#1f6feb,stroke:#58a6ff,stroke-width:2px,color:#ffffff
    style C fill:#238636,stroke:#3fb950,stroke-width:2px,color:#ffffff
    style D fill:#238636,stroke:#3fb950,stroke-width:2px,color:#ffffff
    style E fill:#a371f7,stroke:#bc8cff,stroke-width:2px,color:#ffffff
    style F fill:#a371f7,stroke:#bc8cff,stroke-width:2px,color:#ffffff
    style G fill:#f78166,stroke:#f0883e,stroke-width:2px,color:#ffffff
    style H fill:#f78166,stroke:#f0883e,stroke-width:2px,color:#ffffff
    style I fill:#da3633,stroke:#f85149,stroke-width:2px,color:#ffffff
```

</div>

<br/>

<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif" width="100%">

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                     QUICK START                                       -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## 🚀 Quick Start

<table>
<tr>
<td width="50%">

### 🌐 Web Application

```bash
# Clone the repository
git clone https://github.com/AIMRAN-ai/AIMRAN-DATA-SCIENCE-LAB.git
cd AIMRAN-DATA-SCIENCE-LAB

# Run the web host
cd AimranDataScienceLab.Web
dotnet run
# → https://localhost:5001
```

</td>
<td width="50%">

### 📱 MAUI Desktop (Windows)

```bash
# Build for Windows
dotnet build "AIMRAN Data Science Lab.csproj" \
  -f net10.0-windows10.0.19041.0

# Run the desktop app
dotnet run -f net10.0-windows10.0.19041.0
```

</td>
</tr>
<tr>
<td width="50%">

### 🐍 Python AI Engine

```bash
# Start the AI engine
cd ai-engine
pip install -r requirements.txt
uvicorn main:app --port 8100
# → http://localhost:8100/docs
```

</td>
<td width="50%">

### 🦀 Rust Resource Engine

```bash
# Start the resource engine
cd rust-engine
cargo run -- --port 8200
# → http://localhost:8200/health
```

</td>
</tr>
<tr>
<td colspan="2">

### 🧪 Run Tests

```bash
dotnet test AimranDataScienceLab.Engine.Tests
```

</td>
</tr>
</table>

<br/>

<img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif" width="100%">

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                  PYTHON AI ENGINE ENDPOINTS                           -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## 🐍 AI Engine API

<div align="center">

| Method | Endpoint | Description |
|:---:|:---|:---|
| `GET` | `/health` | Health check & engine status |
| `POST` | `/api/experiments` | Submit experiment for training |
| `POST` | `/api/models` | Register trained model |
| `POST` | `/api/profiling` | Profile dataset columns |
| `POST` | `/api/cleaning` | Apply cleaning rules |
| `POST` | `/api/code` | Execute Python code safely |
| `POST` | `/api/visualization` | Generate charts & plots |

</div>

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                     CONTRIBUTING                                      -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## 🤝 Contributing

Contributions are welcome! Whether it's a bug fix, feature request, or documentation improvement — every contribution matters.

1. **Fork** the repository
2. **Create** your feature branch (`git checkout -b feature/amazing-feature`)
3. **Commit** your changes (`git commit -m 'Add amazing feature'`)
4. **Push** to the branch (`git push origin feature/amazing-feature`)
5. **Open** a Pull Request

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                        LICENSE                                        -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

## 📄 License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                      AUTHOR SECTION                                   -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

<div align="center">

---

### 👨‍💻 Created by **Abdullah Imran**

<a href="https://github.com/AIMRAN-ai">
  <img src="https://img.shields.io/badge/GitHub-AIMRAN--ai-181717?style=for-the-badge&logo=github&logoColor=white" />
</a>

<br/><br/>

⭐ **Star this repo** if you find it useful!

<br/>

<!-- ═══════════════════════════════════════════════════════════════════════ -->
<!--                    ANIMATED FOOTER                                    -->
<!-- ═══════════════════════════════════════════════════════════════════════ -->

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:79c0ff,25:58a6ff,50:1f6feb,75:161b22,100:0d1117&height=150&section=footer" width="100%" />

</div>