# Console Assignments: **Book** & **Product**

A small .NET console solution with two independent assignments:

- **Book App** — create one `Book` via a static factory and print its details via an instance method.  
- **Product App** — create one `Product` with validated input (price/date), choose a `Category`, then print details in a specific date format.

---

## Prerequisites

- **.NET SDK 9** (recommended: .NET 8)  
- A terminal (Windows Terminal / PowerShell / bash)  
- (Optional) Visual Studio / Rider / VS Code

---

## Project Layout (suggested)

```
/ (repo root)
├─ src/
│  ├─ BookApp/
│  │  ├─ Program.cs
│  │  └─ Models/Book.cs
│  └─ ProductApp/
│     ├─ Program.cs
│     └─ Models/
│        ├─ Product.cs
│        ├─ Category.cs
│        └─ SelectCategory.cs
├─ .gitignore
└─ README.md
```

>You can also keep both in a single project and call them from a menu, but **two projects** keeps each assignment clean.

---

## Build & Run

```bash
# Book assignment
dotnet run --project src/BookApp

# Product assignment
dotnet run --project src/ProductApp
```

---

## 1) Book App

### Requirements
- **Class:** `Book`  
  - Properties: `Title` (`string`), `Author` (`string`), `Pages` (`int`)
- **Instance method:** `DisplayInfo()` → prints:  
  `Title: <title>, Author: <author>, Pages: <pages>`
- **Static method:** `CreateBook()`  
  - Prompts for Title, Author, Pages (using `Console.ReadLine()`)
  - Validates pages with `int.TryParse()`
  - Returns a `Book` instance

### Program flow
1. Call `Book.CreateBook()`
2. Call `book.DisplayInfo()`

### Sample I/O
```
Enter the book title: Git book
Enter the book author: Harper Lee
Enter the number of pages: 324
Title: Git book, Author: Harper Lee, Pages: 324
```

---

## 2) Product App

### Requirements
- **Enum:** `Category` (e.g. `Electronics = 1, Furniture, Shoes, Books, Software`)
- **Class:** `Product`  
  - Properties:
    - `Name` (`string`)
    - `Price` (`decimal`)
    - `StockQuantity` (`int`)
    - `ManufactureDate` (`DateTime`)
    - `Category` (`Category`)
- **Instance method:** `DisplayProductInfo()`  
  - Prints **Name**, **Price**, **StockQuantity**, **ManufactureDate** in **`dd-MM-yyyy`**
- **Static method:** `CreateProduct()`  
  - Prompts for **Name**, **Price**, **StockQuantity**, **ManufactureDate**
  - Validates with **`decimal.TryParse()`** and **`DateTime.TryParse()`**  
    (If invalid → show error & re‑prompt until valid)
  - Prompts **Category** (by number or name)
  - Returns a `Product` instance

### Validation snippets
```csharp
// Price
while (!decimal.TryParse(input, out price) || price < 0)
    Console.Write("Invalid price. Try again: ");

// StockQuantity
while (!int.TryParse(input, out qty) || qty < 0)
    Console.Write("Invalid quantity. Try again: ");

// ManufactureDate (flexible)
while (!DateTime.TryParse(input, out mfgDate))
    Console.Write("Invalid date. Try again: ");
// or strict dd-MM-yyyy:
// while (!DateTime.TryParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out mfgDate))
```

### Program flow
1. Call `Product.CreateProduct()`  
2. Call `product.DisplayProductInfo()`

### Sample I/O
```
Enter product name: Laptop
Enter product price: 4500.99
Enter stock quantity: 5
Categories:
1. Electronics
2. Furniture
3. Shoes
4. Books
5. Software
Choose category (number or name): Electronics
Enter manufacture date (dd-MM-yyyy) : 15-09-2023

Product: Laptop, Price: 4500.99, Stock: 5, Manufacture Date: 15-09-2023
```

> **Note:** You may parse the date flexibly with `DateTime.TryParse()` but **display** must be `dd-MM-yyyy`. If you want to **force input** in that exact format, use `TryParseExact`.

---

## Example `Main` files

**BookApp/Program.cs**
```csharp
var book = Book.CreateBook();
book.DisplayInfo();
```

**ProductApp/Program.cs**
```csharp
var product = Product.CreateProduct();
product.DisplayProductInfo();
```

---
