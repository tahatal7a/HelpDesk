# HelpDesk Desktop Application

HelpDesk is a desktop application designed to streamline **technical support** management in an enterprise environment.
It focuses on efficient ticket handling, clear communication with users, and intelligent prioritization of incidents to improve resolution time and service quality.

---

## Project Overview

It demonstrates how a helpdesk application can transform the management of technical support by providing a structured, multi-role system (Employee, Technician, Admin).

Main goals:

- Provide a centralized platform to manage technical support requests.
- Optimize ticket lifecycle: creation, assignment, follow-up, and resolution.
- Improve communication between users and support teams.
- Enable better prioritization and monitoring of incidents through dashboards and statistics.

---

## Problem Statement

How can we improve the efficiency and effectiveness of enterprise technical support systems by integrating:

- Optimized ticket management. 
- Better communication with end users. 
- Effective prioritization of technical problems. 

This project answers this question by proposing a complete helpdesk solution with clear roles and dedicated interfaces. 

---

## Technologies Used

Main technologies:

- **C#** – main language for the desktop application.
- **.NET / .NET Core** – framework for the desktop client and business logic.
- **Visual Studio** – primary IDE for development.
- **Microsoft SQL Server** – relational database for persistent storage.
- **Git / GitHub** – version control and project hosting. 

> Note: The architecture is designed to be extensible so that future modules or services can be integrated easily. 

---

## Main Features

### 1. Ticket Management

- Create tickets with description, category, and priority (e.g., high, low). 
- Track ticket status: ouvert, en cours, résolu, fermé. 
- View detailed ticket history with timestamps for creation and closure.

### 2. User Communication

- Notification center to inform users about ticket updates (e.g., ticket resolved).
- Real-time style dashboard showing number of tickets, current time/date, and status indicators.

### 3. Role-Based Interfaces

The application defines three main roles, each with its own interface. 

#### Employee Interface

- Dashboard showing personal information and ticket statistics. 
- Create new tickets with priority and category. 
- View ticket history with full list of previously submitted tickets. 
- Receive notifications when tickets are updated or resolved. 

#### Technician Interface

- Dashboard displaying number of open and resolved tickets. [file:1]
- List of tickets with details (employee, department, service, office, description). 
- Accept and process tickets from a queue. 
- Manage interventions: add comments, update ticket status (en cours, résolu, fermé). 
- View intervention history (dates, times, ticket IDs). 

#### Admin Interface

- Dashboard with global statistics: total technicians, total employees, total tickets, resolved tickets.
- Manage technicians: add, update, delete records (name, username, password, department, service, office, phone, speciality). 
- Manage employees with similar fields, including department, service, office, and floor. 
- Manage tickets: edit description, category, status, priority, opening and closing dates. 
- Manage problem categories. 

---

## Functional Design

### Use Case Overview

The main use cases include: 

- Employee: follow ticket status, report a problem, create tickets, view notifications. 
- Technician: consult and choose tickets, resolve tickets, analyze reports and statistics. 
- Administrator: manage users and configurations (employees, technicians, categories, tickets). 





