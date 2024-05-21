﻿using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ArchitectureArchiveBE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    YearBuilt = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsRegistered = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    StyleId = table.Column<int>(type: "integer", nullable: false),
                    ImageURL = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingId);
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    StyleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.StyleId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildingTag",
                columns: table => new
                {
                    BuildingsBuildingId = table.Column<int>(type: "integer", nullable: false),
                    TagsTagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingTag", x => new { x.BuildingsBuildingId, x.TagsTagId });
                    table.ForeignKey(
                        name: "FK_BuildingTag_Buildings_BuildingsBuildingId",
                        column: x => x.BuildingsBuildingId,
                        principalTable: "Buildings",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuildingTag_Tags_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "BuildingId", "Description", "ImageURL", "IsRegistered", "Location", "Name", "StyleId", "UserId", "YearBuilt" },
                values: new object[,]
                {
                    { 1, "The Eiffel Tower is a wrought iron lattice tower on the Champ de Mars in Paris, France. It was named after the engineer Gustave Eiffel, whose company designed and built the tower. Initially criticized by some of France's leading artists and intellectuals for its design, the tower has become a global cultural icon of France and one of the most recognizable structures in the world. The Eiffel Tower is 324 meters tall and was the tallest man-made structure in the world until the Chrysler Building in New York City was completed in 1930. It has three levels for visitors, with restaurants on the first and second levels. The tower was initially intended as a temporary exhibit but was kept after its popularity soared. It has undergone several renovations, including the addition of elevators in 1983 and the installation of a new lighting system in 1985.", "https://cdn-imgix.headout.com/media/images/c90f7eb7a5825e6f5e57a5a62d05399c-25058-BestofParis-EiffelTower-Cruise-Louvre-002.jpg", true, "Paris, France", "Eiffel Tower", 5, 1, "1889" },
                    { 2, "The Statue of Liberty is a colossal neoclassical sculpture on Liberty Island in New York Harbor. Designed by French sculptor Frédéric Auguste Bartholdi and built by Gustave Eiffel, the statue was a gift from the people of France to the United States. The statue is an icon of freedom and a welcoming signal to immigrants arriving from abroad. It stands 93 meters tall from ground to torch. Over the years, the statue has undergone several renovations. The most significant renovation took place in 1984-1986 for its centennial celebration, which included the replacement of the torch and the restoration of the internal structure. The Statue of Liberty was designated a National Monument in 1924 and a UNESCO World Heritage Site in 1984.", "https://eadn-wc03-11391632.nxedge.io/wp-content/uploads/2019/02/statue-of-liberty.jpg", true, "New York City, USA", "Statue of Liberty", 3, 2, "1886" },
                    { 3, "The Colosseum, also known as the Flavian Amphitheatre, is an ancient amphitheatre in the center of Rome, Italy. It is the largest ancient amphitheatre ever built, and remains the largest standing amphitheatre in the world today. Construction began under Emperor Vespasian in 72 AD and was completed in 80 AD under his successor, Titus. The Colosseum could hold an estimated 50,000 to 80,000 spectators and was used for gladiatorial contests and public spectacles such as mock sea battles, animal hunts, executions, re-enactments of famous battles, and dramas based on Classical mythology. The Colosseum has undergone several renovations throughout its history, including significant repairs after the damage caused by earthquakes in 847 and 1231. In the 1990s, a major renovation project was undertaken to address structural concerns and preserve the monument for future generations.", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/Colosseo_2020.jpg/1200px-Colosseo_2020.jpg", true, "Rome, Italy", "Colosseum", 9, 1, "70-80 AD" },
                    { 4, "The Great Wall of China is a series of fortifications made of various materials, generally built along an east-to-west line across the historical northern borders of China to protect Chinese states and empires against the raids and invasions of various nomadic groups. Several walls were built as early as the 7th century BC, with major expansions occurring during the Ming Dynasty (1368–1644). The wall spans approximately 13,171 miles, making it the longest structure ever built by humans. The wall has faced significant deterioration over the centuries due to natural erosion and human activity, leading to multiple restoration projects aimed at preserving its structure and historical significance. Notable sections like Badaling and Mutianyu have been extensively restored and are popular tourist destinations.", "https://th-thumbnailer.cdn-si-edu.com/Jxn_9H-e_JpGocZHVGy4Ytc-9Y4=/fit-in/1600x0/https%3A%2F%2Ftf-cmsv2-smithsonianmag-media.s3.amazonaws.com%2Ffiler%2F80%2Ffa%2F80facab4-fe0e-4a56-bd99-a71eb1845fa0%2F01_14_2014_great_wall.jpg", true, "China", "Great Wall of China", 11, 2, "7th century BC" },
                    { 5, "The Taj Mahal is an ivory-white marble mausoleum on the southern bank of the river Yamuna in the Indian city of Agra. It was commissioned in 1632 by the Mughal emperor Shah Jahan to house the tomb of his favorite wife, Mumtaz Mahal. The tomb is the centrepiece of a 17-hectare complex, which includes a mosque and a guest house, and is set in formal gardens bounded on three sides by a crenellated wall. The construction project employed some 20,000 artisans under the guidance of a board of architects led by Ustad Ahmad Lahauri. The Taj Mahal was designated as a UNESCO World Heritage Site in 1983 for being 'the jewel of Muslim art in India and one of the universally admired masterpieces of the world's heritage.' The structure underwent major restoration in the early 20th century during the British colonial period to address deterioration issues and has continued to be maintained and preserved as a significant cultural site.", "https://discovery.sndimg.com/content/dam/images/discovery/fullset/2020/2/21/thumbnail.png.rend.hgtvcom.1280.720.suffix/1582329440048.png", true, "Agra, India", "Taj Mahal", 12, 1, "1632" },
                    { 6, "The Sydney Opera House is a multi-venue performing arts center at Sydney Harbour in Sydney, Australia. Designed by Danish architect Jørn Utzon, the building was formally opened on 20 October 1973. It is one of the most famous and distinctive buildings in the world. The Sydney Opera House comprises multiple performance venues which together host well over 1,500 performances annually, attended by more than 1.2 million people. Major renovations have included updating the acoustics and modernizing the performance spaces to accommodate contemporary shows. In 2007, the Opera House was designated as a UNESCO World Heritage Site, recognizing its architectural significance and cultural importance.", "https://ychef.files.bbci.co.uk/1280x720/p0gp95cq.jpg", true, "Sydney, Australia", "Sydney Opera House", 6, 2, "1973" },
                    { 7, "Machu Picchu is a 15th-century Inca citadel located in the Eastern Cordillera of southern Peru on a mountain ridge 2,430 meters above sea level. It is located in the Machupicchu District within Urubamba Province above the Sacred Valley, which is 80 kilometers northwest of Cusco. Most archaeologists believe that Machu Picchu was constructed as an estate for the Inca emperor Pachacuti (1438–1472). The site was largely unknown to the outside world until it was brought to international attention by the American historian Hiram Bingham in 1911. Machu Picchu was declared a Peruvian Historic Sanctuary in 1981 and a UNESCO World Heritage Site in 1983. Extensive renovations and preservation efforts have been undertaken to maintain the site, including structural stabilization and restoration of key architectural features.", "https://www.anywhere.com/img-a/peru/destinations/aguas-calientes/tours/film-and-productions-services/machupicchu-sunrise%20mid.jpg?q=75&type=jpeg&w=480", true, "Cusco Region, Peru", "Machu Picchu", 13, 1, "1450" },
                    { 8, "The Palace of Versailles is a former royal residence located in Versailles, about 19 kilometers west of Paris, France. It was originally a hunting lodge built in 1623 by Louis XIII and later expanded into a grand palace by Louis XIV. Versailles is famous for its opulent architecture, elaborate gardens, and significant historical events, including the signing of the Treaty of Versailles in 1919. The palace has undergone numerous renovations and restorations, particularly in the 19th and 20th centuries, to preserve its grandeur and historical significance. It is a UNESCO World Heritage Site and one of the most visited tourist attractions in France.", "https://media.cntraveler.com/photos/5a91a36760543c4ae96c2ec7/master/pass/Versailles_Getty_2018_GettyImages-154772942.jpgg", true, "Versailles, France", "Palace of Versailles", 2, 2, "1682" },
                    { 9, "The Empire State Building is a 102-story Art Deco skyscraper in Midtown Manhattan, New York City. Designed by Shreve, Lamb & Harmon and completed in 1931, it was the tallest building in the world until the completion of the World Trade Center in 1970. The building has a roof height of 1,250 feet and stands a total of 1,454 feet tall, including its antenna. The Empire State Building has undergone several renovations, including a significant modernization project completed in 2010 to enhance its energy efficiency. The building is an American cultural icon and has been featured in numerous films and television shows. It was designated a National Historic Landmark in 1986.", "https://www.esbnyc.com/sites/default/files/2019-10/home_banner-min.jpg", true, "New York City, USA", "Empire State Building", 4, 1, "1931" },
                    { 10, "Big Ben is the nickname for the Great Bell of the clock at the north end of the Palace of Westminster in London, and it often extends to refer to both the clock and the clock tower. The tower was designed by Augustus Pugin in a neo-Gothic style and stands 316 feet tall. The clock was the largest and most accurate four-faced striking and chiming clock in the world when it was installed. Big Ben underwent a major renovation between 2017 and 2021, during which the clock mechanism was overhauled, the tower was repaired, and new amenities were installed to improve visitor access and safety. The tower was renamed Elizabeth Tower in 2012 in honor of Queen Elizabeth II's Diamond Jubilee.", "https://media1.thrillophilia.com/filestore/fjsl3vygyrvcu7whwv7eyyi0a3s4_6533128891_2d51a226e3_o.jpg?w=400&dpr=2", true, "London, England", "Big Ben", 14, 2, "1859" },
                    { 11, "Notre-Dame de Paris, also known as Notre-Dame Cathedral, is a medieval Catholic cathedral on the Île de la Cité in Paris, France. The cathedral is considered one of the finest examples of French Gothic architecture, with its innovative use of rib vaults and flying buttresses, its enormous and colorful rose windows, and the naturalism and abundance of its sculptural decoration. The cathedral's construction began in 1163 under Bishop Maurice de Sully and was largely completed by 1260, though it was modified frequently in the following centuries. The cathedral was the site of Napoleon's coronation as Emperor of France. In 2019, the cathedral experienced a devastating fire that destroyed the spire and most of the roof. Restoration efforts are ongoing, with plans to restore the cathedral to its previous state by 2024.", "https://cdn.britannica.com/29/255529-050-63A22A3C/notre-dame-de-paris-cathedral-paris-france.jpg", true, "Paris, France", "Notre-Dame Cathedral", 1, 1, "1163-1345" },
                    { 12, "The Basílica de la Sagrada Família, also known as the Sagrada Família, is a large unfinished Roman Catholic minor basilica in Barcelona, Spain. Designed by the Catalan architect Antoni Gaudí, his work on the building is part of a UNESCO World Heritage Site. In November 2010, Pope Benedict XVI consecrated the church and proclaimed it a minor basilica. The construction of the Sagrada Família began in 1882 and Gaudí took over the project in 1883, transforming it with his architectural and engineering style, combining Gothic and curvilinear Art Nouveau forms. Gaudí devoted his last years to the project, and at the time of his death in 1926, less than a quarter of the project was complete. The basilica's construction has progressed slowly, interrupted by the Spanish Civil War, and relies on private donations. It is anticipated to be completed by 2026, the centenary of Gaudí's death.", "https://cdn.britannica.com/15/194815-050-08B5E7D1/Nativity-facade-Sagrada-Familia-cathedral-Barcelona-Spain.jpg", true, "Barcelona, Spain", "Sagrada Família", 1, 2, "1882-present" },
                    { 13, "Buckingham Palace is the London residence and administrative headquarters of the monarch of the United Kingdom. Located in the City of Westminster, the palace is often at the center of state occasions and royal hospitality. It has been a focal point for the British people at times of national rejoicing and mourning. Originally known as Buckingham House, the building at the core of today's palace was a large townhouse built for the Duke of Buckingham in 1703. It was acquired by King George III in 1761 as a private residence for Queen Charlotte and became known as The Queen's House. During the 19th century, it was enlarged, principally by architects John Nash and Edward Blore, who constructed three wings around a central courtyard. Buckingham Palace became the London residence of the British monarch on the accession of Queen Victoria in 1837. The last major structural additions were made in the late 19th and early 20th centuries, including the East Front, which contains the well-known balcony where the royal family traditionally congregates to greet crowds.", "https://cdn.britannica.com/38/242638-050-D96EB78F/Buckingham-Palace-Victoria-Memorial-Tulips-London-England.jpg", true, "London, England", "Buckingham Palace", 8, 1, "1703" },
                    { 14, "The Parthenon is a former temple on the Athenian Acropolis in Greece, dedicated to the goddess Athena, whom the people of Athens considered their patroness. Construction began in 447 BC when the Athenian Empire was at the peak of its power. It was completed in 438 BC, although decoration of the building continued until 432 BC. It is the most important surviving building of Classical Greece, generally considered the culmination of the development of the Doric order. Its decorative sculptures are considered some of the high points of Greek art. The Parthenon is regarded as an enduring symbol of Ancient Greece, Athenian democracy, and Western civilization, and one of the world's greatest cultural monuments. The Greek Ministry of Culture is currently carrying out a program of restoration and reconstruction to ensure the stability of the partially ruined structure.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ65cjJfLBLMt2NbajpkgCyMJ8QNoTyP3op5xySIzzf1Q&s", true, "Athens, Greece", "The Parthenon", 15, 2, "447-432 BC" },
                    { 15, "The Leaning Tower of Pisa, or simply the Tower of Pisa, is the freestanding bell tower of the cathedral of the Italian city of Pisa, known for its unintended tilt. The tower is situated behind the Pisa Cathedral and is the third oldest structure in the city's Cathedral Square (Piazza del Duomo), after the cathedral and the Pisa Baptistry. The tilt began during construction, caused by an inadequate foundation on ground too soft on one side to properly support the structure's weight. The tilt increased in the decades before the structure was completed, and gradually increased until the structure was stabilized (and the tilt partially corrected) by efforts in the late 20th and early 21st centuries. The height of the tower is 55.86 meters from the ground on the low side and 56.67 meters on the high side. The tower has 294 steps.", "https://images.immediate.co.uk/production/volatile/sites/7/2019/07/30-GettyImages-470534616-9da3b69.jpg", true, "Pisa, Italy", "Leaning Tower of Pisa", 9, 1, "1173-1372" },
                    { 16, "The Cathedral of Vasily the Blessed, commonly known as Saint Basil's Cathedral, is an Orthodox church in Red Square of Moscow, and is one of the most popular cultural symbols of Russia. The building, now a museum, is officially known as the Cathedral of the Intercession of the Most Holy Theotokos on the Moat. It was built from 1555 to 1561 on orders from Ivan the Terrible to commemorate the capture of Kazan and Astrakhan. The building is shaped as a flame of a bonfire rising into the sky, a design that has no analogues in Russian architecture. In the 16th and 17th centuries, the cathedral, perceived as the earthly symbol of the Heavenly City, was popularly known as Jerusalem and served as an allegory of the Jerusalem Temple in the annual Palm Sunday parade attended by the Patriarch of Moscow and the tsar.", "https://media.hswstatic.com/eyJidWNrZXQiOiJjb250ZW50Lmhzd3N0YXRpYy5jb20iLCJrZXkiOiJnaWZcL3N0LWJhc2lscy5qcGciLCJlZGl0cyI6eyJyZXNpemUiOnsid2lkdGgiOjgyOH0sInRvRm9ybWF0IjoiYXZpZiJ9fQ==", true, "Moscow, Russia", "St. Basil's Cathedral", 1, 2, "1555-1561" },
                    { 17, "The Alhambra is a palace and fortress complex located in Granada, Andalusia, Spain. It was originally constructed as a small fortress in 889 AD on the remains of Roman fortifications, and then largely ignored until its ruins were renovated and rebuilt in the mid-13th century by the Nasrid emir Mohammed ben Al-Ahmar of the Emirate of Granada, who built its current palace and walls. It was converted into a royal palace in 1333 by Yusuf I, Sultan of Granada. The Alhambra's Islamic palaces were built for the last Muslim emirs in Spain and its court, of the Nasrid dynasty. After the Reconquista by the Catholic Monarchs in 1492, some portions were used by the Christian rulers. The Alhambra is now one of Spain's major tourist attractions, exhibiting the country's most significant and well-known Islamic architecture, together with Christian 16th-century and later interventions in buildings and gardens.", "https://simple.wikipedia.org/wiki/Alhambra#/media/File:Dawn_Charles_V_Palace_Alhambra_Granada_Andalusia_Spain.jpg", true, "Granada, Spain", "Alhambra", 12, 1, "1238-1358" },
                    { 18, "Petra, originally known to its inhabitants as Raqmu, is a historical and archaeological city in southern Jordan. Petra lies on the slope of Jebel al-Madhbah (identified by some as the biblical Mount Hor) in a basin among the mountains that form the eastern flank of the Arabah valley that runs from the Dead Sea to the Gulf of Aqaba. The area around Petra has been inhabited from as early as 7000 BC, and the Nabataeans might have settled in what would become the capital city of their kingdom as early as the 4th century BC. Archaeological work has only recently started to excavate and explore the city. Petra is famous for its rock-cut architecture and water conduit system. It is also called the Rose City because of the color of the stone from which it is carved. Petra was named amongst the New7Wonders of the World in 2007 and has been a UNESCO World Heritage Site since 1985.", "https://cdn.britannica.com/03/189803-050-871B95C4/Hagia-Sophia-Istanbul.jpg", true, "Ma'an, Jordan", "Petra", 13, 2, "5th century BC" },
                    { 19, "Hagia Sophia, officially the Hagia Sophia Grand Mosque, is a late antique place of worship in Istanbul, Turkey. Constructed in 537 as the patriarchal cathedral of the imperial capital of Constantinople, it was the largest Christian church of the eastern Roman Empire (the Byzantine Empire) and the Eastern Orthodox Church, except during the Latin Empire from 1204 to 1261, when it became the city's Latin Catholic cathedral. In 1453, after the Fall of Constantinople to the Ottoman Empire, it was converted into a mosque by Mehmed the Conqueror. In 1935, the secular Turkish government established it as a museum. In 2020, it was re-converted into a mosque. The Hagia Sophia is famous for its massive dome and is considered the epitome of Byzantine architecture. It remained the world's largest cathedral for nearly a thousand years until Seville Cathedral was completed in 1520.", "https://upload.wikimedia.org/wikipedia/commons/a/a0/Hagia_Sophia_Mars_2013.jpg", true, "Istanbul, Turkey", "Hagia Sophia", 2, 1, "537 AD" },
                    { 20, "Chichen Itza was a large pre-Columbian city built by the Maya people of the Terminal Classic period. The archaeological site is located in Tinúm Municipality, Yucatán State, Mexico. Chichen Itza was a major focal point in the Northern Maya Lowlands from the Late Classic (c. AD 600–900) through the Terminal Classic (c. AD 800–900) and into the early portion of the Postclassic period (c. AD 900–1200). The site exhibits a multitude of architectural styles, reminiscent of styles seen in central Mexico and of the Puuc and Chenes styles of the Northern Maya lowlands. The presence of central Mexican styles was once thought to be representative of direct migration or conquest from central Mexico, but most contemporary interpretations view the presence of these styles more as the result of cultural diffusion. Chichen Itza was one of the largest Maya cities and it was likely to have been one of the mythical great cities, or Tollans, referred to in later Mesoamerican literature. The city may have had the most diverse population in the Maya world, a factor that could have contributed to the variety of architectural styles at the site.", "https://cdn.mos.cms.futurecdn.net/FNeL4VbEE9XDgKriEMi9Sj-1200-80.jpg", true, "Yucatán, Mexico", "Chichen Itza", 13, 2, "600-900 AD" },
                    { 21, "The Parthenon in Nashville is a full-scale replica of the original Parthenon in Athens. It was built in 1897 as part of the Tennessee Centennial Exposition. Today, it serves as an art museum and stands as a centerpiece in Nashville's Centennial Park. The structure houses a replica of the Athena Parthenos statue, which is the tallest indoor statue in the Western Hemisphere. Over the years, the Parthenon has undergone several restorations to maintain its classical Greek architecture and ensure its structural integrity. The most recent restoration efforts have focused on preserving the building's exterior and updating the interior exhibits to enhance the visitor experience.", "https://nashvillego.s3.us-east-2.amazonaws.com/images/articles/whyistheparthenon/parthenon-side-view.jpg", true, "Nashville, Tennessee, USA", "Parthenon (Nashville)", 15, 1, "1897" },
                    { 22, "Ryman Auditorium is a 2,362-seat live-performance venue located at 116 Fifth Avenue North, in Nashville, Tennessee. It is best known as the home of the Grand Ole Opry from 1943 to 1974. The auditorium was originally built as the Union Gospel Tabernacle and has hosted numerous famous performers over its long history. The building underwent a major renovation in 1994 to restore its original 19th-century appearance and enhance its acoustic performance, which included modernizing the seating and stage area while preserving the historic charm. Further restorations in 2012 improved backstage facilities and expanded the lobby to better accommodate visitors.", "https://www.nashville.com/wp-content/uploads/2017/06/Ryman-Auditorium-1.jpg", true, "Nashville, Tennessee, USA", "Ryman Auditorium", 8, 2, "1892" },
                    { 23, "The Tennessee State Museum, located in Nashville, is one of the largest state museums in the United States. It offers exhibits on the history of Tennessee from prehistoric times to the present. The museum was originally opened in 1937 in the War Memorial Building and later moved to its current location in 1981. The museum's extensive collections include artifacts from the state's Native American history, Civil War memorabilia, and various historical documents and artworks. The museum underwent a major expansion and renovation in 2018, which included the construction of a new building with modern exhibit spaces, educational facilities, and improved accessibility for visitors.", "https://hga.com/wp-content/uploads/2018/03/Tennessee-State-Museum-exterior-3-1.jpg", true, "Nashville, Tennessee, USA", "Tennessee State Museum", 5, 1, "1937" },
                    { 24, "The Flatiron Building, originally the Fuller Building, is a triangular 22-story, 285-foot tall steel-framed landmarked building located at 175 Fifth Avenue in the Flatiron District neighborhood of the borough of Manhattan, New York City. It was designed by Chicago's Daniel Burnham in the Beaux-Arts style and was completed in 1902. The building sits on a triangular island block formed by Fifth Avenue, Broadway, and East 22nd Street, with 23rd Street grazing the triangle's northern (uptown) peak. As with numerous other wedge-shaped buildings, the name 'Flatiron' derives from its resemblance to a cast-iron clothes iron. The building underwent a major restoration in the early 1990s to preserve its historic façade and update the interior for modern office use.", "https://i.insider.com/653bc197356802a56be5c3b2?width=1136&format=jpeg", true, "New York City, USA", "Flatiron Building", 3, 1, "1902" },
                    { 25, "The Chrysler Building is an Art Deco skyscraper located on the East Side of Midtown Manhattan in New York City. Standing at 1,046 feet, it was the world's tallest building for 11 months before it was surpassed by the Empire State Building in 1931. Designed by architect William Van Alen for a project of Walter Chrysler, the building is renowned for its distinctive stainless steel cladding and its ornamentation based on Chrysler automobile designs. The building underwent a major renovation in 1978 to restore its original Art Deco elements and modernize its facilities. Additional renovations in the 2000s further enhanced the building's energy efficiency and upgraded its infrastructure.", "https://upload.wikimedia.org/wikipedia/commons/9/94/Chrysler_Building_Midtown_Manhattan_New_York_City_2.jpghttps://chryslerbuilding.com/wp-content/uploads/2020/05/building-1-scaled.jpg", true, "New York City, USA", "Chrysler Building", 4, 1, "1930" },
                    { 26, "The Solomon R. Guggenheim Museum, often referred to as The Guggenheim, is an art museum located at 1071 Fifth Avenue on the corner of East 89th Street in the Upper East Side neighborhood of Manhattan, New York City. Designed by Frank Lloyd Wright, the cylindrical building, wider at the top than at the bottom, was conceived as a 'temple of the spirit.' The unique design features a ramp gallery that spirals upwards in a long, continuous curve, offering visitors a new way to view the museum's collection of modern and contemporary art. The museum underwent a major restoration in 2008, which included repairing the building's façade, improving its infrastructure, and updating its exhibition spaces to enhance the visitor experience.", "https://www.guggenheim.org/wp-content/uploads/2016/04/architecture-srgm-exterior-flavin-16-9-ratio-web.jpg", true, "New York City, USA", "Solomon R. Guggenheim Museum", 5, 2, "1959" },
                    { 27, "Rockefeller Center is a large complex consisting of 19 commercial buildings covering 22 acres between 48th Street and 51st Street in Midtown Manhattan, New York City. The 14 Art Deco buildings are located along Fifth Avenue between 48th and 51st streets. Built by the Rockefeller family, it is renowned for its Christmas tree lighting and ice skating rink. The complex was declared a National Historic Landmark in 1987. Rockefeller Center has undergone several renovations to maintain its iconic Art Deco architecture and improve its functionality for modern use. These renovations have included updating the building's mechanical systems, restoring the historic façade, and enhancing the public spaces to better serve visitors and tenants.", "https://images.ctfassets.net/1aemqu6a6t65/1zYgCLtZoGVWBMRCCVTYDy/3ad232d153812365cb54b85a4e9bf69a/Rockefeller-Center-Tour-Manhattan-NYC-Courtesy.jpg?w=1200&h=800&q=75", true, "New York City, USA", "Rockefeller Center", 4, 1, "1933" },
                    { 28, "The Woolworth Building is an early American skyscraper located at 233 Broadway in Manhattan, New York City. Designed by architect Cass Gilbert and completed in 1913, it was the tallest building in the world at the time of its completion, a title it held until 1930. The building's distinctive Gothic revival style earned it the nickname 'The Cathedral of Commerce.' The Woolworth Building has undergone several renovations, including a major restoration in the 1970s that preserved its historic interior and exterior while upgrading its mechanical systems. More recent renovations have focused on converting the upper floors into luxury residential units while maintaining the building's commercial and office spaces on the lower levels.", "https://media.tacdn.com/media/attractions-splice-spp-674x446/09/ea/a4/9b.jpg", true, "New York City, USA", "Woolworth Building", 14, 2, "1913" },
                    { 29, "The Metropolitan Museum of Art, colloquially 'the Met,' is the largest art museum in the United States. With 6,479,548 visitors to its three locations in 2019, it was the fourth most visited art museum in the world. Its permanent collection contains over two million works, divided among 17 curatorial departments. The main building at 1000 Fifth Avenue, along the Museum Mile on the eastern edge of Central Park in Manhattan's Upper East Side, is by area one of the world's largest art museums. The Met has undergone numerous expansions and renovations since its opening, with significant additions in 1888, 1902, 1911, 1926, and more recently in 2016 with the opening of the Met Breuer. These projects have not only expanded the museum's exhibition space but also enhanced its facilities to support conservation and education programs.", "https://cdn.sanity.io/images/cctd4ker/production/b8a5e07c166342e1c7f6fe30b8c45d64fea69ea5-4096x2326.jpg?w=3840&q=75&fit=clip&auto=format", true, "New York City, USA", "Metropolitan Museum of Art", 3, 1, "1870" },
                    { 30, "The Tennessee State Capitol, located in Nashville, is the home of the Tennessee General Assembly and the location of the governor's office. Designed by renowned architect William Strickland, the building was constructed between 1845 and 1859 and is one of the oldest working state capitol buildings in the United States. The Capitol is a National Historic Landmark and features a Greek Revival style. The building has undergone several restorations, including significant work in the 1950s and 1980s to address structural issues and preserve its historical integrity. Recent renovations have focused on modernizing the building's mechanical systems and improving accessibility while maintaining its historic character.", "https://cdn.britannica.com/80/149380-050-F696C48A/Tennessee-State-Capitol-Nashville.jpg", true, "Nashville, Tennessee, USA", "Tennessee State Capitol", 15, 2, "1859" }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "StyleId", "Name" },
                values: new object[,]
                {
                    { 1, "Gothic" },
                    { 2, "Baroque" },
                    { 3, "Neoclassical" },
                    { 4, "Art Deco" },
                    { 5, "Modern" },
                    { 6, "Postmodern" },
                    { 7, "Renaissance" },
                    { 8, "Victorian" },
                    { 9, "Romanesque" },
                    { 10, "Colonial" },
                    { 11, "Ancient Chinese" },
                    { 12, "Mughal/Islamic" },
                    { 13, "Inca/Pre-Columbian" },
                    { 14, "Gothic Revival" },
                    { 15, "Classical" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 1, "National Monument" },
                    { 2, "Tourist Attraction" },
                    { 3, "Endangered" },
                    { 4, "Art Installation" },
                    { 5, "Renovated" },
                    { 6, "Cultural Landmark" },
                    { 7, "Museum" },
                    { 8, "Under Construction" },
                    { 9, "Closed for Renovation" },
                    { 10, "Sustainable" },
                    { 11, "Innovation" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Uid" },
                values: new object[,]
                {
                    { 1, "uidstring" },
                    { 2, "uidstring" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingTag_TagsTagId",
                table: "BuildingTag",
                column: "TagsTagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingTag");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
