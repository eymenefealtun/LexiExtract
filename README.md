# LexiExtract
<p align="center">
  <img src="https://github.com/eymenefealtun/LexiExtract/blob/master/RepoResources/LexiExtractMainIcon.png?raw=true" alt="Sublime's custom image"/>
</p>

<p align="center">
         <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/commit-activity/t/eymenefealtun/LexiExtract?style=plastic" /></a>
        <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/nuget/v/LexiExtract.svg?style=plastic" /></a>
          <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/nuget/dt/LexiExtract.svg?style=plastic" /></a>
        <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/languages/code-size/eymenefealtun/LexiExtract?style=plastic" /></a>
                <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/stars/eymenefealtun/LexiExtract?style=plastic" /></a>
                <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/watchers/eymenefealtun/LexiExtract?style=plastic" /></a>
                <a href="#backers" alt="Backers on Open Collective">
        <img src="https://img.shields.io/github/forks/eymenefealtun/LexiExtract?style=plastic" /></a>
</p>

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
 string[] randomWords = words.GetRandomWords(10);
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

