using ScientistsActivity.InternationalInformation.Models;

namespace ScientistsActivity.InternationalInformation;

public static class Data
{
    public static DataModel[] Get() => new[]
    {
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Quantum Communication in Healthcare",
            Category = "Medicine",
            Content = "Ensuring secure and efficient communication in healthcare using quantum technology.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Quantum Communication", "Healthcare", "Medicine" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "AI in Social Sciences",
            Category = "Social Sciences",
            Content = "Applying AI for social research, data analysis, and behavior prediction.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Social Sciences", "Research" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Renewable Energy in Space Travel",
            Category = "Space Exploration",
            Content = "Exploring sustainable energy sources for long-duration space missions.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Renewable Energy", "Space Travel", "Sustainability" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Quantum Sensors for Space Exploration",
            Category = "Astronomy",
            Content = "Using quantum sensors for advanced data collection in space exploration.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Space Exploration", "Technology" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Art Conservation",
            Category = "Art History",
            Content = "Preserving and restoring artworks with the assistance of AI and advanced imaging techniques.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Art Conservation", "Art History" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Renewable Energy in Data Centers",
            Category = "Technology",
            Content = "Utilizing renewable energy sources to power data centers and reduce carbon footprint.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Renewable Energy", "Data Centers", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Robotics in Healthcare",
            Category = "Medicine",
            Content = "Implementing quantum robotics for precision surgery and medical procedures.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Robotics", "Healthcare", "Medicine" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Space Archaeology on Mars",
            Category = "Archaeology",
            Content = "Exploring the archaeological remnants of previous Mars missions and colonization attempts.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Space Archaeology", "Mars", "Archaeological Research" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Language Learning",
            Category = "Education",
            Content = "Enhancing language learning through AI-driven language tutors and applications.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Language Learning", "Education" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Computing for Climate Modeling",
            Category = "Environmental Science",
            Content = "Using quantum computing to create highly accurate climate models and predictions.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Computing", "Climate Modeling", "Environmental Science" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Renewable Energy in Space Colonies",
            Category = "Space Exploration",
            Content = "Implementing renewable energy sources for self-sustaining space colonies.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Renewable Energy", "Space Colonies", "Sustainability" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "Quantum Materials in Electronics",
            Category = "Electronics",
            Content = "Incorporating quantum materials in electronic devices for improved performance.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "Quantum Materials", "Electronics", "Technology" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "AI in Space Exploration",
            Category = "Space Exploration",
            Content = "Using AI for autonomous space exploration missions and planetary analysis.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Space Exploration", "Artificial Intelligence" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Renewable Energy in Shipping",
            Category = "Transportation",
            Content = "Implementing renewable energy solutions in the shipping and maritime industry.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Shipping", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "Quantum Sensors for Climate Monitoring",
            Category = "Environmental Science",
            Content = "Using quantum sensors for precise climate and weather monitoring.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Climate Monitoring", "Environmental Research" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "AI in Sports Analytics",
            Category = "Sports",
            Content =
                "Leveraging AI for in-depth sports performance analysis, player assessment, and strategy development.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "AI", "Sports Analytics", "Performance Analysis" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Agriculture for Space Colonies",
            Category = "Agriculture",
            Content = "Developing sustainable agriculture practices for future space colonies.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Agriculture", "Space Colonies", "Sustainable Farming" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Renewable Energy in Disaster Relief",
            Category = "Humanitarian Aid",
            Content = "Using renewable energy sources to provide essential power during disaster relief efforts.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Renewable Energy", "Disaster Relief", "Humanitarian Aid" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Agriculture Robotics",
            Category = "Agriculture",
            Content = "Implementing AI-driven robots for precision agriculture and crop management.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Agriculture Robotics", "Precision Farming" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Materials for Space Exploration",
            Category = "Space Exploration",
            Content = "Developing advanced materials with quantum properties for space missions and equipment.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Materials", "Space Exploration", "Technology" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Renewable Energy in Greenhouse Agriculture",
            Category = "Agriculture",
            Content = "Implementing renewable energy solutions for controlled-environment agriculture in greenhouses.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Renewable Energy", "Greenhouse Agriculture", "Sustainability" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "AI in Weather Forecasting",
            Category = "Meteorology",
            Content = "Enhancing weather forecasting accuracy with AI and machine learning algorithms.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Weather Forecasting", "Meteorology" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Quantum Computing in Aerospace",
            Category = "Aerospace",
            Content = "Exploring quantum computing applications in aerospace engineering and simulations.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Computing", "Aerospace", "Technology" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Renewable Energy for Clean Cooking",
            Category = "Sustainable Living",
            Content = "Promoting clean and sustainable cooking methods with renewable energy sources.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Clean Cooking", "Sustainable Living" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Drug Delivery",
            Category = "Medicine",
            Content = "Utilizing AI for precise drug delivery systems and patient care.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Drug Delivery", "Precision Medicine" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Urban Transport Optimization",
            Category = "Urban Planning",
            Content = "Optimizing urban transportation systems for efficiency and reduced environmental impact.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Transport Optimization", "Urban Planning", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Sensors for Space Exploration",
            Category = "Space Exploration",
            Content = "Utilizing quantum sensors for precise data collection and navigation in space missions.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Space Exploration", "Technology" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Renewable Energy in Disaster Preparedness",
            Category = "Disaster Preparedness",
            Content = "Using renewable energy sources for disaster preparedness and resilience.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Renewable Energy", "Disaster Preparedness", "Resilience" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Natural Language Processing",
            Category = "Language Technology",
            Content = "Advancing natural language processing using AI for improved communication and translation.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Natural Language Processing", "Language Technology" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Computing for Quantum Chemistry",
            Category = "Chemistry",
            Content = "Leveraging quantum computing for precise quantum chemical simulations and research.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Computing", "Quantum Chemistry", "Chemistry" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Renewable Energy in Aquaculture",
            Category = "Aquaculture",
            Content = "Implementing renewable energy solutions in aquaculture for sustainable fish farming.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Renewable Energy", "Aquaculture", "Sustainable Farming" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "AI in Environmental Monitoring",
            Category = "Environmental Science",
            Content = "Using AI for continuous environmental monitoring, pollution detection, and conservation.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Environmental Monitoring", "Conservation" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Quantum Materials for Medicine",
            Category = "Medicine",
            Content = "Developing quantum materials for advanced medical devices and treatments.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Materials", "Medicine", "Medical Devices" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Renewable Energy in Seismic Monitoring",
            Category = "Geology",
            Content = "Utilizing renewable energy for sustainable seismic monitoring and earthquake prediction.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Seismic Monitoring", "Geology" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Accessibility Technology",
            Category = "Technology",
            Content = "Creating inclusive and accessible technology solutions using AI for people with disabilities.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Accessibility Technology", "Inclusion" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Urban Renewable Energy Transition",
            Category = "Urban Planning",
            Content = "Transitioning urban areas to renewable energy sources for sustainability and reduced emissions.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Renewable Energy", "Urban Transition", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Robotics for Disaster Response",
            Category = "Robotics",
            Content = "Deploying quantum-powered robots for disaster response and recovery missions.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Robotics", "Disaster Response", "Robotics" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Space Environmental Monitoring",
            Category = "Astronomy",
            Content = "Monitoring space environments and space debris for the safety of space missions.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Space Environmental Monitoring", "Space Missions", "Safety" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Financial Inclusion",
            Category = "Finance",
            Content = "Promoting financial inclusion using AI-driven banking and financial services.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Financial Inclusion", "Banking" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Renewable Energy for Data Security",
            Category = "Cybersecurity",
            Content = "Securing sensitive data using renewable energy-powered data centers and encryption methods.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Data Security", "Cybersecurity" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Quantum Communication for Financial Transactions",
            Category = "Finance",
            Content = "Ensuring secure and efficient financial transactions using quantum communication methods.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Quantum Communication", "Financial Transactions", "Finance" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "AI in Renewable Energy Management",
            Category = "Energy Science",
            Content = "Optimizing the management and distribution of renewable energy resources using AI.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Renewable Energy", "Energy Management" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Quantum Materials for Space Travel",
            Category = "Space Exploration",
            Content = "Developing advanced quantum materials for spacecraft construction and space travel.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Materials", "Space Travel", "Aerospace" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Renewable Energy in Electric Aviation",
            Category = "Aerospace",
            Content = "Implementing renewable energy sources for electric aircraft and sustainable aviation.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Electric Aviation", "Aerospace" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Marine Conservation",
            Category = "Environmental Science",
            Content = "Using AI for marine conservation efforts, including species monitoring and habitat protection.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Marine Conservation", "Environmental Protection" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Urban Noise Pollution Reduction",
            Category = "Urban Planning",
            Content = "Implementing strategies to reduce urban noise pollution for improved quality of life.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Urban Noise Pollution", "Urban Planning", "Noise Reduction" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Computing in Aerospace Materials",
            Category = "Aerospace",
            Content = "Utilizing quantum computing for the development of advanced aerospace materials.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Computing", "Aerospace Materials", "Technology" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Renewable Energy in Ocean Exploration",
            Category = "Marine Science",
            Content = "Powering ocean exploration vessels and equipment with renewable energy sources.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Renewable Energy", "Ocean Exploration", "Marine Science" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Space Colonization",
            Category = "Space Exploration",
            Content = "Using AI for resource management and decision-making in future space colonies.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Space Colonization", "Resource Management" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Sensors for Medical Imaging",
            Category = "Medicine",
            Content = "Using quantum sensors for highly precise medical imaging and diagnostics.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Medical Imaging", "Diagnostics" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Renewable Energy for Electric Vehicles",
            Category = "Transportation",
            Content = "Charging electric vehicles with renewable energy sources for eco-friendly transportation.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Renewable Energy", "Electric Vehicles", "Transportation" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "AI in Astrophysics",
            Category = "Astrophysics",
            Content = "Utilizing AI for analyzing astronomical data and exploring the cosmos.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Astrophysics", "Space Exploration" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Quantum Computing for Climate Adaptation",
            Category = "Climate Science",
            Content = "Using quantum computing to model climate changes and adaptation strategies.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Computing", "Climate Adaptation", "Environmental Science" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Renewable Energy for Desalination",
            Category = "Water Technology",
            Content = "Powering desalination plants with renewable energy for freshwater production.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Desalination", "Water Purification" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Biomedical Research",
            Category = "Biomedicine",
            Content = "Leveraging AI for biomedical research, drug discovery, and disease modeling.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Biomedical Research", "Drug Discovery" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Urban Air Quality Monitoring",
            Category = "Environmental Science",
            Content = "Monitoring and improving urban air quality using advanced sensor technology.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Air Quality Monitoring", "Urban Environment" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Sensors in Agriculture",
            Category = "Agriculture",
            Content = "Using quantum sensors for precision agriculture and soil analysis.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Agriculture", "Precision Farming" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Renewable Energy in Space Tourism",
            Category = "Space Tourism",
            Content = "Implementing renewable energy sources for sustainable space tourism experiences.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Renewable Energy", "Space Tourism", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Traffic Management",
            Category = "Transportation",
            Content = "Optimizing traffic flow and congestion reduction using AI-based traffic management systems.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Traffic Management", "Urban Mobility" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Materials for Quantum Computing",
            Category = "Quantum Technology",
            Content = "Developing specialized quantum materials for quantum computing applications.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Materials", "Quantum Computing", "Technology" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Renewable Energy in Agriculture Irrigation",
            Category = "Agriculture",
            Content = "Utilizing renewable energy sources for efficient agricultural irrigation systems.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Renewable Energy", "Agriculture Irrigation", "Sustainability" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "AI in Materials Science",
            Category = "Materials Science",
            Content = "Applying AI for materials discovery, characterization, and property prediction.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Materials Science", "Research" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Quantum Sensors in Geophysics",
            Category = "Geophysics",
            Content = "Using quantum sensors for precise geophysical measurements and earth exploration.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Geophysics", "Earth Science" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Renewable Energy for Telecommunications",
            Category = "Telecommunications",
            Content =
                "Powering telecommunications infrastructure with renewable energy for connectivity in remote areas.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Telecommunications", "Connectivity" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Music Composition",
            Category = "Music",
            Content = "Creating music compositions and melodies with the assistance of AI algorithms.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Music Composition", "Creative Arts" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Urban Waste Management",
            Category = "Environmental Science",
            Content = "Developing smart waste management solutions for cleaner and more sustainable cities.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Waste Management", "Urban Environment", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Robotics for Space Mining",
            Category = "Space Mining",
            Content = "Using quantum-powered robots for asteroid mining and resource extraction in space.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Robotics", "Space Mining", "Resource Extraction" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Space Traffic Management",
            Category = "Space Exploration",
            Content = "Developing systems to manage increasing space traffic and satellite coordination.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Space Traffic Management", "Space Missions", "Orbital Coordination" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Neurology",
            Category = "Neurology",
            Content = "Applying AI for the diagnosis and treatment of neurological disorders.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Neurology", "Medical Diagnosis" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Materials for Energy Conversion",
            Category = "Energy Science",
            Content = "Developing quantum materials for efficient energy conversion and storage solutions.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Materials", "Energy Conversion", "Sustainable Energy" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Renewable Energy in Seawater Desalination",
            Category = "Water Technology",
            Content = "Harnessing renewable energy to desalinate seawater and address freshwater scarcity.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Renewable Energy", "Seawater Desalination", "Water Purification" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "AI in Astrophotography",
            Category = "Astrophotography",
            Content = "Enhancing astrophotography with AI algorithms for stunning images of the night sky.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Astrophotography", "Photography" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Quantum Computing in Drug Discovery",
            Category = "Medicine",
            Content = "Utilizing quantum computing for accelerated drug discovery and pharmaceutical research.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Computing", "Drug Discovery", "Pharmaceutical Research" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Renewable Energy in Urban Agriculture",
            Category = "Urban Agriculture",
            Content = "Powering urban agriculture projects with renewable energy for sustainable food production.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Urban Agriculture", "Sustainable Farming" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Wildlife Conservation",
            Category = "Wildlife Conservation",
            Content = "Using AI for tracking and protecting endangered wildlife species and ecosystems.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Wildlife Conservation", "Biodiversity" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Sustainable Urban Transportation",
            Category = "Urban Planning",
            Content = "Promoting sustainable and eco-friendly urban transportation solutions.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Sustainable Transportation", "Urban Mobility", "Environmental Impact" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Sensors for Climate Modeling",
            Category = "Climate Science",
            Content = "Enhancing climate models and predictions using quantum sensors and data analysis.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Climate Modeling", "Environmental Science" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Space Debris Removal with AI",
            Category = "Space Cleanup",
            Content = "Using AI-powered technology for the removal of space debris and ensuring orbital safety.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "AI", "Space Debris Removal", "Space Cleanup" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "Quantum Materials for Renewable Energy Storage",
            Category = "Energy Science",
            Content = "Developing advanced quantum materials for efficient renewable energy storage systems.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Materials", "Renewable Energy Storage", "Sustainability" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "AI in Sports Analytics",
            Category = "Sports",
            Content = "Enhancing sports performance analysis and player training with AI-driven analytics.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "AI", "Sports Analytics", "Performance Enhancement" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Renewable Energy for Disaster Relief",
            Category = "Disaster Relief",
            Content = "Providing renewable energy solutions for disaster-stricken areas to aid relief efforts.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Renewable Energy", "Disaster Relief", "Humanitarian Aid" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "AI in Environmental Remediation",
            Category = "Environmental Science",
            Content = "Utilizing AI for cleaning up environmental pollutants and contaminated sites.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Environmental Remediation", "Pollution Cleanup" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Quantum Computing in Cryptography",
            Category = "Cryptography",
            Content = "Advancing cryptographic techniques using quantum computing for enhanced security.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Computing", "Cryptography", "Security" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Renewable Energy for Mobile Health Clinics",
            Category = "Healthcare",
            Content = "Powering mobile health clinics with renewable energy for healthcare access in remote areas.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Healthcare", "Mobile Clinics" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Archaeology",
            Category = "Archaeology",
            Content = "Using AI for archaeological site analysis, artifact recognition, and historical research.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Archaeology", "Historical Research" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Urban Green Infrastructure Planning",
            Category = "Urban Planning",
            Content = "Designing green infrastructure systems to enhance urban resilience and sustainability.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Green Infrastructure", "Urban Planning", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Sensors in Marine Exploration",
            Category = "Marine Science",
            Content =
                "Utilizing quantum sensors for deep-sea exploration, biodiversity assessment, and underwater mapping.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Marine Exploration", "Underwater Mapping" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Renewable Energy for Space Habitats",
            Category = "Space Exploration",
            Content = "Implementing renewable energy solutions for sustainable living in space habitats.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Renewable Energy", "Space Habitats", "Sustainability" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Legal Compliance",
            Category = "Law",
            Content = "Using AI to ensure legal compliance and ethical practices in businesses and organizations.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Legal Compliance", "Ethics" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Materials for Quantum Sensors",
            Category = "Quantum Technology",
            Content =
                "Developing advanced quantum materials to enhance the sensitivity and precision of quantum sensors.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Materials", "Quantum Sensors", "Technology" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Renewable Energy in Arctic Research",
            Category = "Climate Science",
            Content = "Implementing renewable energy sources for sustainable Arctic research and climate studies.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Renewable Energy", "Arctic Research", "Climate Studies" },
        },
        new DataModel
        {
            Author = "Sophia Lewis",
            Title = "AI in Financial Forecasting",
            Category = "Finance",
            Content = "Using AI to predict financial market trends and make informed investment decisions.",
            Date = DateTime.Now.AddDays(-9),
            KeyWordsArray = new List<string> { "AI", "Financial Forecasting", "Investment" },
        },
        new DataModel
        {
            Author = "Dr. Michael Turner",
            Title = "Quantum Computing for Climate Modeling",
            Category = "Climate Science",
            Content = "Leveraging quantum computing for detailed climate modeling and predictions.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "Quantum Computing", "Climate Modeling", "Environmental Science" },
        },
        new DataModel
        {
            Author = "Lucas Anderson",
            Title = "Renewable Energy in Smart Cities",
            Category = "Urban Planning",
            Content = "Integrating renewable energy sources into smart city infrastructure for sustainability.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Renewable Energy", "Smart Cities", "Sustainable Infrastructure" },
        },
        new DataModel
        {
            Author = "Dr. Isabella Foster",
            Title = "AI in Language Translation",
            Category = "Linguistics",
            Content = "Utilizing AI to improve language translation accuracy and efficiency.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "AI", "Language Translation", "Linguistic Technology" },
        },
        new DataModel
        {
            Author = "Ethan Parker",
            Title = "Urban Green Spaces Design",
            Category = "Urban Planning",
            Content =
                "Designing urban green spaces to enhance quality of life and promote environmental sustainability.",
            Date = DateTime.Now.AddDays(-11),
            KeyWordsArray = new List<string> { "Urban Green Spaces", "Urban Planning", "Quality of Life" },
        },
        new DataModel
        {
            Author = "Dr. Olivia Mitchell",
            Title = "Quantum Sensors for Planetary Exploration",
            Category = "Space Exploration",
            Content = "Applying quantum sensors to planetary exploration for detailed data collection and analysis.",
            Date = DateTime.Now.AddDays(-5),
            KeyWordsArray = new List<string> { "Quantum Sensors", "Planetary Exploration", "Data Analysis" },
        },
        new DataModel
        {
            Author = "Sophie Carter",
            Title = "Renewable Energy in Underwater Archaeology",
            Category = "Archaeology",
            Content = "Powering underwater archaeological expeditions with renewable energy sources.",
            Date = DateTime.Now.AddDays(-8),
            KeyWordsArray = new List<string> { "Renewable Energy", "Underwater Archaeology", "Marine Exploration" },
        },
        new DataModel
        {
            Author = "Dr. William Anderson",
            Title = "AI in Education Technology",
            Category = "Education",
            Content =
                "Integrating AI into educational technology for personalized learning experiences and assessment.",
            Date = DateTime.Now.AddDays(-7),
            KeyWordsArray = new List<string> { "AI", "Education Technology", "Personalized Learning" },
        },
        new DataModel
        {
            Author = "Lucas Turner",
            Title = "Quantum Materials in Medical Imaging",
            Category = "Medicine",
            Content = "Developing quantum materials for improved medical imaging and diagnostics.",
            Date = DateTime.Now.AddDays(-10),
            KeyWordsArray = new List<string> { "Quantum Materials", "Medical Imaging", "Diagnostics" },
        },
        new DataModel
        {
            Author = "Dr. Emily Foster",
            Title = "Renewable Energy for Sustainable Tourism",
            Category = "Tourism",
            Content = "Promoting sustainable tourism with renewable energy solutions and eco-friendly practices.",
            Date = DateTime.Now.AddDays(-6),
            KeyWordsArray = new List<string> { "Renewable Energy", "Sustainable Tourism", "Eco-Friendly Travel" },
        },
    };
}
