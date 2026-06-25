using DevPortfolio.Models;

namespace DevPortfolio.Data;

/// <summary>
/// This is the only file you need to edit to make this portfolio yours.
/// Update the values below — every page reads from here, so changes
/// show up everywhere automatically. No HTML/Razor editing required.
/// </summary>
public static class PortfolioData
{
    public static class PersonalInfo
    {
        public const string FullName = "Eric Chang Tat Seng";
        public const string Headline = "Computer Science / Information Technology - Student";
        public const string Tagline = "I build web applications using backend APIs and full-stack technologies, focusing on writing clean and maintainable code while continuously learning through projects. I am currently seeking a software engineering internship or graduate opportunity.";
        public const string AvailabilityStatus = " Looking for a job";
        public const string Email = "ssk1013eric2@gmail.com";
        public const string GitHubUrl = "https://github.com/sskeric";
        public const string ResumeUrl = "files/resume.pdf";
        public const string CertificateUrl = "files/certificate.pdf";
        public const string Location = "📍 Alor Setar, Kedah · Open to relocating";

        // Place your photo at wwwroot/images/profile.jpg (or change this path/filename).
        // If the file isn't found, the homepage falls back to a circle with your initials.
        public const string PhotoUrl = "images/profile.jpg";

        public static readonly string[] BioParagraphs =
        {
            "I am a Computer Science student at INTI International University with a strong interest in building scalable and maintainable software systems." +
            "I enjoy writing clean, structured code that follows good software design principles.",

            "This portfolio is built using the .NET ecosystem, including ASP.NET Core, Entity Framework Core, and Blazor for full-stack web development." +
            "I also have experience working with JavaScript, Python, Java, and Android development.",

            "I continuously improve my skills through personal projects and self-learning, with a focus on backend development, system design, and problem-solving." +
            "I am currently seeking an internship opportunity to contribute to real-world systems and grow as a software engineer." 
        };
    }

    public static List<Project> Projects { get; } = new()
    {
        new Project
        {
            Title = "DevPortfolio — Personal Portfolio",
            Description = "My personal developer portfolio built with ASP.NET Core Blazor Server. Features a clean, responsive design showcasing my projects, skills, work experience, and education. Includes interactive UI components like a filterable project gallery, timeline view for experience, skills categorization with language proficiency stars, and contact information. Containerized with Docker and deployed on Render for 24/7 availability.",
            Category = "Web",
            TechStack = new() { "C#", "ASP.NET Core", "Blazor Server", "Docker", "Render", "CSS", "Git" },
            GitHubUrl = "https://github.com/sskeric/DevPortfolio",
            LiveUrl = "https://sskeric-portfolio.onrender.com",
            Featured = true,
            ProjectType = "Personal Project"
        },
        new Project
        {
            Title = "SplitRecord — Expense Tracking & Split System",
            Description = "A full-stack expense management platform that enables groups to track shared expenses, record partial payments, and monitor balances in real time. Implemented secure JWT authentication, role-based access control, and RESTful APIs using Node.js, Express, and MongoDB",
            Category = "Web",
            TechStack = new() { "JavaScript", "Node.js", "Express.js", "MongoDB", "HTML", "CSS", "JWT" },
            GitHubUrl = "https://github.com/sskeric/ExpensesSplitTracker",
            LiveUrl = "",
            Featured = true,
            ProjectType = "Personal Project"
        },
        new Project
        {
            Title = "Smart-Assist AI Support Bot",
            Description = "An AI-powered IT support assistant that provides automated troubleshooting through FAQ matching, issue classification, and incident logging. Built with React, Flask, MySQL, and Google Gemini API to explore AI integration and full-stack application development.",
            Category = "AI",
            TechStack = new() { "Python", "Flask", "React", "MySQL", "Google Gemini API", "JavaScript" },
            GitHubUrl = "https://github.com/sskeric/AI-Assistant-bot",
            LiveUrl = "",
            Featured = true,
            ProjectType = "Personal Project"
        },

        new Project
        {
            Title = "Offline Learning System",
            Description = "Developed an offline learning management system featuring student, course, lecturer, and group management, along with document handling and data export capabilities. Built using PHP and MySQL to demonstrate database-driven web application development and CRUD operations.",
            Category = "Web",
            TechStack = new() { "PHP", "MySQL", "HTML", "CSS", "JavaScript", "XAMPP" },
            GitHubUrl = "https://github.com/sskeric/Offline-Learning-System",
            LiveUrl = "",
            Featured = true,
            ProjectType = "Final Year Project"
        },
        new Project
        {
            Title = "Race Event Management System",
            Description = "Built a Java desktop application that simulates race event management while demonstrating data structures and graph algorithms, including FIFO queues, sorting algorithms, Dijkstra’s shortest path, Floyd-Warshall, and TSP visualization.",
            Category = "Desktop",
            TechStack = new() { "Java", "Java Swing", "Data Structures", "Algorithms", "Dijkstra", "Floyd-Warshall", "Quick Sort" },
            GitHubUrl = "https://github.com/sskeric/Race-Event-Management-System",
            LiveUrl = "",
            Featured = false,
            ProjectType = "Individual Assignment"
        },

        new Project
        {
            Title = "Blood Donation App — Donor Profile & Appointment System",
            Description = "Developed an Android application for donor registration, appointment scheduling, and profile management using Jetpack Compose. Implemented form validation, local data persistence, and reference-code-based record linking with SharedPreferences.",
            Category = "Mobile",
            TechStack = new() { "Kotlin", "Jetpack Compose", "Android", "Material 3", "SharedPreferences" },
            GitHubUrl = "https://github.com/sskeric/Simple_BloodDonationApp",
            LiveUrl = "",
            Featured = false,
            ProjectType = "Individual Assignment"
        },
        new Project
        {
            Title = "Malaysia House Price Prediction",
            Description = "Developed a machine learning model to predict Malaysian house prices using data preprocessing, feature engineering, exploratory data analysis, and regression techniques. Applied the complete machine learning workflow using Python and Scikit-learn.",
            Category = "Machine Learning",
            TechStack = new() { "Python", "Pandas", "NumPy", "Scikit-learn", "Matplotlib", "Seaborn", "Jupyter Notebook" },
            GitHubUrl = "https://github.com/sskeric/Malaysia-House-Price-Prediction",
            LiveUrl = "",
            Featured = true,
            ProjectType = "Group Project"
        },
        new Project
        {
            Title = "2D Animation - City Scene with Car, Drone & Boat",
            Description = "Enhanced and refined a 2D OpenGL city simulation featuring animated vehicles, weather effects, cloud movement, and a dynamic day-night cycle. Applied computer graphics concepts, geometric rendering techniques, and timer-based animation using C++ and OpenGL.",
            Category = "Animation",
            TechStack = new() { "C++", "OpenGL", "GLUT", "Computer Graphics" },
            GitHubUrl = "https://github.com/sskeric/2D-animation-City-Scene-with-Car-Drone-Boat---OpenGL",
            LiveUrl = "",
            Featured = false,
            ProjectType = "Group Project"
        },
    };

    public static List<ExperienceEntry> Experience { get; } = new()
    {
        new ExperienceEntry
        {
            Title = "Computer Technian Intern",
            Organization = "Kedah State Health Department",
            Period = "Aug 2022 – Dec 2022",
            Type = ExperienceType.Work,
            Highlights = new()
            {
                "Troubleshot PC hardware and software issues, including system installation, diagnostics, hardware testing, and data backup/formatting.",
                "Developed and maintained a Laravel-based web application to streamline internal operations and improve process efficiency.",
            }
        },
        new ExperienceEntry
        {
            Title = "Freelancer Computer Technician",
            Organization = "None",
            Period = "Jan 2026 – Present",
            Type = ExperienceType.Work,
            Highlights = new()
            {
                "Delivered PC maintenance services including hardware assembly, system diagnostics, software installation, and system upgrades to support client requirements and system performance."
            }
        },
        new ExperienceEntry
        {
            Title = "Diploma in Information Technology",
            Organization = "Politeknik Sultan Abdul Halim Muadzam Shah",
            Period = "Dec 2019 – Jan 2023",
            Type = ExperienceType.Education,
            Highlights = new()
            {
                "CGPA: 3.74 / 4.0",
                "Status: Graduated"
            }
        },
        new ExperienceEntry
        {
            Title = "Bachelor of Computer Science",
            Organization = "INTI International University",
            Period = "Jan 2024 – Expected Nov/Dec 2026",
            Type = ExperienceType.Education,
            Highlights = new()
            {
                "GPA: 3.48 / 4.0",
                "Status: Ongoing"
            }
        }
    };

    public static List<SkillCategory> SkillCategories { get; } = new()
    {
        new SkillCategory
        {
            Name = "Programming Languages",
            Skills = new() { "C#", "Java", "Python", "JavaScript", "PHP", "C++", "Kotlin" }
        },

        new SkillCategory
        {
            Name = "Frontend Technologies (Markup & Styling)",
            Skills = new() { "HTML", "CSS" }
        },

        new SkillCategory
        {
            Name = "Frameworks & Libraries",
            Skills = new() {
                "Node.js", "Express.js", "React", "Flask",
                "ASP.NET Core", "Blazor Server",
                "Jetpack Compose", "Entity Framework Core"
            }
        },

        new SkillCategory
        {
            Name = "Databases & Query Languages",
            Skills = new() { "MongoDB", "MySQL", "SQL Server", "SQL", "SharedPreferences" }
        },

        new SkillCategory
        {
            Name = "DevOps & Deployment",
            Skills = new() { "Docker", "Render", "Vercel" }
        },

        new SkillCategory
        {
            Name = "Tools & Platforms",
            Skills = new() { "Git / GitHub", "XAMPP", "Jupyter Notebook","Android Studio", "Visual Studio", "VS Code", "Postman"
            }
        },

        new SkillCategory
        {
            Name = "AI / Machine Learning",
            Skills = new() { "Scikit-learn", "Pandas", "NumPy", "Matplotlib", "Seaborn", "Google Gemini API" }
        },

        new SkillCategory
        {
            Name = "Computer Graphics",
            Skills = new() { "OpenGL", "GLUT", "2D Animation", "Timer-based Animation", "Geometric Rendering" }
        },

        new SkillCategory
        {
            Name = "Software Engineering Practices & Concepts",
            Skills = new() {
                "Data Structures & Algorithms", "REST API Design", "CRUD Operations",
                "OOP Design", "MVC Pattern", "Authentication (JWT)", "Form Validation"
            }
        },
        new SkillCategory
        {
            Name = "IT Support & Hardware Maintenance",
            Skills = new()
            {
                "PC hardware troubleshooting and maintenance",
                "PC assembly and disassembly",
                "Software installation and configuration",
            }
        }
    };

    public static List<SoftSkill> SoftSkills { get; } = new()
    {
        new()
        {
            Name = "Problem Solving",
            Description = "Able to identify issues and develop practical solutions efficiently."
        },

        new()
        {
            Name = "Critical Thinking",
            Description = "Able to analyze situations logically before making decisions."
        },

        new()
        {
            Name = "Self-Learning",
            Description = "Quick to learn new technologies independently through practice and resources."
        },

        new()
        {
            Name = "Team Collaboration",
            Description = "Works well with others to complete tasks and achieve project goals."
        },

        new()
        {
            Name = "Effective Communication",
            Description = "Able to clearly explain ideas and technical concepts."
        },

        new()
        {
            Name = "Attention to Detail",
            Description = "Careful in reviewing work to ensure accuracy and quality."
        }
    };
    public static List<LanguageSkill> LanguageSkills { get; } = new()
    {
        new() { Name = "Malay", Proficiency = 3 },
        new() { Name = "English", Proficiency = 3 },
        new() { Name = "Chinese", Proficiency = 5 }
    };
}
