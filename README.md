# 🔐 Password Generator

## 📝 Description

This C# console application generates a random password based on user-selected criteria.  
The user can specify the password length (up to 32 characters) and choose to include lowercase letters, uppercase letters, digits, and special characters.

## ⚙️ Features

- ✅ Validates user input for length and character type choices.  
- 🔢 Limits password length between 1 and 32 characters.  
- 🔄 Re-prompts if the user gives invalid answers to yes/no questions.  
- 🔐 Generates a secure random password according to selected options.  
- ❌ Displays an error message if no character types are selected.

## 🚀 Usage

1. ▶️ Run the program.  
2. 🔢 Enter the desired password length (max 32).  
3. ❓ Answer “y” (yes) or “n” (no) to include lowercase letters, uppercase letters, digits, and special characters.  
4. 🔑 The program displays the generated password.

## 💡 Example
`=== Password Generator ===
Password length (max 32): 12
Include lowercase letters? (y/n): y
Include uppercase letters? (y/n): n
Include digits? (y/n): y
Include special characters? (y/n): n

Generated password: a2b9c8d1e4f3 `

## 🛠️ Build and Run

- 📥 Requires [.NET SDK](https://dotnet.microsoft.com/download) installed.  
- 🛠️ Build the program using: dotnet build
- ▶️ Run the program using: dotnet run


