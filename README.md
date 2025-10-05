# Swedish Flash Cards App

A web-based Swedish flash card application built with Blazor WebAssembly.

## Features

- **31 Swedish Words & Phrases**: Learn common Swedish vocabulary including:
  - Basic greetings (Hello, Thank you, Yes, No, etc.)
  - Numbers (One through Five)
  - Common nouns (Water, Food, House, Car, Book)
  - Colors (Red, Blue, Green, Yellow, Black, White)
  - Family terms (Family, Mother, Father, Child)

- **Interactive Flash Cards**: Click on cards to flip between Swedish and English translations
- **Navigation**: Move forward and backward through the deck
- **Progress Tracking**: Visual progress bar shows your position in the deck
- **Responsive Design**: Beautiful gradient cards with smooth animations

## Running the Application

### Prerequisites
- .NET 8.0 SDK or later

### Build and Run
```bash
cd SwedishFlashCards
dotnet run
```

Then open your browser to the URL shown in the console (typically `https://localhost:5001` or `http://localhost:5000`).

## Project Structure

- `Pages/` - Razor components for the UI
  - `Home.razor` - Landing page
  - `FlashCards.razor` - Main flash card interface
- `Models/` - Data models
  - `FlashCard.cs` - Flash card data structure
- `Services/` - Business logic
  - `FlashCardService.cs` - Flash card data and operations
- `Layout/` - Layout components
  - `MainLayout.razor` - Main app layout
  - `NavMenu.razor` - Navigation menu

## Technologies Used

- Blazor WebAssembly
- .NET 8.0
- C#
- HTML/CSS