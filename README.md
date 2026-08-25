# PDF Viewer User Restrictions Sample

## Overview
This ASP.NET Core web application demonstrates user restrictions on annotations and form fields in the Syncfusion PDF Viewer. The sample includes a user dropdown that allows switching between users. When a user is switched, annotations and form fields created by other users are restricted from being edited in the PDF Viewer.

## Use Cases
- Multi-user support with user switching via dropdown
- User-based annotation restrictions
- User-based form field restrictions (read-only for other users' fields)

## Prerequisites
- .NET 10.0 or later
- Syncfusion NuGet packages (automatically included in the project)

## How to Run

### Step 1: Navigate to the Project Directory
```bash
cd "User Restriction Demo"
```

### Step 2: Restore Dependencies
```bash
dotnet restore
```

### Step 3: Build the Project
```bash
dotnet build
```

### Step 4: Run the Application
```bash
dotnet run
```

The application will start and be available at `https://localhost:5206` (or the port specified in your launch settings).

