# Eric Chang Tat Seng - Portfolio

A personal portfolio website built with C# and ASP.NET Core Blazor Server.

## 🌐 Live Demo

Visit: [https://sskeric-portfolio.onrender.com]

> ⚠️ Hosted on Render's free tier — the site may take 30-60 seconds to load on the first visit if it's been idle, as the server spins back up.

## 📋 Table of Contents

- [About](#-about)
- [Features](#-features)
- [Tech Stack](#️-tech-stack)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)
- [Deployment](#-deployment)
- [Personalize It](#-personalize-it)
- [License](#-license)
- [Contact](#-contact)
- [Acknowledgments](#-acknowledgments)

## 📖 About

This is my personal portfolio website showcasing my skills, projects, work experience, and education as a Computer Science student at INTI International University. It serves as a central hub for potential employers and recruiters to learn more about me and my work.

## ✨ Features

- **Home Page** — Introduction, quick stats, and navigation cards
- **About Page** — Background, education, career goals & interests
- **Skills Page** — Technical skills, soft skills, and language proficiencies with star ratings
- **Projects Page** — Filterable project gallery with tech badges
- **Experience Page** — Timeline view of work experience and education
- **Contact Page** — Email and WhatsApp contact details with references

## 🛠️ Tech Stack

| Category | Technologies |
|---|---|
| Framework | ASP.NET Core 8.0 / 9.0 |
| UI | Blazor Server |
| Styling | CSS with custom design tokens |
| Version Control | Git & GitHub |
| Deployment | Render (Docker) |
| Fonts | Space Grotesk, Inter, IBM Plex Mono |

## 📁 Project Structure

```text
DevPortfolio/
├── Components/
│   └── (Reusable UI components)
├── Models/
│   ├── ExperienceEntry.cs
│   ├── Project.cs
│   ├── LanguageSkill.cs
│   └── SoftSkill.cs
├── Pages/
│   ├── Index.razor          # Homepage
│   ├── About.razor          # About page
│   ├── Skills.razor         # Skills page
│   ├── Projects.razor       # Projects page
│   ├── Experience.razor     # Experience page
│   └── Contact.razor        # Contact page
├── Data/
│   └── PortfolioData.cs     # All portfolio content
├── wwwroot/
│   ├── css/                 # Stylesheets
│   └── images/              # Images and assets
├── appsettings.json         # Configuration
├── Program.cs               # Application entry point
├── Dockerfile                # Docker configuration
└── README.md
```

## 🚀 Getting Started

### Prerequisites

- .NET SDK 8.0 or 9.0
- Visual Studio 2022 or VS Code
- Git

### Run Locally

1. **Clone the repository**

   ```bash
   git clone https://github.com/yourusername/DevPortfolio.git
   cd DevPortfolio
   ```

2. **Restore dependencies**

   ```bash
   dotnet restore
   ```

3. **Run the application**

   ```bash
   dotnet run
   ```

4. **Open your browser**

   ```text
   https://localhost:5001
   ```

## 🌍 Deployment

This project is deployed on [Render](https://render.com) using Docker. The Dockerfile handles the build and deployment process.

### Dockerfile

```dockerfile
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "DevPortfolio.dll"]
```

### Deploy to Render

1. Push your code to GitHub
2. Create a **Web Service** on Render
3. Connect your repository
4. Set **Language** to `Docker`
5. Set **Dockerfile Path** to `./Dockerfile`
6. Click **Deploy**

### Keep It Awake (Optional / Free)

To prevent Render's free tier from spinning down after 15 minutes of inactivity, ping your site periodically with one of these free services:

| Service | Ping Interval |
|---|---|
| [UptimeRobot](https://uptimerobot.com) | Every 5 minutes |

## 📝 Personalize It

### Update Portfolio Data

Edit `Data/PortfolioData.cs` to customize:

- Personal info (name, headline, tagline, etc.)
- Projects
- Experience entries
- Skill categories
- Language skills
- Soft skills

### Add Your Photo

1. Place your photo in `wwwroot/images/profile.jpg`
2. Update `PhotoUrl` in `PortfolioData.cs`:

   ```csharp
   PhotoUrl = "/images/profile.jpg"
   ```

## 📄 License

This project is for personal portfolio use. All rights reserved.

## 📬 Contact

| Method | Details |
|---|---|
| Email | ssk1013eric2@gmail.com |
| WhatsApp | +6012-579-0910 |

## 🙏 Acknowledgments

- Built with [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet)
- Deployed on [Render](https://render.com)
- Fonts from [Google Fonts](https://fonts.google.com)
- Icons from Emoji
