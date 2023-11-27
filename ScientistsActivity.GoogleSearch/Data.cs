using ScientistsActivity.GoogleSearch.Models;

namespace ScientistsActivity.GoogleSearch;

public static class Data
{
    public static DataModel[] Get() => new[]
    {
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Space Weather Forecasting",
            Category = "Astronomy",
            Content = "Predicting space weather events and their impacts on Earth and technology.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Space Weather, Forecasting, Astronomy" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Bioinformatics Research",
            Category = "Genetics",
            Content = "Using computer science and data analysis to advance genetic research.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Bioinformatics", "Research", "Genetics" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "AI in Creative Writing",
            Category = "Artificial Intelligence",
            Content = "Using AI to generate creative content, including literature and poetry.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "AI", "Creative Writing", "Artificial Intelligence" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "Nanotechnology Applications",
            Category = "Materials Science",
            Content = "Applying nanoscale materials for various industrial and medical purposes.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Nanotechnology", "Applications", "Materials Science" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Epidemiology Studies",
            Category = "Medicine",
            Content = "Analyzing patterns and causes of diseases to inform public health strategies.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Epidemiology", "Studies", "Medicine" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Sustainable Transportation",
            Category = "Transportation",
            Content = "Developing sustainable and efficient transportation systems for cities.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Sustainable Transportation", "Urban Planning" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "AI in Environmental Monitoring",
            Category = "Environmental Science",
            Content = "Utilizing AI for real-time monitoring of environmental conditions.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "AI", "Environmental Monitoring", "Technology" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "Space Habitats",
            Category = "Astronomy",
            Content = "Designing habitats for future human colonies in space.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Space Habitats", "Astronomy", "Space Exploration" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Genomic Data Analysis",
            Category = "Genetics",
            Content = "Leveraging big data techniques to analyze genomic information.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Genomic Data Analysis", "Genetics", "Research" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Ocean Exploration",
            Category = "Environmental Science",
            Content = "Investigating the mysteries of the world's oceans and their ecosystems.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Ocean Exploration", "Environment", "Marine Life" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Biodegradable Packaging",
            Category = "Materials Science",
            Content = "Developing eco-friendly packaging materials that reduce waste.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Biodegradable Packaging", "Environment", "Innovation" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Behavioral Genetics",
            Category = "Genetics",
            Content = "Investigating the genetic basis of behavior and personality traits.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Behavioral Genetics", "Genetics", "Behavior" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "AI in Healthcare Diagnostics",
            Category = "Medicine",
            Content = "Utilizing AI for accurate and fast medical diagnostics.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "AI", "Healthcare Diagnostics", "Medicine" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "Renewable Energy Grid Integration",
            Category = "Energy Science",
            Content = "Integrating renewable energy sources into the existing power grid.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Renewable Energy", "Grid Integration", "Energy Science" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Microplastics Research",
            Category = "Environmental Science",
            Content = "Studying the presence and impact of microplastics in the environment.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Microplastics", "Research", "Environment" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "AI-driven Drug Discovery",
            Category = "Medicine",
            Content = "Using AI algorithms to discover new drugs and pharmaceuticals.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "AI", "Drug Discovery", "Medicine" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Mars Habitat Design",
            Category = "Astronomy",
            Content = "Designing habitats for human survival on the surface of Mars.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Mars Habitat", "Astronomy", "Space Exploration" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "Advanced Materials for Space Travel",
            Category = "Materials Science",
            Content = "Developing materials to withstand the challenges of space travel.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Advanced Materials", "Space Travel", "Innovation" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Genomic Editing",
            Category = "Genetics",
            Content = "Editing genes for medical and agricultural applications.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Genomic Editing", "Genetics", "Medicine" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Climate Modeling",
            Category = "Environmental Science",
            Content = "Creating models to predict and understand climate change patterns.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Climate Modeling", "Environment", "Research" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Urban Transportation Planning",
            Category = "Urban Planning",
            Content = "Optimizing transportation systems in urban areas for efficiency and sustainability.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Urban Transportation", "Planning", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "AI in Space Exploration",
            Category = "Astronomy",
            Content = "Utilizing AI for autonomous space exploration missions and data analysis.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Space Exploration", "Astronomy" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Neurorehabilitation Research",
            Category = "Neurology",
            Content = "Developing therapies for neurological disorders and brain injury rehabilitation.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Neurorehabilitation", "Research", "Neurology" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "Green Technology Innovations",
            Category = "Technology",
            Content = "Inventing and promoting green and eco-friendly technology solutions.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Green Technology", "Innovations", "Environment" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Plant Genomics",
            Category = "Botany",
            Content = "Sequencing and analyzing plant genomes to enhance agriculture and biodiversity.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Plant Genomics", "Botany", "Agriculture" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "AI in Robotics",
            Category = "Engineering",
            Content = "Integrating AI into robotic systems for automation and innovation.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "AI", "Robotics", "Engineering" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Renewable Energy Financing",
            Category = "Finance",
            Content = "Finding financial solutions to promote renewable energy projects.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Renewable Energy", "Financing", "Finance" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "Aerospace Materials Research",
            Category = "Aerospace",
            Content = "Developing advanced materials for spacecraft and aircraft.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Aerospace Materials", "Research", "Innovation" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Genetic Counseling",
            Category = "Genetics",
            Content = "Providing guidance and support to individuals regarding their genetic information.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Genetic Counseling", "Genetics", "Healthcare" },
        },
        new DataModel
        {
            Author = "Dr. Victoria Taylor",
            Title = "AI in Climate Monitoring",
            Category = "Climate Science",
            Content = "Using AI to monitor and predict climate changes for environmental conservation.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Climate Monitoring", "Environmental Conservation" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Agricultural Robotics",
            Category = "Agriculture",
            Content = "Using robots for planting, harvesting, and managing crops.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Agricultural Robotics", "Agriculture", "Automation" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "AI in Education",
            Category = "Education",
            Content = "Enhancing learning experiences through AI-driven educational tools.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Education", "Learning" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Oceanic Research",
            Category = "Environmental Science",
            Content = "Studying ocean currents, ecosystems, and their impact on climate.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Oceanic Research", "Environment", "Climate" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "Quantum Computing",
            Category = "Computer Science",
            Content = "Developing quantum computers for complex problem-solving.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Quantum Computing", "Computer Science", "Innovation" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Space Archaeology",
            Category = "Archaeology",
            Content = "Studying historical sites and artifacts in space and on other planets.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Space Archaeology", "Archaeology", "Space Exploration" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "AI Ethics",
            Category = "Artificial Intelligence",
            Content = "Exploring the ethical implications of AI and autonomous systems.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "AI Ethics", "Artificial Intelligence", "Ethics" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Environmental Policy",
            Category = "Environmental Science",
            Content = "Shaping policies for the protection and conservation of the environment.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Environmental Policy", "Environment", "Policy" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "Astronomy Outreach",
            Category = "Astronomy",
            Content = "Educating the public about the wonders of the universe and stargazing.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Astronomy Outreach", "Public Education", "Space Exploration" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Cancer Genomics",
            Category = "Genetics",
            Content = "Analyzing the genetic basis of cancer and developing targeted treatments.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Cancer Genomics", "Genetics", "Medicine" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Wildlife Conservation Technology",
            Category = "Biology",
            Content = "Using technology to protect and conserve endangered species.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Wildlife Conservation", "Technology", "Biology" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Renewable Energy Policy",
            Category = "Energy Science",
            Content = "Creating policies and incentives to promote renewable energy adoption.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Renewable Energy", "Policy", "Energy Science" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "AI in Drug Rehabilitation",
            Category = "Medicine",
            Content = "Using AI to develop personalized rehabilitation programs for addiction treatment.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Drug Rehabilitation", "Medicine" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Sustainable Urban Development",
            Category = "Urban Planning",
            Content = "Designing cities for sustainability, resource efficiency, and quality of life.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Sustainable Urban Development", "Planning", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "Space Medicine",
            Category = "Medicine",
            Content = "Developing medical solutions for space travelers and astronauts.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Space Medicine", "Medicine", "Space Exploration" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Green Chemistry",
            Category = "Chemistry",
            Content = "Creating environmentally friendly and sustainable chemical processes.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Green Chemistry", "Chemistry", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "AI in Law Enforcement",
            Category = "Artificial Intelligence",
            Content = "Implementing AI tools to aid law enforcement agencies in their work.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "AI", "Law Enforcement", "Artificial Intelligence" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Space Law and Ethics",
            Category = "Space Policy",
            Content = "Exploring the legal and ethical dimensions of space exploration and colonization.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Space Law", "Space Ethics", "Policy" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "Renewable Transportation",
            Category = "Transportation",
            Content = "Developing renewable and clean energy solutions for transportation.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Renewable Transportation", "Energy", "Sustainability" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Biology",
            Category = "Biology",
            Content = "Investigating quantum phenomena in biological systems and processes.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Biology", "Biology", "Quantum Physics" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "AI in Wildlife Monitoring",
            Category = "Biology",
            Content = "Using AI for monitoring and protecting wildlife populations and habitats.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Wildlife Monitoring", "Conservation" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Astrobiology",
            Category = "Astronomy",
            Content = "Exploring the potential for life beyond Earth and the origins of life.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Astrobiology", "Astronomy", "Life Beyond Earth" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "AI in Human Resources",
            Category = "Business",
            Content = "Applying AI for human resource management, recruitment, and talent development.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Human Resources", "Business" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Ocean Exploration Technology",
            Category = "Environmental Science",
            Content = "Developing advanced technology for deep-sea and ocean exploration.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Ocean Exploration", "Technology", "Marine Research" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "Quantum Internet",
            Category = "Computer Science",
            Content = "Building secure and fast quantum communication networks.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Quantum Internet", "Quantum Communication", "Cybersecurity" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Space Tourism",
            Category = "Astronomy",
            Content = "Pioneering the development of space tourism and commercial spaceflight.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Space Tourism", "Astronomy", "Commercial Spaceflight" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "AI in Environmental Conservation",
            Category = "Environmental Science",
            Content = "Utilizing AI for conservation efforts and protecting natural habitats.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "AI", "Environmental Conservation", "Technology" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Climate Adaptation Strategies",
            Category = "Environmental Science",
            Content = "Developing strategies to adapt to and mitigate the effects of climate change.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Climate Adaptation", "Environment", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "Marine Pollution Control",
            Category = "Environmental Science",
            Content = "Researching methods to reduce and control pollution in marine ecosystems.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Marine Pollution", "Environmental Research", "Conservation" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Sensors",
            Category = "Physics",
            Content = "Developing highly sensitive sensors based on quantum principles for various applications.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Physics", "Technology" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Space Archaeology",
            Category = "Archaeology",
            Content = "Unearthing the history of human space exploration through archaeological studies.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Space Archaeology", "Archaeology", "Space Exploration" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "AI in Climate Modeling",
            Category = "Environmental Science",
            Content = "Using AI to create accurate climate models and predict climate change impacts.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Climate Modeling", "Environmental Science" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Renewable Energy in Agriculture",
            Category = "Agriculture",
            Content = "Implementing renewable energy solutions in agriculture for sustainable farming.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Renewable Energy", "Agriculture", "Sustainability" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Quantum Cryptocurrency",
            Category = "Finance",
            Content = "Exploring the use of quantum principles in cryptocurrency and blockchain technology.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Cryptocurrency", "Finance", "Blockchain" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Astrophysics",
            Category = "Astronomy",
            Content = "Applying AI for data analysis in astrophysics and space research.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Astrophysics", "Astronomy" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Marine Biodiversity Conservation",
            Category = "Biology",
            Content = "Protecting and preserving marine biodiversity through research and conservation efforts.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Marine Biodiversity", "Conservation", "Marine Biology" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Materials",
            Category = "Materials Science",
            Content = "Developing advanced materials with quantum properties for various applications.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Materials", "Materials Science", "Innovation" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Urban Resilience Planning",
            Category = "Urban Planning",
            Content = "Designing cities to withstand and recover from environmental and social shocks.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Urban Resilience", "Planning", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Cybersecurity",
            Category = "Computer Science",
            Content = "Enhancing cybersecurity with AI-driven threat detection and prevention.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Cybersecurity", "Computer Science" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Renewable Energy in Transportation",
            Category = "Transportation",
            Content = "Adopting renewable energy sources for eco-friendly transportation solutions.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Transportation", "Energy", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Quantum Materials for Electronics",
            Category = "Electronics",
            Content = "Developing electronics using quantum materials for faster and more efficient devices.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Quantum Electronics", "Materials Science", "Technology" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Space Weather Prediction",
            Category = "Astronomy",
            Content = "Forecasting space weather events and their impact on Earth and technology.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Space Weather", "Prediction", "Astronomy" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "AI in Music Composition",
            Category = "Music",
            Content = "Creating music using AI algorithms and machine learning techniques.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Music Composition", "Artificial Intelligence" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Clean Water Technology",
            Category = "Environmental Science",
            Content = "Developing technology to provide clean and safe drinking water globally.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Clean Water", "Technology", "Environmental Research" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "Quantum Sensors for Healthcare",
            Category = "Medicine",
            Content = "Using quantum sensors for medical diagnostics and monitoring health.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Healthcare", "Medicine" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Renewable Energy Education",
            Category = "Education",
            Content = "Educating the public about renewable energy and its benefits.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Renewable Energy", "Education", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "AI in Financial Markets",
            Category = "Finance",
            Content = "Using AI for predictive analysis and investment strategies in financial markets.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "AI", "Financial Markets", "Investment" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Renewable Energy Storage",
            Category = "Energy Science",
            Content = "Developing advanced methods to store energy from renewable sources.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Renewable Energy", "Energy Storage", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "Quantum Computing in Finance",
            Category = "Finance",
            Content = "Applying quantum computing to financial modeling and risk analysis.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Computing", "Finance", "Risk Analysis" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Robotics",
            Category = "Robotics",
            Content = "Utilizing quantum principles for advanced robotics and automation.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Robotics", "Robotics", "Technology" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "AI in Language Translation",
            Category = "Linguistics",
            Content = "Enhancing language translation through AI-powered systems.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Language Translation", "Linguistics" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Renewable Energy for Remote Areas",
            Category = "Energy Science",
            Content = "Providing clean energy solutions for remote and off-grid locations.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Renewable Energy", "Remote Areas", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Quantum Cryptography",
            Category = "Cybersecurity",
            Content = "Ensuring secure communication using quantum cryptographic methods.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Cryptography", "Cybersecurity", "Quantum Technology" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Renewable Energy in Aviation",
            Category = "Aerospace",
            Content = "Developing sustainable energy solutions for the aviation industry.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Aviation", "Aerospace" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Healthcare Policy",
            Category = "Medicine",
            Content = "Using AI for healthcare policy analysis and decision-making.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Healthcare Policy", "Medicine" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Urban Green Spaces",
            Category = "Urban Planning",
            Content = "Designing and preserving green spaces in urban areas for biodiversity and well-being.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Urban Green Spaces", "Planning", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Sensors for Environmental Monitoring",
            Category = "Environmental Science",
            Content = "Using quantum sensors for precise environmental monitoring and data collection.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Environmental Monitoring", "Technology" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Renewable Energy in Desalination",
            Category = "Environmental Science",
            Content = "Employing renewable energy to power desalination processes for clean water production.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Renewable Energy", "Desalination", "Clean Water" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Drug Discovery",
            Category = "Medicine",
            Content = "Accelerating drug discovery processes through AI-based simulations and analysis.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Drug Discovery", "Medicine" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Agriculture",
            Category = "Agriculture",
            Content = "Applying quantum principles to enhance crop yield and agricultural practices.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Agriculture", "Agriculture", "Innovation" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "AI in Art and Creativity",
            Category = "Art",
            Content = "Exploring AI's role in generating art, music, and creative works.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Art and Creativity", "Innovation" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Renewable Energy Grid Resilience",
            Category = "Energy Science",
            Content = "Ensuring the resilience of renewable energy grids against natural disasters and disruptions.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Renewable Energy", "Grid Resilience", "Energy Science" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Quantum Computing in Healthcare",
            Category = "Medicine",
            Content = "Utilizing quantum computing for medical data analysis and drug development.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Computing", "Healthcare", "Medicine" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Marine Energy Harvesting",
            Category = "Environmental Science",
            Content = "Harvesting energy from ocean tides and waves for sustainable power generation.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Marine Energy", "Energy Harvesting", "Environmental Research" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Astronomy Outreach",
            Category = "Astronomy",
            Content = "Using AI to engage the public in astronomy and space science education.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Astronomy Outreach", "Public Education" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Renewable Energy in Mining",
            Category = "Mining",
            Content = "Implementing renewable energy solutions in the mining industry for sustainable operations.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Renewable Energy", "Mining", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Chemistry",
            Category = "Chemistry",
            Content = "Applying quantum principles in the study of molecular interactions and reactions.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Chemistry", "Chemistry", "Quantum Physics" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Space Agriculture",
            Category = "Agriculture",
            Content = "Developing agricultural solutions for future space colonization and exploration.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Space Agriculture", "Agriculture", "Space Exploration" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Mental Health",
            Category = "Psychology",
            Content = "Using AI to assist in mental health assessment, therapy, and support.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Mental Health", "Psychology" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Renewable Energy Microgrids",
            Category = "Energy Science",
            Content = "Implementing renewable energy microgrids for localized power generation and distribution.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Microgrids", "Energy Distribution" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "AI in Legal Research",
            Category = "Law",
            Content = "Enhancing legal research and case analysis with AI-driven tools and algorithms.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Legal Research", "Law" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Quantum Meteorology",
            Category = "Environmental Science",
            Content = "Applying quantum principles in meteorological prediction and climate modeling.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Quantum Meteorology", "Environmental Science", "Climate Modeling" },
        },
    };
}
