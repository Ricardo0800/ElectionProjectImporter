# Election Project

<img width="100%" src="https://capsule-render.vercel.app/api?type=waving&color=0f0b21&height=200&section=header&text=Election%20Project&fontSize=55&fontColor=fdf6e3&fontAlignY=38&desc=Data%20Engineering%20%E2%80%A2%20Backend%20%E2%80%A2%20AI&descSize=20&descAlignY=62&descColor=fdf6e3"/>

A software project focused on organizing political candidates' proposals and helping users explore how their priorities align with those proposals.

Currently under development as a practical learning project involving backend engineering, database design, and AI-powered information retrieval.

---

# 📌 Project Overview

The goal is to build an application where users can describe their political priorities and explore candidates whose published proposals align with their interests.

The project is being developed incrementally, starting with data preparation and database integration before moving toward the backend API, AI integration, and user interface.

---

# ⚙️ Current Development Stage

## 1. **Candidate Data Importer**

*Status: Initial implementation completed*

A C# console application that imports structured candidate data from a JSON file into a PostgreSQL database.

- C# and .NET
- JSON deserialization
- Entity Framework Core
- PostgreSQL integration
- Relational data modeling
- Database migrations
- Candidate, category, and topic management

The current data model organizes information into three main entities:

- Candidates
- Categories
- Topics

This structure provides the initial database foundation for the next stages of the project.

---

# 🏗️ Planned Architecture

## 1. **Data Layer**
- PostgreSQL database
- Structured candidate information
- Categories and related topics
- Data persistence through Entity Framework Core

---

## 2. **Backend API**
*Status: Planned*

A C# backend responsible for exposing candidate data and handling application requests.

- ASP.NET Core Web API
- REST endpoints
- Database queries
- Input validation
- Application logic
- Secure configuration and secret management

---

## 3. **AI & Information Retrieval**
*Status: Planned*

An AI-powered component designed to help users explore relationships between their priorities and candidates' published proposals.

- Gemini API integration
- Retrieval-Augmented Generation (RAG)
- Semantic search
- Potential vector search with PostgreSQL and pgvector
- Context-aware candidate comparison

The retrieval and matching approach will be developed and evaluated as the project progresses.

---

## 4. **Web Application**
*Status: Planned*

A user-facing interface for interacting with the system.

- React
- Interactive question-and-answer flow
- Candidate and proposal exploration
- Results based on users' stated priorities
- Integration with the backend API

---

# 🛠️ Technologies

## Languages
- C#
- JavaScript / TypeScript *(planned for the frontend)*

---

## Backend & Data
- .NET
- Entity Framework Core
- ASP.NET Core Web API *(planned)*
- JSON
- REST APIs *(planned)*

---

## Databases
- PostgreSQL
- Relational data modeling
- Database migrations

---

## AI & Retrieval
- Google Gemini API *(planned)*
- Retrieval-Augmented Generation (RAG) *(planned)*
- pgvector *(under consideration)*

---

## Tools
- Git
- GitHub
- Visual Studio Code
- PostgreSQL tools

---

# 🎯 Project Goals

Building practical experience in:

- Backend engineering with C#
- Database design and data modeling
- API development
- AI integration
- Information retrieval
- Secure software development
- Software architecture

---

# 🧠 Development Philosophy

> "Build the foundations first, understand each component, and integrate complexity one step at a time."

The project prioritizes understanding the underlying technologies, maintaining a clear architecture, and developing features incrementally rather than relying on a prebuilt solution.

---

# 🌐 Developer

**GitHub:** https://github.com/Ricardo0800

<img width="100%" src="https://capsule-render.vercel.app/api?type=waving&color=0:0f0b21,100:0f0b21&height=120&section=footer"/>
