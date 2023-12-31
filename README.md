# LexiExtract
![LexiExtract](https://raw.githubusercontent.com/eymenefealtun/LexiExtract/master/RepoResources/LexiExtractMainIcon.png)

[![NuGet](https://img.shields.io/nuget/v/LexiExtract.svg)](https://nuget.org/packages/LexiExtract) [![Nuget](https://img.shields.io/nuget/dt/LexiExtract.svg)](https://nuget.org/packages/LexiExtract)

**LexiExtract** is a .NET library that allows developers to retrieve millions of words for the requested language with just one line of code.
All the data is stored in [all-words-in-all-languages](https://github.com/eymenefealtun/all-words-in-all-languages) repository.

### Important Note:
Via this library, you are going to be sending a GET request to the [all-words-in-all-languages](https://github.com/eymenefealtun/all-words-in-all-languages).

---

### How to use?

LexiExtract can be installed using the Nuget package manager or the `dotnet` CLI.

```
dotnet add package LexiExtract 
```

---

### Example
```csharp
using LexiExtract;


string[] englishWords = new LexiExtract.Languages.English().GetAllWords();
string[] englishWordsAsync = await new LexiExtract.Languages.English().GetAllWordsAsync();

string randomWord = englishWords.GetRandomWord();
string[] randomWords = englishWords.GetRandomWords(10);

```
---

### Available languages
[All words in all languages](https://github.com/eymenefealtun/all-words-in-all-languages) 

---

### How to contribute?
 1. [Fork](https://github.com/eymenefealtun/LexiExtract/fork) the repository.
 2. Make changes.
 3. Submit a pull request.
 
---

### How to support?
* [Buy me a coffee](https://www.buymeacoffee.com/altuneymenefe) 

