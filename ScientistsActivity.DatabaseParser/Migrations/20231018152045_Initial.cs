using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScientistsActivity.DatabaseParser.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KeyWords = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DataModels",
                columns: new[] { "Id", "Author", "Category", "Content", "Date", "KeyWords", "Title" },
                values: new object[,]
                {
                    { 1, "John Doe", "Lorem", "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new DateTime(2023, 10, 18, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8620), "Lorem, Ipsum", "Lorem Ipsum" },
                    { 2, "Jane Smith", "Sample", "This is a sample article content.", new DateTime(2023, 10, 17, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8700), "Sample, Article", "Sample Article" },
                    { 3, "Alice Johnson", "Technology", "Exploring the latest technology trends in the industry.", new DateTime(2023, 10, 16, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8720), "Technology, Trends", "Technology Trends" },
                    { 4, "Bob Wilson", "Health", "Tips for maintaining a healthy lifestyle.", new DateTime(2023, 10, 15, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8730), "Health, Wellness", "Health and Wellness" },
                    { 5, "Eva Anderson", "Travel", "Adventures from around the world.", new DateTime(2023, 10, 14, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8730), "Travel, Adventures", "Travel Adventures" },
                    { 6, "David Brown", "Finance", "Insights into financial management.", new DateTime(2023, 10, 13, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8750), "Finance, Insights", "Finance Insights" },
                    { 7, "Grace Miller", "Food", "Delicious recipes and cooking tips.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8750), "Food, Cooking", "Food and Cooking" },
                    { 8, "Frank Taylor", "Science", "Recent scientific discoveries and breakthroughs.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8760), "Science, Discoveries", "Science Discoveries" },
                    { 9, "Helen Martinez", "Art", "Exploring the world of art and creativity.", new DateTime(2023, 10, 10, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8770), "Art, Creativity", "Art and Creativity" },
                    { 10, "George Clark", "Sports", "The latest sports news and updates.", new DateTime(2023, 10, 9, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8780), "Sports, Updates", "Sports Updates" },
                    { 11, "Olivia White", "Fashion", "The latest fashion trends and style tips.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8780), "Fashion, Trends", "Fashion Trends" },
                    { 12, "Samuel Green", "Travel", "Top travel destinations to explore this year.", new DateTime(2023, 10, 7, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8790), "Travel, Destinations", "Travel Destinations" },
                    { 13, "Linda Davis", "Health", "Fitness routines and health tips for a better life.", new DateTime(2023, 10, 6, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8800), "Health, Fitness", "Health and Fitness" },
                    { 14, "Peter Turner", "Technology", "Reviews of the latest technology gadgets in the market.", new DateTime(2023, 10, 5, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8810), "Technology, Gadgets", "Technology Gadgets" },
                    { 15, "Sophia Baker", "Business", "Effective business strategies for growth and success.", new DateTime(2023, 10, 4, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8810), "Business, Strategies", "Business Strategies" },
                    { 16, "Michael Hall", "Entertainment", "Reviews of the latest movies in theaters.", new DateTime(2023, 10, 3, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8820), "Movies, Reviews", "Movie Reviews" },
                    { 17, "Emily Adams", "Home", "Creative ideas for decorating your home.", new DateTime(2023, 10, 2, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8830), "Home, Decor Ideas", "Home Decor Ideas" },
                    { 18, "William Carter", "Environment", "Exploring environmental challenges and solutions.", new DateTime(2023, 10, 1, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8840), "Environment, Issues", "Environmental Issues" },
                    { 19, "Ava Harris", "Travel", "Useful tips for a smooth and enjoyable travel experience.", new DateTime(2023, 9, 30, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8850), "Travel, Tips", "Travel Tips" },
                    { 20, "Daniel Lee", "Food", "Adventures in cooking and trying new recipes.", new DateTime(2023, 9, 29, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8850), "Cooking, Adventures", "Cooking Adventures" },
                    { 21, "Sophie Turner", "Travel", "Personal travel experiences from around the world.", new DateTime(2023, 9, 28, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8860), "Travel, Experiences", "Travel Experiences" },
                    { 22, "William Adams", "Health", "Effective fitness workouts for different fitness levels.", new DateTime(2023, 9, 27, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8870), "Fitness, Workouts", "Fitness Workouts" },
                    { 23, "Oliver Harris", "Technology", "The latest smart home devices and their benefits.", new DateTime(2023, 9, 26, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8870), "Technology, Smart Home", "Smart Home Devices" },
                    { 24, "Ella Turner", "Business", "Tips for aspiring entrepreneurs to kickstart their business.", new DateTime(2023, 9, 25, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8880), "Entrepreneurship, Tips", "Entrepreneurship Tips" },
                    { 25, "Lucas Baker", "Entertainment", "Reviews of the latest music albums and songs.", new DateTime(2023, 9, 24, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8890), "Music, Reviews", "Music Reviews" },
                    { 26, "Grace White", "Home", "Creative DIY projects to improve your home.", new DateTime(2023, 9, 23, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8900), "DIY, Home Projects", "DIY Home Projects" },
                    { 27, "Samuel Hall", "Environment", "Exploring solutions to combat climate change.", new DateTime(2023, 9, 22, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8900), "Environment, Climate Change", "Climate Change Solutions" },
                    { 28, "Eleanor Davis", "Food", "Exploring culinary traditions from around the world.", new DateTime(2023, 9, 21, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8910), "Culinary, Adventures", "Culinary Adventures" },
                    { 29, "James Wilson", "Science", "Latest developments in space exploration and discoveries.", new DateTime(2023, 9, 20, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8920), "Space, Exploration", "Space Exploration" },
                    { 30, "Emma Clark", "Books", "Recommended books to read in various genres.", new DateTime(2023, 9, 19, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8920), "Books, Recommendations", "Book Recommendations" },
                    { 31, "Liam Turner", "Travel", "Adventurous travel experiences for thrill-seekers.", new DateTime(2023, 9, 18, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8930), "Travel, Adventure", "Adventure Travel" },
                    { 32, "Avery Davis", "Health", "Tips for maintaining a healthy diet and lifestyle.", new DateTime(2023, 9, 17, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8940), "Health, Diet", "Healthy Eating Habits" },
                    { 33, "Scarlett Adams", "Technology", "Exploring the latest developments in AI and ML.", new DateTime(2023, 9, 16, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(8940), "AI, Machine Learning", "AI and Machine Learning" },
                    { 34, "Henry Miller", "Business", "Success stories of startups and their journey to success.", new DateTime(2023, 9, 15, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9050), "Startups, Success", "Startup Success Stories" },
                    { 35, "Luna White", "Entertainment", "Recommended movies to watch in different genres.", new DateTime(2023, 9, 14, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9060), "Movies, Recommendations", "Movie Recommendations" },
                    { 36, "Noah Turner", "Home", "Tips and tricks for home improvement projects.", new DateTime(2023, 9, 13, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9070), "Home, Improvement", "Home Improvement Tips" },
                    { 37, "Isabella Clark", "Environment", "Efforts to conserve the environment and protect wildlife.", new DateTime(2023, 9, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9070), "Environment, Conservation", "Conservation Efforts" },
                    { 38, "Mason Brown", "Food", "Adventures in baking and trying new dessert recipes.", new DateTime(2023, 9, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9080), "Baking, Adventures", "Baking Adventures" },
                    { 39, "Zoe Wilson", "Science", "Recent scientific research findings and breakthroughs.", new DateTime(2023, 9, 10, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9090), "Science, Research", "Latest Scientific Research" },
                    { 40, "Benjamin Turner", "Travel", "Capturing beautiful moments through travel photography.", new DateTime(2023, 9, 9, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9100), "Travel, Photography", "Travel Photography" },
                    { 41, "Madison Smith", "Health", "Tips for maintaining good mental health and well-being.", new DateTime(2023, 9, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9110), "Mental Health, Tips", "Mental Health Tips" },
                    { 42, "Leo Davis", "Technology", "Exploring the applications of blockchain technology.", new DateTime(2023, 9, 7, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9110), "Blockchain, Technology", "Blockchain Technology" },
                    { 43, "Victoria Adams", "Business", "Strategies for effective leadership and management.", new DateTime(2023, 9, 6, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9120), "Leadership, Strategies", "Leadership Strategies" },
                    { 44, "Ethan Miller", "Entertainment", "Reviews of music concerts and live performances.", new DateTime(2023, 9, 5, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9130), "Music, Concerts", "Music Concert Reviews" },
                    { 45, "Addison White", "Home", "Tips for gardening and maintaining a beautiful garden.", new DateTime(2023, 9, 4, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9130), "Gardening, Tips", "Gardening Tips" },
                    { 46, "Daniel Adams", "Environment", "Exploring renewable energy solutions and their benefits.", new DateTime(2023, 9, 3, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9140), "Environment, Renewable Energy", "Renewable Energy Solutions" },
                    { 47, "Evelyn Turner", "Food", "Traveling to explore different culinary traditions.", new DateTime(2023, 9, 2, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9150), "Culinary, Travel", "Culinary Travel" },
                    { 48, "Jackson Hall", "Science", "Latest discoveries in astronomy and space exploration.", new DateTime(2023, 9, 1, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9150), "Astronomy, Discoveries", "Astronomy Discoveries" },
                    { 49, "Aria Carter", "Books", "Exploring classic literature and its significance.", new DateTime(2023, 8, 31, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9160), "Books, Literature", "Classic Literature" },
                    { 50, "Logan Brown", "Art", "Exploring artistic creations and their cultural impact.", new DateTime(2023, 8, 30, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9170), "Art, Creations", "Artistic Creations" },
                    { 51, "Dr. William Turner", "Environmental Science", "Protecting marine ecosystems and biodiversity in our oceans.", new DateTime(2023, 10, 9, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9170), "Ocean Conservation, Environment, Biodiversity", "Ocean Conservation" },
                    { 52, "Sophia Adams", "Astronomy", "Exploring the possibilities of human colonization on other planets.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9180), "Space Colonization, Astronomy, Exploration", "Space Colonization" },
                    { 53, "Lucas Parker", "Artificial Intelligence", "Using AI to generate art, music, and creative content.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9190), "AI, Art, Creativity, Artificial Intelligence", "AI in Art and Creativity" },
                    { 54, "Dr. Emily Foster", "Medicine", "Advancing medical knowledge and treatments through research.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9200), "Biomedical Research, Medicine, Health", "Biomedical Research" },
                    { 55, "Daniel Anderson", "Environmental Science", "Ensuring access to clean and safe drinking water for all.", new DateTime(2023, 10, 7, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9200), "Clean Water, Initiatives, Environment", "Clean Water Initiatives" },
                    { 56, "Dr. Olivia Turner", "Computer Science", "Enhancing online security and protecting against cyber threats.", new DateTime(2023, 10, 13, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9210), "Cybersecurity, Research, Computer Science", "Cybersecurity Research" },
                    { 57, "Sophie Carter", "Medicine", "Exploring holistic and alternative approaches to healthcare.", new DateTime(2023, 10, 10, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9220), "Alternative Medicine, Studies, Health", "Alternative Medicine Studies" },
                    { 58, "Dr. Michael Mitchell", "Energy Science", "Building sustainable energy grids to reduce carbon emissions.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9220), "Renewable Energy, Energy Grids", "Renewable Energy Grids" },
                    { 59, "Ethan Turner", "Astronomy", "Forecasting space weather and its effects on Earth and technology.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9230), "Space Weather, Prediction, Astronomy", "Space Weather Prediction" },
                    { 60, "Dr. Isabella Parker", "Biology", "Exploring quantum phenomena in biological systems.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9240), "Quantum Biology, Biology, Quantum Phenomena", "Quantum Biology" },
                    { 61, "Sophia Foster", "Biology", "Using technology to monitor and protect wildlife populations.", new DateTime(2023, 10, 9, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9240), "Wildlife Tracking, Biology, Conservation", "Wildlife Tracking" },
                    { 62, "Dr. William Anderson", "Astronomy", "Exploring the emerging field of space tourism and its possibilities.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9250), "Space Tourism, Astronomy, Exploration", "Space Tourism" },
                    { 63, "Lucas Turner", "Artificial Intelligence", "Advancing AI techniques for understanding and processing human language.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9260), "AI, Natural Language Processing, Artificial Intelligence", "AI in Natural Language Processing" },
                    { 64, "Dr. Emily Lewis", "Psychology", "Investigating mental health disorders and developing effective treatments.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9260), "Mental Health, Research, Psychology", "Mental Health Research" },
                    { 65, "Daniel Foster", "Agriculture", "Promoting eco-friendly and sustainable farming methods.", new DateTime(2023, 10, 7, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9270), "Sustainable Agriculture, Practices", "Sustainable Agriculture Practices" },
                    { 66, "Dr. Olivia Anderson", "Medicine", "Using robots for medical procedures and patient care.", new DateTime(2023, 10, 13, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9280), "Robotics, Healthcare, Medicine", "Robotics in Healthcare" },
                    { 67, "Lucas Carter", "Transportation", "Developing eco-friendly and energy-efficient transportation methods.", new DateTime(2023, 10, 10, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9290), "Renewable Transportation, Green Vehicles", "Renewable Transportation" },
                    { 68, "Dr. Sophia Mitchell", "Technology", "Exploring the applications of blockchain technology beyond cryptocurrency.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9290), "Blockchain Technology, Innovation", "Blockchain Technology" },
                    { 69, "Ethan Foster", "Architecture", "Designing cities with a focus on sustainability and the environment.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9300), "Urban Planning, Sustainability, Architecture", "Urban Planning for Sustainability" },
                    { 70, "Dr. William Parker", "Computer Science", "Working towards creating machines with human-like general intelligence.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9310), "Artificial General Intelligence, Computer Science", "Artificial General Intelligence" },
                    { 71, "Sophia Lewis", "Energy Science", "Developing efficient energy storage solutions for renewable sources.", new DateTime(2023, 10, 9, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9320), "Renewable Energy, Storage, Energy Science", "Renewable Energy Storage" },
                    { 72, "Dr. Michael Turner", "Biology", "Studying the ecological systems of the world's oceans and marine life.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9320), "Marine Ecology, Research, Biology", "Marine Ecology Research" },
                    { 73, "Lucas Anderson", "Automotive", "Advancing AI technology for self-driving and autonomous vehicles.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9330), "AI, Autonomous Vehicles, Automotive", "AI in Autonomous Vehicles" },
                    { 74, "Dr. Isabella Foster", "Astronomy", "Developing strategies to remove debris from Earth's orbit and space.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9340), "Space Debris, Cleanup, Astronomy", "Space Debris Cleanup" },
                    { 75, "Ethan Parker", "Genetics", "Exploring the interaction between genetics and nutrition for health.", new DateTime(2023, 10, 7, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9340), "Nutrigenomics, Genetics, Health", "Nutrigenomics" },
                    { 76, "Dr. Olivia Mitchell", "Urban Planning", "Creating cities that are resilient to environmental and social challenges.", new DateTime(2023, 10, 13, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9350), "Urban Resilience, Planning, Sustainability", "Urban Resilience" },
                    { 77, "Sophie Carter", "Astronomy", "Cultivating crops in space for future long-duration missions.", new DateTime(2023, 10, 10, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9360), "Space Farming, Agriculture, Space Exploration", "Space Farming" },
                    { 78, "Dr. William Anderson", "Energy Science", "Shaping policies to promote the use of renewable energy sources.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9360), "Renewable Energy, Policy, Energy Science", "Renewable Energy Policy" },
                    { 79, "Lucas Turner", "Artificial Intelligence", "Advancing AI for accurate and real-time language translation.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9370), "AI, Language Translation, Artificial Intelligence", "AI in Language Translation" },
                    { 80, "Dr. Emily Foster", "Astronomy", "Researching the challenges and possibilities of colonizing Mars.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9380), "Mars Colonization, Astronomy, Space Exploration", "Mars Colonization" },
                    { 81, "Sophia Lewis", "Energy Science", "Developing efficient energy storage solutions for renewable sources.", new DateTime(2023, 10, 9, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9390), "Renewable Energy, Storage, Energy Science", "Renewable Energy Storage" },
                    { 82, "Dr. Michael Turner", "Biology", "Studying the ecological systems of the world's oceans and marine life.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9390), "Marine Ecology, Research, Biology", "Marine Ecology Research" },
                    { 83, "Lucas Anderson", "Automotive", "Advancing AI technology for self-driving and autonomous vehicles.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9400), "AI, Autonomous Vehicles, Automotive", "AI in Autonomous Vehicles" },
                    { 84, "Dr. Isabella Foster", "Astronomy", "Developing strategies to remove debris from Earth's orbit and space.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9410), "Space Debris, Cleanup, Astronomy", "Space Debris Cleanup" },
                    { 85, "Ethan Parker", "Genetics", "Exploring the interaction between genetics and nutrition for health.", new DateTime(2023, 10, 7, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9420), "Nutrigenomics, Genetics, Health", "Nutrigenomics" },
                    { 86, "Dr. Olivia Mitchell", "Urban Planning", "Creating cities that are resilient to environmental and social challenges.", new DateTime(2023, 10, 13, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9420), "Urban Resilience, Planning, Sustainability", "Urban Resilience" },
                    { 87, "Sophie Carter", "Astronomy", "Cultivating crops in space for future long-duration missions.", new DateTime(2023, 10, 10, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9430), "Space Farming, Agriculture, Space Exploration", "Space Farming" },
                    { 88, "Dr. William Anderson", "Energy Science", "Shaping policies to promote the use of renewable energy sources.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9440), "Renewable Energy, Policy, Energy Science", "Renewable Energy Policy" },
                    { 89, "Lucas Turner", "Artificial Intelligence", "Advancing AI for accurate and real-time language translation.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9440), "AI, Language Translation, Artificial Intelligence", "AI in Language Translation" },
                    { 90, "Dr. Emily Foster", "Astronomy", "Researching the challenges and possibilities of colonizing Mars.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9450), "Mars Colonization, Astronomy, Space Exploration", "Mars Colonization" },
                    { 91, "Sophia Lewis", "Agriculture", "Developing practices for sustainable and eco-friendly agriculture.", new DateTime(2023, 10, 9, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9460), "Agriculture, Sustainability, Environment", "Agricultural Sustainability" },
                    { 92, "Dr. Michael Turner", "Neurology", "Exploring the ethical implications of neuroscience and brain research.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9460), "Neuroethics, Neurology, Ethics", "Neuroethics" },
                    { 93, "Lucas Anderson", "Energy Science", "Inventing new technologies for harnessing renewable energy sources.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9470), "Renewable Energy, Innovations, Energy Science", "Renewable Energy Innovations" },
                    { 94, "Dr. Isabella Foster", "Computer Science", "Developing secure communication systems based on quantum principles.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9470), "Quantum Cryptography, Security, Computer Science", "Quantum Cryptography" },
                    { 95, "Ethan Parker", "Economics", "Studying how psychology and human behavior influence economic decisions.", new DateTime(2023, 10, 7, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9480), "Behavioral Economics, Economics, Psychology", "Behavioral Economics" },
                    { 96, "Dr. Olivia Mitchell", "Medicine", "Using 3D printing for personalized medical devices and organ transplantation.", new DateTime(2023, 10, 13, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9490), "3D Printing, Medicine, Technology", "3D Printing in Medicine" },
                    { 97, "Sophie Carter", "Astronomy", "Developing systems to track and detect space debris to ensure spacecraft safety.", new DateTime(2023, 10, 10, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9500), "Space Debris, Detection, Astronomy", "Space Debris Detection" },
                    { 98, "Dr. William Anderson", "Materials Science", "Creating materials that break down naturally, reducing environmental impact.", new DateTime(2023, 10, 11, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9500), "Biodegradable Materials, Environment, Innovation", "Biodegradable Materials" },
                    { 99, "Lucas Turner", "Medicine", "Using AI to accelerate the discovery of new pharmaceuticals and treatments.", new DateTime(2023, 10, 8, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9510), "AI, Drug Discovery, Medicine", "AI in Drug Discovery" },
                    { 100, "Dr. Emily Foster", "Environmental Science", "Exploring large-scale interventions to mitigate climate change effects.", new DateTime(2023, 10, 12, 18, 20, 45, 636, DateTimeKind.Local).AddTicks(9520), "Geoengineering, Climate Change, Environment", "Geoengineering Solutions" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataModels");
        }
    }
}
