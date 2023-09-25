# LexiExtract
![LexiExtract](https://raw.githubusercontent.com/eymenefealtun/LexiExtract/master/RepoResources/LexiExtractMainIcon.png)

[![NuGet](https://img.shields.io/nuget/v/LexiExtract.svg)](https://nuget.org/packages/LexiExtract) [![Nuget](https://img.shields.io/nuget/dt/LexiExtract.svg)](https://nuget.org/packages/LexiExtract)

**LexiExtract** is a .NET library that allows developers to retrieve millions of words for the requested language with just one line of code.

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
                         //returns all the available word in a string array  
 string[] englishWords = LexiExtractor.GetLanguageArray(Languages.languages.English);
                        
                        //get random words from string array
 string[] randomWords = englishWords.GetRandomWords(10);
```
---

### Created By: [@eymenefealtun](https://github.com/eymenefealtun)
* [Linkedin](https://www.linkedin.com/in/eymen-efe-altun-a1681821b)
* [Youtube](https://www.youtube.com/@eymenefealtunn/videos)
* [Fiverr](https://www.fiverr.com/eymenefealtun?public_mode=true)
* [Upwork](https://www.upwork.com/freelancers/~012eff1f3b2a153f38)

---

### How to contribute?
 1. [Fork](https://github.com/eymenefealtun/LexiExtract/fork) the repository.
 2. Make changes.
 3. Submit a pull request.
 
---

### How to support?
* [Buy me a coffee](https://www.buymeacoffee.com/altuneymenefe) 

