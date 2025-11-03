# 💼 Digital Receipt and Expense Tracker System

A modern C# Windows Forms application designed to help businesses **record sales**, **generate digital receipts**, and **track expenses efficiently**.  
Developed as a **capstone project** for the Bachelor of Science in Information Technology program.

---

## 🧠 Overview

The **Digital Receipt and Expense Tracker System** provides a seamless way to record customer transactions, generate receipts, and monitor expenses.  
It integrates with **MySQL (via XAMPP)** and uses **C# (Windows Forms)** for a clean, desktop-based interface.

---

## ✨ Features

✅ **User Login System**  
- Secure authentication with database integration  
- Supports role-based access (Admin, Cashier, etc.)

✅ **Sales Management**  
- Add multiple items per sale  
- Automatically compute subtotals and totals  
- Linked to user accounts for accountability

✅ **Digital Receipt Generation**  
- Generates printable or PDF receipts for each transaction  
- Automatically timestamps and records sales

✅ **Expense Tracking Dashboard** *(coming soon)*  
- Displays total sales and expense summaries  
- Graphical representation of income trends

✅ **Database Integration**  
- Fully connected to MySQL via MySQL Connector/.NET  
- Uses relational structure for `users`, `sales`, and `sale_items`

---

## 🛠️ Tech Stack

| Component | Technology |
|------------|-------------|
| **Frontend** | C# (Windows Forms, Visual Studio) |
| **Database** | MySQL (XAMPP) |
| **Languages Used** | HTML, CSS, C# |
| **Connector** | MySQL Connector for .NET |
| **Version Control** | Git & GitHub (`Treusu`) |

---

## 🧩 System Architecture

```mermaid
flowchart TD
    A[Login Form] --> B[Dashboard]
    B --> C[Sales Form]
    C --> D[MySQL Database]
    D --> E[Receipt Generator / Reports]
