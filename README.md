# DVLD - Driving License Management System

A Windows desktop application that simulates a real-world driving license department.

Built with **C# WinForms**, **SQL Server**, and a classic **3-layer architecture (Presentation, Business, Data Access)** as part of my journey learning desktop application development and backend system design.

> **Note**
> This is a learning project built while studying desktop application development. It is **not production-ready**, and several limitations are intentionally documented below.

---

# Architecture

The solution follows a classic 3-tier architecture to separate responsibilities between the UI, business logic, and database access.

```
Presentation Layer (WinForms)
        │
Business Logic Layer
        │
Data Access Layer (ADO.NET)
        │
     SQL Server
```

Projects:

- **DVLD** — WinForms presentation layer.
- **DVLD_BusinessLayer** — Business logic and business rules.
- **DVLD_DataAccessLayer** — Database access using ADO.NET.

---

# Features

### Authentication
- User login

### People & Drivers
- Add, edit, delete, and search people
- Driver management

### License Applications
- Local driving license applications
- International driving license applications

### License Management
- Issue licenses
- Renew licenses
- Replace lost or damaged licenses
- Detain licenses
- Release detained licenses

### Testing
- Schedule vision tests
- Schedule written tests
- Schedule street tests

### Administration
- User management

---

# Tech Stack

- C#
- .NET Framework 4.8
- WinForms
- SQL Server
- ADO.NET

---

# Requirements

- Windows
- Visual Studio 2022
- SQL Server 2022 (Express, Developer, or Standard)

---

# Getting Started

1. Restore the database backup located at:

```
Database/DVLD.bak
```

2. Update the connection string in:

```
DVLD_DataAccessLayer/DAL_Settings.cs
```

3. Open `DVLD.sln`.
4. Build and run the project.

---

# What I Learned

This project significantly changed how I think about building business applications.

Some of the concepts I practiced throughout the project include:

- 3-Tier Architecture
- SQL Server & ADO.NET
- Business workflow modeling
- Database normalization
- Generalization & Specialization
- Object-Oriented Programming
- Separation of Concerns
- Desktop application development

---

# Known Limitations

This project focuses on learning the fundamentals and therefore has several limitations.

- Passwords are stored as plain text (no hashing).
- No SQL transactions for multi-step operations.
- No dependency injection.
- No centralized exception handling.
- No ORM (Entity Framework / Dapper).
- Basic UI validation only.
- No unit tests.

These are acknowledged limitations rather than overlooked issues.

---

# About

This project was built while learning desktop application development with C#, SQL Server, WinForms, and layered architecture.

The goal wasn't to build a production-ready system, but to understand how medium-sized business applications are structured, how different layers communicate, and how real-world business workflows can be translated into code.

It represents one of the biggest learning milestones in my software engineering journey so far.