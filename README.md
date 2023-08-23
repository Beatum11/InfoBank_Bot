# BankInfo | Telegram Bot

This Telegram bot provides users with detailed information about specific banks. It has been developed using .NET 6 and leverages the `telegram.bot` library for seamless integration with the Telegram platform.

## Features

- **Bank Details**: Get comprehensive information about a specific bank, including contact information, SWIFT, location, and more.
- **Quick Search**: Easily search for banks using keywords or identifiers.

## Getting Started

### Prerequisites

- .NET 6
- Telegram Bot Token

### Installation

1. Clone the repository:
   ```
   git clone https://github.com/Beatum11/InfoBank_Bot
   ```

2. Navigate to the project directory:
   ```
   cd InfoBank_Bot
   ```

3. Install the necessary dependencies:
   ```
   dotnet restore
   ```

4. Add your Telegram Bot Token to the appropriate configuration file or environment variable.

5. Run the application:
   ```
   dotnet run
   ```

## Usage

Interact with the bot on Telegram by sending specific commands or inquiries about banks. Example commands include:

- `/bankinfo <bank-name> | <bank-inn> | <bank-swift>`: Retrieve information about a specific bank.
- `/start`: Get a friendly welcome message.
