using Microsoft.EntityFrameworkCore;
using ScientistsActivity.DatabaseParser.Models;

namespace ScientistsActivity.DatabaseParser;

public class DatabaseDbContext : DbContext
{
    public DbSet<DataModel> DataModels { get; set; } = default!;

    public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<DataModel>()
            .HasData(new List<DataModel>
            {
                new()
                {
                    Id = 1,
                    Author = "John Doe",
                    Title = "Lorem Ipsum",
                    Category = "Lorem",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Date = DateTime.Now,
                    KeyWords = "Lorem, Ipsum"
                },
                new()
                {
                    Id = 2,
                    Author = "Jane Smith",
                    Title = "Sample Article",
                    Category = "Sample",
                    Content = "This is a sample article content.",
                    Date = DateTime.Now.AddDays(-1),
                    KeyWords = "Sample, Article"
                },
                new()
                {
                    Id = 3,
                    Author = "Alice Johnson",
                    Title = "Technology Trends",
                    Category = "Technology",
                    Content = "Exploring the latest technology trends in the industry.",
                    Date = DateTime.Now.AddDays(-2),
                    KeyWords = "Technology, Trends"
                },
                new()
                {
                    Id = 4,
                    Author = "Bob Wilson",
                    Title = "Health and Wellness",
                    Category = "Health",
                    Content = "Tips for maintaining a healthy lifestyle.",
                    Date = DateTime.Now.AddDays(-3),
                    KeyWords = "Health, Wellness"
                },
                new()
                {
                    Id = 5,
                    Author = "Eva Anderson",
                    Title = "Travel Adventures",
                    Category = "Travel",
                    Content = "Adventures from around the world.",
                    Date = DateTime.Now.AddDays(-4),
                    KeyWords = "Travel, Adventures"
                },
                new()
                {
                    Id = 6,
                    Author = "David Brown",
                    Title = "Finance Insights",
                    Category = "Finance",
                    Content = "Insights into financial management.",
                    Date = DateTime.Now.AddDays(-5),
                    KeyWords = "Finance, Insights"
                },
                new()
                {
                    Id = 7,
                    Author = "Grace Miller",
                    Title = "Food and Cooking",
                    Category = "Food",
                    Content = "Delicious recipes and cooking tips.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Food, Cooking"
                },
                new()
                {
                    Id = 8,
                    Author = "Frank Taylor",
                    Title = "Science Discoveries",
                    Category = "Science",
                    Content = "Recent scientific discoveries and breakthroughs.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Science, Discoveries"
                },
                new()
                {
                    Id = 9,
                    Author = "Helen Martinez",
                    Title = "Art and Creativity",
                    Category = "Art",
                    Content = "Exploring the world of art and creativity.",
                    Date = DateTime.Now.AddDays(-8),
                    KeyWords = "Art, Creativity"
                },
                new()
                {
                    Id = 10,
                    Author = "George Clark",
                    Title = "Sports Updates",
                    Category = "Sports",
                    Content = "The latest sports news and updates.",
                    Date = DateTime.Now.AddDays(-9),
                    KeyWords = "Sports, Updates"
                },
                new()
                {
                    Id = 11,
                    Author = "Olivia White",
                    Title = "Fashion Trends",
                    Category = "Fashion",
                    Content = "The latest fashion trends and style tips.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "Fashion, Trends"
                },
                new()
                {
                    Id = 12,
                    Author = "Samuel Green",
                    Title = "Travel Destinations",
                    Category = "Travel",
                    Content = "Top travel destinations to explore this year.",
                    Date = DateTime.Now.AddDays(-11),
                    KeyWords = "Travel, Destinations"
                },
                new()
                {
                    Id = 13,
                    Author = "Linda Davis",
                    Title = "Health and Fitness",
                    Category = "Health",
                    Content = "Fitness routines and health tips for a better life.",
                    Date = DateTime.Now.AddDays(-12),
                    KeyWords = "Health, Fitness"
                },
                new()
                {
                    Id = 14,
                    Author = "Peter Turner",
                    Title = "Technology Gadgets",
                    Category = "Technology",
                    Content = "Reviews of the latest technology gadgets in the market.",
                    Date = DateTime.Now.AddDays(-13),
                    KeyWords = "Technology, Gadgets"
                },
                new()
                {
                    Id = 15,
                    Author = "Sophia Baker",
                    Title = "Business Strategies",
                    Category = "Business",
                    Content = "Effective business strategies for growth and success.",
                    Date = DateTime.Now.AddDays(-14),
                    KeyWords = "Business, Strategies"
                },
                new()
                {
                    Id = 16,
                    Author = "Michael Hall",
                    Title = "Movie Reviews",
                    Category = "Entertainment",
                    Content = "Reviews of the latest movies in theaters.",
                    Date = DateTime.Now.AddDays(-15),
                    KeyWords = "Movies, Reviews"
                },
                new()
                {
                    Id = 17,
                    Author = "Emily Adams",
                    Title = "Home Decor Ideas",
                    Category = "Home",
                    Content = "Creative ideas for decorating your home.",
                    Date = DateTime.Now.AddDays(-16),
                    KeyWords = "Home, Decor Ideas"
                },
                new()
                {
                    Id = 18,
                    Author = "William Carter",
                    Title = "Environmental Issues",
                    Category = "Environment",
                    Content = "Exploring environmental challenges and solutions.",
                    Date = DateTime.Now.AddDays(-17),
                    KeyWords = "Environment, Issues"
                },
                new()
                {
                    Id = 19,
                    Author = "Ava Harris",
                    Title = "Travel Tips",
                    Category = "Travel",
                    Content = "Useful tips for a smooth and enjoyable travel experience.",
                    Date = DateTime.Now.AddDays(-18),
                    KeyWords = "Travel, Tips"
                },
                new()
                {
                    Id = 20,
                    Author = "Daniel Lee",
                    Title = "Cooking Adventures",
                    Category = "Food",
                    Content = "Adventures in cooking and trying new recipes.",
                    Date = DateTime.Now.AddDays(-19),
                    KeyWords = "Cooking, Adventures"
                },
                new()
                {
                    Id = 21,
                    Author = "Sophie Turner",
                    Title = "Travel Experiences",
                    Category = "Travel",
                    Content = "Personal travel experiences from around the world.",
                    Date = DateTime.Now.AddDays(-20),
                    KeyWords = "Travel, Experiences"
                },
                new()
                {
                    Id = 22,
                    Author = "William Adams",
                    Title = "Fitness Workouts",
                    Category = "Health",
                    Content = "Effective fitness workouts for different fitness levels.",
                    Date = DateTime.Now.AddDays(-21),
                    KeyWords = "Fitness, Workouts"
                },
                new()
                {
                    Id = 23,
                    Author = "Oliver Harris",
                    Title = "Smart Home Devices",
                    Category = "Technology",
                    Content = "The latest smart home devices and their benefits.",
                    Date = DateTime.Now.AddDays(-22),
                    KeyWords = "Technology, Smart Home"
                },
                new()
                {
                    Id = 24,
                    Author = "Ella Turner",
                    Title = "Entrepreneurship Tips",
                    Category = "Business",
                    Content = "Tips for aspiring entrepreneurs to kickstart their business.",
                    Date = DateTime.Now.AddDays(-23),
                    KeyWords = "Entrepreneurship, Tips"
                },
                new()
                {
                    Id = 25,
                    Author = "Lucas Baker",
                    Title = "Music Reviews",
                    Category = "Entertainment",
                    Content = "Reviews of the latest music albums and songs.",
                    Date = DateTime.Now.AddDays(-24),
                    KeyWords = "Music, Reviews"
                },
                new()
                {
                    Id = 26,
                    Author = "Grace White",
                    Title = "DIY Home Projects",
                    Category = "Home",
                    Content = "Creative DIY projects to improve your home.",
                    Date = DateTime.Now.AddDays(-25),
                    KeyWords = "DIY, Home Projects"
                },
                new()
                {
                    Id = 27,
                    Author = "Samuel Hall",
                    Title = "Climate Change Solutions",
                    Category = "Environment",
                    Content = "Exploring solutions to combat climate change.",
                    Date = DateTime.Now.AddDays(-26),
                    KeyWords = "Environment, Climate Change"
                },
                new()
                {
                    Id = 28,
                    Author = "Eleanor Davis",
                    Title = "Culinary Adventures",
                    Category = "Food",
                    Content = "Exploring culinary traditions from around the world.",
                    Date = DateTime.Now.AddDays(-27),
                    KeyWords = "Culinary, Adventures"
                },
                new()
                {
                    Id = 29,
                    Author = "James Wilson",
                    Title = "Space Exploration",
                    Category = "Science",
                    Content = "Latest developments in space exploration and discoveries.",
                    Date = DateTime.Now.AddDays(-28),
                    KeyWords = "Space, Exploration"
                },
                new()
                {
                    Id = 30,
                    Author = "Emma Clark",
                    Title = "Book Recommendations",
                    Category = "Books",
                    Content = "Recommended books to read in various genres.",
                    Date = DateTime.Now.AddDays(-29),
                    KeyWords = "Books, Recommendations"
                },
                new()
                {
                    Id = 31,
                    Author = "Liam Turner",
                    Title = "Adventure Travel",
                    Category = "Travel",
                    Content = "Adventurous travel experiences for thrill-seekers.",
                    Date = DateTime.Now.AddDays(-30),
                    KeyWords = "Travel, Adventure"
                },
                new()
                {
                    Id = 32,
                    Author = "Avery Davis",
                    Title = "Healthy Eating Habits",
                    Category = "Health",
                    Content = "Tips for maintaining a healthy diet and lifestyle.",
                    Date = DateTime.Now.AddDays(-31),
                    KeyWords = "Health, Diet"
                },
                new()
                {
                    Id = 33,
                    Author = "Scarlett Adams",
                    Title = "AI and Machine Learning",
                    Category = "Technology",
                    Content = "Exploring the latest developments in AI and ML.",
                    Date = DateTime.Now.AddDays(-32),
                    KeyWords = "AI, Machine Learning"
                },
                new()
                {
                    Id = 34,
                    Author = "Henry Miller",
                    Title = "Startup Success Stories",
                    Category = "Business",
                    Content = "Success stories of startups and their journey to success.",
                    Date = DateTime.Now.AddDays(-33),
                    KeyWords = "Startups, Success"
                },
                new()
                {
                    Id = 35,
                    Author = "Luna White",
                    Title = "Movie Recommendations",
                    Category = "Entertainment",
                    Content = "Recommended movies to watch in different genres.",
                    Date = DateTime.Now.AddDays(-34),
                    KeyWords = "Movies, Recommendations"
                },
                new()
                {
                    Id = 36,
                    Author = "Noah Turner",
                    Title = "Home Improvement Tips",
                    Category = "Home",
                    Content = "Tips and tricks for home improvement projects.",
                    Date = DateTime.Now.AddDays(-35),
                    KeyWords = "Home, Improvement"
                },
                new()
                {
                    Id = 37,
                    Author = "Isabella Clark",
                    Title = "Conservation Efforts",
                    Category = "Environment",
                    Content = "Efforts to conserve the environment and protect wildlife.",
                    Date = DateTime.Now.AddDays(-36),
                    KeyWords = "Environment, Conservation"
                },
                new()
                {
                    Id = 38,
                    Author = "Mason Brown",
                    Title = "Baking Adventures",
                    Category = "Food",
                    Content = "Adventures in baking and trying new dessert recipes.",
                    Date = DateTime.Now.AddDays(-37),
                    KeyWords = "Baking, Adventures"
                },
                new()
                {
                    Id = 39,
                    Author = "Zoe Wilson",
                    Title = "Latest Scientific Research",
                    Category = "Science",
                    Content = "Recent scientific research findings and breakthroughs.",
                    Date = DateTime.Now.AddDays(-38),
                    KeyWords = "Science, Research"
                },
                new()
                {
                    Id = 40,
                    Author = "Benjamin Turner",
                    Title = "Travel Photography",
                    Category = "Travel",
                    Content = "Capturing beautiful moments through travel photography.",
                    Date = DateTime.Now.AddDays(-39),
                    KeyWords = "Travel, Photography"
                },
                new()
                {
                    Id = 41,
                    Author = "Madison Smith",
                    Title = "Mental Health Tips",
                    Category = "Health",
                    Content = "Tips for maintaining good mental health and well-being.",
                    Date = DateTime.Now.AddDays(-40),
                    KeyWords = "Mental Health, Tips"
                },
                new()
                {
                    Id = 42,
                    Author = "Leo Davis",
                    Title = "Blockchain Technology",
                    Category = "Technology",
                    Content = "Exploring the applications of blockchain technology.",
                    Date = DateTime.Now.AddDays(-41),
                    KeyWords = "Blockchain, Technology"
                },
                new()
                {
                    Id = 43,
                    Author = "Victoria Adams",
                    Title = "Leadership Strategies",
                    Category = "Business",
                    Content = "Strategies for effective leadership and management.",
                    Date = DateTime.Now.AddDays(-42),
                    KeyWords = "Leadership, Strategies"
                },
                new()
                {
                    Id = 44,
                    Author = "Ethan Miller",
                    Title = "Music Concert Reviews",
                    Category = "Entertainment",
                    Content = "Reviews of music concerts and live performances.",
                    Date = DateTime.Now.AddDays(-43),
                    KeyWords = "Music, Concerts"
                },
                new()
                {
                    Id = 45,
                    Author = "Addison White",
                    Title = "Gardening Tips",
                    Category = "Home",
                    Content = "Tips for gardening and maintaining a beautiful garden.",
                    Date = DateTime.Now.AddDays(-44),
                    KeyWords = "Gardening, Tips"
                },
                new()
                {
                    Id = 46,
                    Author = "Daniel Adams",
                    Title = "Renewable Energy Solutions",
                    Category = "Environment",
                    Content = "Exploring renewable energy solutions and their benefits.",
                    Date = DateTime.Now.AddDays(-45),
                    KeyWords = "Environment, Renewable Energy"
                },
                new()
                {
                    Id = 47,
                    Author = "Evelyn Turner",
                    Title = "Culinary Travel",
                    Category = "Food",
                    Content = "Traveling to explore different culinary traditions.",
                    Date = DateTime.Now.AddDays(-46),
                    KeyWords = "Culinary, Travel"
                },
                new()
                {
                    Id = 48,
                    Author = "Jackson Hall",
                    Title = "Astronomy Discoveries",
                    Category = "Science",
                    Content = "Latest discoveries in astronomy and space exploration.",
                    Date = DateTime.Now.AddDays(-47),
                    KeyWords = "Astronomy, Discoveries"
                },
                new()
                {
                    Id = 49,
                    Author = "Aria Carter",
                    Title = "Classic Literature",
                    Category = "Books",
                    Content = "Exploring classic literature and its significance.",
                    Date = DateTime.Now.AddDays(-48),
                    KeyWords = "Books, Literature"
                },
                new()
                {
                    Id = 50,
                    Author = "Logan Brown",
                    Title = "Artistic Creations",
                    Category = "Art",
                    Content = "Exploring artistic creations and their cultural impact.",
                    Date = DateTime.Now.AddDays(-49),
                    KeyWords = "Art, Creations"
                },
                new()
                {
                    Id = 51,
                    Author = "Dr. William Turner",
                    Title = "Ocean Conservation",
                    Category = "Environmental Science",
                    Content = "Protecting marine ecosystems and biodiversity in our oceans.",
                    Date = DateTime.Now.AddDays(-9),
                    KeyWords = "Ocean Conservation, Environment, Biodiversity"
                },
                new()
                {
                    Id = 52,
                    Author = "Sophia Adams",
                    Title = "Space Colonization",
                    Category = "Astronomy",
                    Content = "Exploring the possibilities of human colonization on other planets.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Space Colonization, Astronomy, Exploration"
                },

                new()
                {
                    Id = 53,
                    Author = "Lucas Parker",
                    Title = "AI in Art and Creativity",
                    Category = "Artificial Intelligence",
                    Content = "Using AI to generate art, music, and creative content.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "AI, Art, Creativity, Artificial Intelligence"
                },

                new()
                {
                    Id = 54,
                    Author = "Dr. Emily Foster",
                    Title = "Biomedical Research",
                    Category = "Medicine",
                    Content = "Advancing medical knowledge and treatments through research.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Biomedical Research, Medicine, Health"
                },

                new()
                {
                    Id = 55,
                    Author = "Daniel Anderson",
                    Title = "Clean Water Initiatives",
                    Category = "Environmental Science",
                    Content = "Ensuring access to clean and safe drinking water for all.",
                    Date = DateTime.Now.AddDays(-11),
                    KeyWords = "Clean Water, Initiatives, Environment"
                },

                new()
                {
                    Id = 56,
                    Author = "Dr. Olivia Turner",
                    Title = "Cybersecurity Research",
                    Category = "Computer Science",
                    Content = "Enhancing online security and protecting against cyber threats.",
                    Date = DateTime.Now.AddDays(-5),
                    KeyWords = "Cybersecurity, Research, Computer Science"
                },

                new()
                {
                    Id = 57,
                    Author = "Sophie Carter",
                    Title = "Alternative Medicine Studies",
                    Category = "Medicine",
                    Content = "Exploring holistic and alternative approaches to healthcare.",
                    Date = DateTime.Now.AddDays(-8),
                    KeyWords = "Alternative Medicine, Studies, Health"
                },

                new()
                {
                    Id = 58,
                    Author = "Dr. Michael Mitchell",
                    Title = "Renewable Energy Grids",
                    Category = "Energy Science",
                    Content = "Building sustainable energy grids to reduce carbon emissions.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Renewable Energy, Energy Grids"
                },

                new()
                {
                    Id = 59,
                    Author = "Ethan Turner",
                    Title = "Space Weather Prediction",
                    Category = "Astronomy",
                    Content = "Forecasting space weather and its effects on Earth and technology.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "Space Weather, Prediction, Astronomy"
                },

                new()
                {
                    Id = 60,
                    Author = "Dr. Isabella Parker",
                    Title = "Quantum Biology",
                    Category = "Biology",
                    Content = "Exploring quantum phenomena in biological systems.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Quantum Biology, Biology, Quantum Phenomena"
                },
                new()
                {
                    Id = 61,
                    Author = "Sophia Foster",
                    Title = "Wildlife Tracking",
                    Category = "Biology",
                    Content = "Using technology to monitor and protect wildlife populations.",
                    Date = DateTime.Now.AddDays(-9),
                    KeyWords = "Wildlife Tracking, Biology, Conservation"
                },

                new()
                {
                    Id = 62,
                    Author = "Dr. William Anderson",
                    Title = "Space Tourism",
                    Category = "Astronomy",
                    Content = "Exploring the emerging field of space tourism and its possibilities.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Space Tourism, Astronomy, Exploration"
                },

                new()
                {
                    Id = 63,
                    Author = "Lucas Turner",
                    Title = "AI in Natural Language Processing",
                    Category = "Artificial Intelligence",
                    Content = "Advancing AI techniques for understanding and processing human language.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "AI, Natural Language Processing, Artificial Intelligence"
                },

                new()
                {
                    Id = 64,
                    Author = "Dr. Emily Lewis",
                    Title = "Mental Health Research",
                    Category = "Psychology",
                    Content = "Investigating mental health disorders and developing effective treatments.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Mental Health, Research, Psychology"
                },

                new()
                {
                    Id = 65,
                    Author = "Daniel Foster",
                    Title = "Sustainable Agriculture Practices",
                    Category = "Agriculture",
                    Content = "Promoting eco-friendly and sustainable farming methods.",
                    Date = DateTime.Now.AddDays(-11),
                    KeyWords = "Sustainable Agriculture, Practices"
                },

                new()
                {
                    Id = 66,
                    Author = "Dr. Olivia Anderson",
                    Title = "Robotics in Healthcare",
                    Category = "Medicine",
                    Content = "Using robots for medical procedures and patient care.",
                    Date = DateTime.Now.AddDays(-5),
                    KeyWords = "Robotics, Healthcare, Medicine"
                },

                new()
                {
                    Id = 67,
                    Author = "Lucas Carter",
                    Title = "Renewable Transportation",
                    Category = "Transportation",
                    Content = "Developing eco-friendly and energy-efficient transportation methods.",
                    Date = DateTime.Now.AddDays(-8),
                    KeyWords = "Renewable Transportation, Green Vehicles"
                },

                new()
                {
                    Id = 68,
                    Author = "Dr. Sophia Mitchell",
                    Title = "Blockchain Technology",
                    Category = "Technology",
                    Content = "Exploring the applications of blockchain technology beyond cryptocurrency.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Blockchain Technology, Innovation"
                },

                new()
                {
                    Id = 69,
                    Author = "Ethan Foster",
                    Title = "Urban Planning for Sustainability",
                    Category = "Architecture",
                    Content = "Designing cities with a focus on sustainability and the environment.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "Urban Planning, Sustainability, Architecture"
                },

                new()
                {
                    Id = 70,
                    Author = "Dr. William Parker",
                    Title = "Artificial General Intelligence",
                    Category = "Computer Science",
                    Content = "Working towards creating machines with human-like general intelligence.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Artificial General Intelligence, Computer Science"
                },
                new()
                {
                    Id = 71,
                    Author = "Sophia Lewis",
                    Title = "Renewable Energy Storage",
                    Category = "Energy Science",
                    Content = "Developing efficient energy storage solutions for renewable sources.",
                    Date = DateTime.Now.AddDays(-9),
                    KeyWords = "Renewable Energy, Storage, Energy Science"
                },

                new()
                {
                    Id = 72,
                    Author = "Dr. Michael Turner",
                    Title = "Marine Ecology Research",
                    Category = "Biology",
                    Content = "Studying the ecological systems of the world's oceans and marine life.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Marine Ecology, Research, Biology"
                },

                new()
                {
                    Id = 73,
                    Author = "Lucas Anderson",
                    Title = "AI in Autonomous Vehicles",
                    Category = "Automotive",
                    Content = "Advancing AI technology for self-driving and autonomous vehicles.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "AI, Autonomous Vehicles, Automotive"
                },

                new()
                {
                    Id = 74,
                    Author = "Dr. Isabella Foster",
                    Title = "Space Debris Cleanup",
                    Category = "Astronomy",
                    Content = "Developing strategies to remove debris from Earth's orbit and space.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Space Debris, Cleanup, Astronomy"
                },

                new()
                {
                    Id = 75,
                    Author = "Ethan Parker",
                    Title = "Nutrigenomics",
                    Category = "Genetics",
                    Content = "Exploring the interaction between genetics and nutrition for health.",
                    Date = DateTime.Now.AddDays(-11),
                    KeyWords = "Nutrigenomics, Genetics, Health"
                },

                new()
                {
                    Id = 76,
                    Author = "Dr. Olivia Mitchell",
                    Title = "Urban Resilience",
                    Category = "Urban Planning",
                    Content = "Creating cities that are resilient to environmental and social challenges.",
                    Date = DateTime.Now.AddDays(-5),
                    KeyWords = "Urban Resilience, Planning, Sustainability"
                },

                new()
                {
                    Id = 77,
                    Author = "Sophie Carter",
                    Title = "Space Farming",
                    Category = "Astronomy",
                    Content = "Cultivating crops in space for future long-duration missions.",
                    Date = DateTime.Now.AddDays(-8),
                    KeyWords = "Space Farming, Agriculture, Space Exploration"
                },

                new()
                {
                    Id = 78,
                    Author = "Dr. William Anderson",
                    Title = "Renewable Energy Policy",
                    Category = "Energy Science",
                    Content = "Shaping policies to promote the use of renewable energy sources.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Renewable Energy, Policy, Energy Science"
                },

                new()
                {
                    Id = 79,
                    Author = "Lucas Turner",
                    Title = "AI in Language Translation",
                    Category = "Artificial Intelligence",
                    Content = "Advancing AI for accurate and real-time language translation.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "AI, Language Translation, Artificial Intelligence"
                },

                new()
                {
                    Id = 80,
                    Author = "Dr. Emily Foster",
                    Title = "Mars Colonization",
                    Category = "Astronomy",
                    Content = "Researching the challenges and possibilities of colonizing Mars.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Mars Colonization, Astronomy, Space Exploration"
                },
                new()
                {
                    Id = 81,
                    Author = "Sophia Lewis",
                    Title = "Renewable Energy Storage",
                    Category = "Energy Science",
                    Content = "Developing efficient energy storage solutions for renewable sources.",
                    Date = DateTime.Now.AddDays(-9),
                    KeyWords = "Renewable Energy, Storage, Energy Science"
                },

                new()
                {
                    Id = 82,
                    Author = "Dr. Michael Turner",
                    Title = "Marine Ecology Research",
                    Category = "Biology",
                    Content = "Studying the ecological systems of the world's oceans and marine life.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Marine Ecology, Research, Biology"
                },

                new()
                {
                    Id = 83,
                    Author = "Lucas Anderson",
                    Title = "AI in Autonomous Vehicles",
                    Category = "Automotive",
                    Content = "Advancing AI technology for self-driving and autonomous vehicles.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "AI, Autonomous Vehicles, Automotive"
                },

                new()
                {
                    Id = 84,
                    Author = "Dr. Isabella Foster",
                    Title = "Space Debris Cleanup",
                    Category = "Astronomy",
                    Content = "Developing strategies to remove debris from Earth's orbit and space.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Space Debris, Cleanup, Astronomy"
                },

                new()
                {
                    Id = 85,
                    Author = "Ethan Parker",
                    Title = "Nutrigenomics",
                    Category = "Genetics",
                    Content = "Exploring the interaction between genetics and nutrition for health.",
                    Date = DateTime.Now.AddDays(-11),
                    KeyWords = "Nutrigenomics, Genetics, Health"
                },

                new()
                {
                    Id = 86,
                    Author = "Dr. Olivia Mitchell",
                    Title = "Urban Resilience",
                    Category = "Urban Planning",
                    Content = "Creating cities that are resilient to environmental and social challenges.",
                    Date = DateTime.Now.AddDays(-5),
                    KeyWords = "Urban Resilience, Planning, Sustainability"
                },

                new()
                {
                    Id = 87,
                    Author = "Sophie Carter",
                    Title = "Space Farming",
                    Category = "Astronomy",
                    Content = "Cultivating crops in space for future long-duration missions.",
                    Date = DateTime.Now.AddDays(-8),
                    KeyWords = "Space Farming, Agriculture, Space Exploration"
                },

                new()
                {
                    Id = 88,
                    Author = "Dr. William Anderson",
                    Title = "Renewable Energy Policy",
                    Category = "Energy Science",
                    Content = "Shaping policies to promote the use of renewable energy sources.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Renewable Energy, Policy, Energy Science"
                },

                new()
                {
                    Id = 89,
                    Author = "Lucas Turner",
                    Title = "AI in Language Translation",
                    Category = "Artificial Intelligence",
                    Content = "Advancing AI for accurate and real-time language translation.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "AI, Language Translation, Artificial Intelligence"
                },

                new()
                {
                    Id = 90,
                    Author = "Dr. Emily Foster",
                    Title = "Mars Colonization",
                    Category = "Astronomy",
                    Content = "Researching the challenges and possibilities of colonizing Mars.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Mars Colonization, Astronomy, Space Exploration"
                },
                new()
                {
                    Id = 91,
                    Author = "Sophia Lewis",
                    Title = "Agricultural Sustainability",
                    Category = "Agriculture",
                    Content = "Developing practices for sustainable and eco-friendly agriculture.",
                    Date = DateTime.Now.AddDays(-9),
                    KeyWords = "Agriculture, Sustainability, Environment"
                },

                new()
                {
                    Id = 92,
                    Author = "Dr. Michael Turner",
                    Title = "Neuroethics",
                    Category = "Neurology",
                    Content = "Exploring the ethical implications of neuroscience and brain research.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Neuroethics, Neurology, Ethics"
                },

                new()
                {
                    Id = 93,
                    Author = "Lucas Anderson",
                    Title = "Renewable Energy Innovations",
                    Category = "Energy Science",
                    Content = "Inventing new technologies for harnessing renewable energy sources.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "Renewable Energy, Innovations, Energy Science"
                },

                new()
                {
                    Id = 94,
                    Author = "Dr. Isabella Foster",
                    Title = "Quantum Cryptography",
                    Category = "Computer Science",
                    Content = "Developing secure communication systems based on quantum principles.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Quantum Cryptography, Security, Computer Science"
                },

                new()
                {
                    Id = 95,
                    Author = "Ethan Parker",
                    Title = "Behavioral Economics",
                    Category = "Economics",
                    Content = "Studying how psychology and human behavior influence economic decisions.",
                    Date = DateTime.Now.AddDays(-11),
                    KeyWords = "Behavioral Economics, Economics, Psychology"
                },

                new()
                {
                    Id = 96,
                    Author = "Dr. Olivia Mitchell",
                    Title = "3D Printing in Medicine",
                    Category = "Medicine",
                    Content = "Using 3D printing for personalized medical devices and organ transplantation.",
                    Date = DateTime.Now.AddDays(-5),
                    KeyWords = "3D Printing, Medicine, Technology"
                },

                new()
                {
                    Id = 97,
                    Author = "Sophie Carter",
                    Title = "Space Debris Detection",
                    Category = "Astronomy",
                    Content = "Developing systems to track and detect space debris to ensure spacecraft safety.",
                    Date = DateTime.Now.AddDays(-8),
                    KeyWords = "Space Debris, Detection, Astronomy"
                },

                new()
                {
                    Id = 98,
                    Author = "Dr. William Anderson",
                    Title = "Biodegradable Materials",
                    Category = "Materials Science",
                    Content = "Creating materials that break down naturally, reducing environmental impact.",
                    Date = DateTime.Now.AddDays(-7),
                    KeyWords = "Biodegradable Materials, Environment, Innovation"
                },

                new()
                {
                    Id = 99,
                    Author = "Lucas Turner",
                    Title = "AI in Drug Discovery",
                    Category = "Medicine",
                    Content = "Using AI to accelerate the discovery of new pharmaceuticals and treatments.",
                    Date = DateTime.Now.AddDays(-10),
                    KeyWords = "AI, Drug Discovery, Medicine"
                },

                new()
                {
                    Id = 100,
                    Author = "Dr. Emily Foster",
                    Title = "Geoengineering Solutions",
                    Category = "Environmental Science",
                    Content = "Exploring large-scale interventions to mitigate climate change effects.",
                    Date = DateTime.Now.AddDays(-6),
                    KeyWords = "Geoengineering, Climate Change, Environment"
                }
            });
    }
}
