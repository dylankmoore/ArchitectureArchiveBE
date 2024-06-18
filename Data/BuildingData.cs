﻿using System.Runtime.InteropServices;
using System;
using ArchitectureArchiveBE.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.SignalR;
using static System.Collections.Specialized.BitVector32;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ArchitectureArchiveBE.Data
{
    public class BuildingData
    {
        public static List<Building> Buildings { get; set; } = new List<Building>
        {
            new Building
            {
                BuildingId = 1,
                Name = "Eiffel Tower",
                Location = "Paris, France",
                YearBuilt = "1889",
                Description = "The Eiffel Tower is a wrought iron lattice tower on the Champ de Mars in Paris, France. It was named after the engineer Gustave Eiffel, whose company designed and built the tower. Initially criticized by some of France's leading artists and intellectuals for its design, the tower has become a global cultural icon of France and one of the most recognizable structures in the world. The Eiffel Tower is 324 meters tall and was the tallest man-made structure in the world until the Chrysler Building in New York City was completed in 1930. It has three levels for visitors, with restaurants on the first and second levels. The tower was initially intended as a temporary exhibit but was kept after its popularity soared. It has undergone several renovations, including the addition of elevators in 1983 and the installation of a new lighting system in 1985.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 5, // Modern
                ImageURL = "https://cdn-imgix.headout.com/media/images/c90f7eb7a5825e6f5e57a5a62d05399c-25058-BestofParis-EiffelTower-Cruise-Louvre-002.jpg"
            },
            new Building
            {
                BuildingId = 2,
                Name = "Statue of Liberty",
                Location = "New York City, USA",
                YearBuilt = "1886",
                Description = "The Statue of Liberty is a colossal neoclassical sculpture on Liberty Island in New York Harbor. Designed by French sculptor Frédéric Auguste Bartholdi and built by Gustave Eiffel, the statue was a gift from the people of France to the United States. The statue is an icon of freedom and a welcoming signal to immigrants arriving from abroad. It stands 93 meters tall from ground to torch. Over the years, the statue has undergone several renovations. The most significant renovation took place in 1984-1986 for its centennial celebration, which included the replacement of the torch and the restoration of the internal structure. The Statue of Liberty was designated a National Monument in 1924 and a UNESCO World Heritage Site in 1984.",
                IsRegistered = true,
                UserId = 2,
                StyleId = 3, // Neoclassical
                ImageURL = "https://eadn-wc03-11391632.nxedge.io/wp-content/uploads/2019/02/statue-of-liberty.jpg"
            },
            new Building
            {
                BuildingId = 3,
                Name = "Colosseum",
                Location = "Rome, Italy",
                YearBuilt = "70-80 AD",
                Description = "The Colosseum, also known as the Flavian Amphitheatre, is an ancient amphitheatre in the center of Rome, Italy. It is the largest ancient amphitheatre ever built, and remains the largest standing amphitheatre in the world today. Construction began under Emperor Vespasian in 72 AD and was completed in 80 AD under his successor, Titus. The Colosseum could hold an estimated 50,000 to 80,000 spectators and was used for gladiatorial contests and public spectacles such as mock sea battles, animal hunts, executions, re-enactments of famous battles, and dramas based on Classical mythology. The Colosseum has undergone several renovations throughout its history, including significant repairs after the damage caused by earthquakes in 847 and 1231. In the 1990s, a major renovation project was undertaken to address structural concerns and preserve the monument for future generations.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 9, // Romanesque
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/Colosseo_2020.jpg/1200px-Colosseo_2020.jpg"
            },
            new Building
            {
                BuildingId = 4,
                Name = "Great Wall of China",
                Location = "China",
                YearBuilt = "7th century BC",
                Description = "The Great Wall of China is a series of fortifications made of various materials, generally built along an east-to-west line across the historical northern borders of China to protect Chinese states and empires against the raids and invasions of various nomadic groups. Several walls were built as early as the 7th century BC, with major expansions occurring during the Ming Dynasty (1368–1644). The wall spans approximately 13,171 miles, making it the longest structure ever built by humans. The wall has faced significant deterioration over the centuries due to natural erosion and human activity, leading to multiple restoration projects aimed at preserving its structure and historical significance. Notable sections like Badaling and Mutianyu have been extensively restored and are popular tourist destinations.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 11, // Ancient Chinese
                ImageURL = "https://th-thumbnailer.cdn-si-edu.com/Jxn_9H-e_JpGocZHVGy4Ytc-9Y4=/fit-in/1600x0/https%3A%2F%2Ftf-cmsv2-smithsonianmag-media.s3.amazonaws.com%2Ffiler%2F80%2Ffa%2F80facab4-fe0e-4a56-bd99-a71eb1845fa0%2F01_14_2014_great_wall.jpg"
            },
            new Building
            {
                BuildingId = 5,
                Name = "Taj Mahal",
                Location = "Agra, India",
                YearBuilt = "1632",
                Description = "The Taj Mahal is an ivory-white marble mausoleum on the southern bank of the river Yamuna in the Indian city of Agra. It was commissioned in 1632 by the Mughal emperor Shah Jahan to house the tomb of his favorite wife, Mumtaz Mahal. The tomb is the centrepiece of a 17-hectare complex, which includes a mosque and a guest house, and is set in formal gardens bounded on three sides by a crenellated wall. The construction project employed some 20,000 artisans under the guidance of a board of architects led by Ustad Ahmad Lahauri. The Taj Mahal was designated as a UNESCO World Heritage Site in 1983 for being 'the jewel of Muslim art in India and one of the universally admired masterpieces of the world's heritage.' The structure underwent major restoration in the early 20th century during the British colonial period to address deterioration issues and has continued to be maintained and preserved as a significant cultural site.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 12, // Mughal/Islamic
                ImageURL = "https://discovery.sndimg.com/content/dam/images/discovery/fullset/2020/2/21/thumbnail.png.rend.hgtvcom.1280.720.suffix/1582329440048.png"
            },
            new Building
            {
                BuildingId = 6,
                Name = "Sydney Opera House",
                Location = "Sydney, Australia",
                YearBuilt = "1973",
                Description = "The Sydney Opera House is a multi-venue performing arts center at Sydney Harbour in Sydney, Australia. Designed by Danish architect Jørn Utzon, the building was formally opened on 20 October 1973. It is one of the most famous and distinctive buildings in the world. The Sydney Opera House comprises multiple performance venues which together host well over 1,500 performances annually, attended by more than 1.2 million people. Major renovations have included updating the acoustics and modernizing the performance spaces to accommodate contemporary shows. In 2007, the Opera House was designated as a UNESCO World Heritage Site, recognizing its architectural significance and cultural importance.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 6, // Postmodern
                ImageURL = "https://ychef.files.bbci.co.uk/1280x720/p0gp95cq.jpg"
            },
            new Building
            {
                BuildingId = 7,
                Name = "Machu Picchu",
                Location = "Cusco Region, Peru",
                YearBuilt = "1450",
                Description = "Machu Picchu is a 15th-century Inca citadel located in the Eastern Cordillera of southern Peru on a mountain ridge 2,430 meters above sea level. It is located in the Machupicchu District within Urubamba Province above the Sacred Valley, which is 80 kilometers northwest of Cusco. Most archaeologists believe that Machu Picchu was constructed as an estate for the Inca emperor Pachacuti (1438–1472). The site was largely unknown to the outside world until it was brought to international attention by the American historian Hiram Bingham in 1911. Machu Picchu was declared a Peruvian Historic Sanctuary in 1981 and a UNESCO World Heritage Site in 1983. Extensive renovations and preservation efforts have been undertaken to maintain the site, including structural stabilization and restoration of key architectural features.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 13, // Inca/Pre-Columbian
                ImageURL = "https://www.anywhere.com/img-a/peru/destinations/aguas-calientes/tours/film-and-productions-services/machupicchu-sunrise%20mid.jpg?q=75&type=jpeg&w=480"
            },
            new Building
            {
                BuildingId = 8,
                Name = "Palace of Versailles",
                Location = "Versailles, France",
                YearBuilt = "1682",
                Description = "The Palace of Versailles is a former royal residence located in Versailles, about 19 kilometers west of Paris, France. It was originally a hunting lodge built in 1623 by Louis XIII and later expanded into a grand palace by Louis XIV. Versailles is famous for its opulent architecture, elaborate gardens, and significant historical events, including the signing of the Treaty of Versailles in 1919. The palace has undergone numerous renovations and restorations, particularly in the 19th and 20th centuries, to preserve its grandeur and historical significance. It is a UNESCO World Heritage Site and one of the most visited tourist attractions in France.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 2, // Baroque
                ImageURL = "https://media.cntraveler.com/photos/5a91a36760543c4ae96c2ec7/master/pass/Versailles_Getty_2018_GettyImages-154772942.jpgg"
            },
            new Building
            {
                BuildingId = 9,
                Name = "Empire State Building",
                Location = "New York City, USA",
                YearBuilt = "1931",
                Description = "The Empire State Building is a 102-story Art Deco skyscraper in Midtown Manhattan, New York City. Designed by Shreve, Lamb & Harmon and completed in 1931, it was the tallest building in the world until the completion of the World Trade Center in 1970. The building has a roof height of 1,250 feet and stands a total of 1,454 feet tall, including its antenna. The Empire State Building has undergone several renovations, including a significant modernization project completed in 2010 to enhance its energy efficiency. The building is an American cultural icon and has been featured in numerous films and television shows. It was designated a National Historic Landmark in 1986.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 4, // Art Deco
                ImageURL = "https://www.esbnyc.com/sites/default/files/2019-10/home_banner-min.jpg"
            },
            new Building
            {
                BuildingId = 10,
                Name = "Big Ben",
                Location = "London, England",
                YearBuilt = "1859",
                Description = "Big Ben is the nickname for the Great Bell of the clock at the north end of the Palace of Westminster in London, and it often extends to refer to both the clock and the clock tower. The tower was designed by Augustus Pugin in a neo-Gothic style and stands 316 feet tall. The clock was the largest and most accurate four-faced striking and chiming clock in the world when it was installed. Big Ben underwent a major renovation between 2017 and 2021, during which the clock mechanism was overhauled, the tower was repaired, and new amenities were installed to improve visitor access and safety. The tower was renamed Elizabeth Tower in 2012 in honor of Queen Elizabeth II's Diamond Jubilee.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 14, // Gothic Revival
                ImageURL = "https://media1.thrillophilia.com/filestore/fjsl3vygyrvcu7whwv7eyyi0a3s4_6533128891_2d51a226e3_o.jpg?w=400&dpr=2"
            },
            new Building
            {
                BuildingId = 11,
                Name = "Notre-Dame Cathedral",
                Location = "Paris, France",
                YearBuilt = "1163-1345",
                Description = "Notre-Dame de Paris, also known as Notre-Dame Cathedral, is a medieval Catholic cathedral on the Île de la Cité in Paris, France. The cathedral is considered one of the finest examples of French Gothic architecture, with its innovative use of rib vaults and flying buttresses, its enormous and colorful rose windows, and the naturalism and abundance of its sculptural decoration. The cathedral's construction began in 1163 under Bishop Maurice de Sully and was largely completed by 1260, though it was modified frequently in the following centuries. The cathedral was the site of Napoleon's coronation as Emperor of France. In 2019, the cathedral experienced a devastating fire that destroyed the spire and most of the roof. Restoration efforts are ongoing, with plans to restore the cathedral to its previous state by 2024.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 1, // Gothic
                ImageURL = "https://cdn.britannica.com/29/255529-050-63A22A3C/notre-dame-de-paris-cathedral-paris-france.jpg"
            },
            new Building
            {
                BuildingId = 12,
                Name = "Sagrada Família",
                Location = "Barcelona, Spain",
                YearBuilt = "1882-present",
                Description = "The Basílica de la Sagrada Família, also known as the Sagrada Família, is a large unfinished Roman Catholic minor basilica in Barcelona, Spain. Designed by the Catalan architect Antoni Gaudí, his work on the building is part of a UNESCO World Heritage Site. In November 2010, Pope Benedict XVI consecrated the church and proclaimed it a minor basilica. The construction of the Sagrada Família began in 1882 and Gaudí took over the project in 1883, transforming it with his architectural and engineering style, combining Gothic and curvilinear Art Nouveau forms. Gaudí devoted his last years to the project, and at the time of his death in 1926, less than a quarter of the project was complete. The basilica's construction has progressed slowly, interrupted by the Spanish Civil War, and relies on private donations. It is anticipated to be completed by 2026, the centenary of Gaudí's death.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 1, // Gothic (combination with Art Nouveau)
                ImageURL = "https://cdn.britannica.com/15/194815-050-08B5E7D1/Nativity-facade-Sagrada-Familia-cathedral-Barcelona-Spain.jpg"
            },
            new Building
            {
                BuildingId = 13,
                Name = "Buckingham Palace",
                Location = "London, England",
                YearBuilt = "1703",
                Description = "Buckingham Palace is the London residence and administrative headquarters of the monarch of the United Kingdom. Located in the City of Westminster, the palace is often at the center of state occasions and royal hospitality. It has been a focal point for the British people at times of national rejoicing and mourning. Originally known as Buckingham House, the building at the core of today's palace was a large townhouse built for the Duke of Buckingham in 1703. It was acquired by King George III in 1761 as a private residence for Queen Charlotte and became known as The Queen's House. During the 19th century, it was enlarged, principally by architects John Nash and Edward Blore, who constructed three wings around a central courtyard. Buckingham Palace became the London residence of the British monarch on the accession of Queen Victoria in 1837. The last major structural additions were made in the late 19th and early 20th centuries, including the East Front, which contains the well-known balcony where the royal family traditionally congregates to greet crowds.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 8, // Victorian
                ImageURL = "https://cdn.britannica.com/38/242638-050-D96EB78F/Buckingham-Palace-Victoria-Memorial-Tulips-London-England.jpg"
            },
            new Building
            {
                BuildingId = 14,
                Name = "The Parthenon",
                Location = "Athens, Greece",
                YearBuilt = "447-432 BC",
                Description = "The Parthenon is a former temple on the Athenian Acropolis in Greece, dedicated to the goddess Athena, whom the people of Athens considered their patroness. Construction began in 447 BC when the Athenian Empire was at the peak of its power. It was completed in 438 BC, although decoration of the building continued until 432 BC. It is the most important surviving building of Classical Greece, generally considered the culmination of the development of the Doric order. Its decorative sculptures are considered some of the high points of Greek art. The Parthenon is regarded as an enduring symbol of Ancient Greece, Athenian democracy, and Western civilization, and one of the world's greatest cultural monuments. The Greek Ministry of Culture is currently carrying out a program of restoration and reconstruction to ensure the stability of the partially ruined structure.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 15, // Classical
                ImageURL = "https://www.worldhistory.org/uploads/images/3372.jpg"
            },
            new Building
            {
                BuildingId = 15,
                Name = "Leaning Tower of Pisa",
                Location = "Pisa, Italy",
                YearBuilt = "1173-1372",
                Description = "The Leaning Tower of Pisa, or simply the Tower of Pisa, is the freestanding bell tower of the cathedral of the Italian city of Pisa, known for its unintended tilt. The tower is situated behind the Pisa Cathedral and is the third oldest structure in the city's Cathedral Square (Piazza del Duomo), after the cathedral and the Pisa Baptistry. The tilt began during construction, caused by an inadequate foundation on ground too soft on one side to properly support the structure's weight. The tilt increased in the decades before the structure was completed, and gradually increased until the structure was stabilized (and the tilt partially corrected) by efforts in the late 20th and early 21st centuries. The height of the tower is 55.86 meters from the ground on the low side and 56.67 meters on the high side. The tower has 294 steps.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 9, // Romanesque
                ImageURL = "https://images.immediate.co.uk/production/volatile/sites/7/2019/07/30-GettyImages-470534616-9da3b69.jpg"
            },
            new Building
            {
                BuildingId = 16,
                Name = "St. Basil's Cathedral",
                Location = "Moscow, Russia",
                YearBuilt = "1555-1561",
                Description = "The Cathedral of Vasily the Blessed, commonly known as Saint Basil's Cathedral, is an Orthodox church in Red Square of Moscow, and is one of the most popular cultural symbols of Russia. The building, now a museum, is officially known as the Cathedral of the Intercession of the Most Holy Theotokos on the Moat. It was built from 1555 to 1561 on orders from Ivan the Terrible to commemorate the capture of Kazan and Astrakhan. The building is shaped as a flame of a bonfire rising into the sky, a design that has no analogues in Russian architecture. In the 16th and 17th centuries, the cathedral, perceived as the earthly symbol of the Heavenly City, was popularly known as Jerusalem and served as an allegory of the Jerusalem Temple in the annual Palm Sunday parade attended by the Patriarch of Moscow and the tsar.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 1, // Gothic
                ImageURL = "https://media.hswstatic.com/eyJidWNrZXQiOiJjb250ZW50Lmhzd3N0YXRpYy5jb20iLCJrZXkiOiJnaWZcL3N0LWJhc2lscy5qcGciLCJlZGl0cyI6eyJyZXNpemUiOnsid2lkdGgiOjgyOH0sInRvRm9ybWF0IjoiYXZpZiJ9fQ=="
            },
            new Building
            {
                BuildingId = 17,
                Name = "Alhambra",
                Location = "Granada, Spain",
                YearBuilt = "1238-1358",
                Description = "The Alhambra is a palace and fortress complex located in Granada, Andalusia, Spain. It was originally constructed as a small fortress in 889 AD on the remains of Roman fortifications, and then largely ignored until its ruins were renovated and rebuilt in the mid-13th century by the Nasrid emir Mohammed ben Al-Ahmar of the Emirate of Granada, who built its current palace and walls. It was converted into a royal palace in 1333 by Yusuf I, Sultan of Granada. The Alhambra's Islamic palaces were built for the last Muslim emirs in Spain and its court, of the Nasrid dynasty. After the Reconquista by the Catholic Monarchs in 1492, some portions were used by the Christian rulers. The Alhambra is now one of Spain's major tourist attractions, exhibiting the country's most significant and well-known Islamic architecture, together with Christian 16th-century and later interventions in buildings and gardens.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 12, // Mughal/Islamic
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/Dawn_Charles_V_Palace_Alhambra_Granada_Andalusia_Spain.jpg/640px-Dawn_Charles_V_Palace_Alhambra_Granada_Andalusia_Spain.jpg"
            },
            new Building
            {
                BuildingId = 18,
                Name = "Petra",
                Location = "Ma'an, Jordan",
                YearBuilt = "5th century BC",
                Description = "Petra, originally known to its inhabitants as Raqmu, is a historical and archaeological city in southern Jordan. Petra lies on the slope of Jebel al-Madhbah (identified by some as the biblical Mount Hor) in a basin among the mountains that form the eastern flank of the Arabah valley that runs from the Dead Sea to the Gulf of Aqaba. The area around Petra has been inhabited from as early as 7000 BC, and the Nabataeans might have settled in what would become the capital city of their kingdom as early as the 4th century BC. Archaeological work has only recently started to excavate and explore the city. Petra is famous for its rock-cut architecture and water conduit system. It is also called the Rose City because of the color of the stone from which it is carved. Petra was named amongst the New7Wonders of the World in 2007 and has been a UNESCO World Heritage Site since 1985.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 13, // Inca/Pre-Columbian (more accurately Nabataean architecture, but we'll use this for categorization)
                ImageURL = "https://cdn.britannica.com/03/189803-050-871B95C4/Hagia-Sophia-Istanbul.jpg"
            },
            new Building
            {
                BuildingId = 19,
                Name = "Hagia Sophia",
                Location = "Istanbul, Turkey",
                YearBuilt = "537 AD",
                Description = "Hagia Sophia, officially the Hagia Sophia Grand Mosque, is a late antique place of worship in Istanbul, Turkey. Constructed in 537 as the patriarchal cathedral of the imperial capital of Constantinople, it was the largest Christian church of the eastern Roman Empire (the Byzantine Empire) and the Eastern Orthodox Church, except during the Latin Empire from 1204 to 1261, when it became the city's Latin Catholic cathedral. In 1453, after the Fall of Constantinople to the Ottoman Empire, it was converted into a mosque by Mehmed the Conqueror. In 1935, the secular Turkish government established it as a museum. In 2020, it was re-converted into a mosque. The Hagia Sophia is famous for its massive dome and is considered the epitome of Byzantine architecture. It remained the world's largest cathedral for nearly a thousand years until Seville Cathedral was completed in 1520.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 2, // Baroque (more accurately Byzantine architecture, but we'll use this for categorization)
                ImageURL = "https://projects.iq.harvard.edu/sites/projects.iq.harvard.edu/files/styles/os_files_xxlarge/public/whoseculture/files/hagia_sophia_exterior.jpg?m=1607399097&itok=xge9nGpj"
            },
            new Building
            {
                BuildingId = 20,
                Name = "Chichen Itza",
                Location = "Yucatán, Mexico",
                YearBuilt = "600-900 AD",
                Description = "Chichen Itza was a large pre-Columbian city built by the Maya people of the Terminal Classic period. The archaeological site is located in Tinúm Municipality, Yucatán State, Mexico. Chichen Itza was a major focal point in the Northern Maya Lowlands from the Late Classic (c. AD 600–900) through the Terminal Classic (c. AD 800–900) and into the early portion of the Postclassic period (c. AD 900–1200). The site exhibits a multitude of architectural styles, reminiscent of styles seen in central Mexico and of the Puuc and Chenes styles of the Northern Maya lowlands. The presence of central Mexican styles was once thought to be representative of direct migration or conquest from central Mexico, but most contemporary interpretations view the presence of these styles more as the result of cultural diffusion. Chichen Itza was one of the largest Maya cities and it was likely to have been one of the mythical great cities, or Tollans, referred to in later Mesoamerican literature. The city may have had the most diverse population in the Maya world, a factor that could have contributed to the variety of architectural styles at the site.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 13, // Inca/Pre-Columbian
                ImageURL = "https://cdn.mos.cms.futurecdn.net/FNeL4VbEE9XDgKriEMi9Sj-1200-80.jpg"
            },
            new Building
            {
                BuildingId = 21,
                Name = "Parthenon (Nashville)",
                Location = "Nashville, Tennessee, USA",
                YearBuilt = "1897",
                Description = "The Parthenon in Nashville is a full-scale replica of the original Parthenon in Athens. It was built in 1897 as part of the Tennessee Centennial Exposition. Today, it serves as an art museum and stands as a centerpiece in Nashville's Centennial Park. The structure houses a replica of the Athena Parthenos statue, which is the tallest indoor statue in the Western Hemisphere. Over the years, the Parthenon has undergone several restorations to maintain its classical Greek architecture and ensure its structural integrity. The most recent restoration efforts have focused on preserving the building's exterior and updating the interior exhibits to enhance the visitor experience.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 15, // Classical
                ImageURL = "https://nashvillego.s3.us-east-2.amazonaws.com/images/articles/whyistheparthenon/parthenon-side-view.jpg"
            },
            new Building
            {
                BuildingId = 22,
                Name = "Ryman Auditorium",
                Location = "Nashville, Tennessee, USA",
                YearBuilt = "1892",
                Description = "Ryman Auditorium is a 2,362-seat live-performance venue located at 116 Fifth Avenue North, in Nashville, Tennessee. It is best known as the home of the Grand Ole Opry from 1943 to 1974. The auditorium was originally built as the Union Gospel Tabernacle and has hosted numerous famous performers over its long history. The building underwent a major renovation in 1994 to restore its original 19th-century appearance and enhance its acoustic performance, which included modernizing the seating and stage area while preserving the historic charm. Further restorations in 2012 improved backstage facilities and expanded the lobby to better accommodate visitors.",
                IsRegistered = true,
                UserId = 2,
                StyleId = 8, // Victorian
                ImageURL = "https://www.nashville.com/wp-content/uploads/2017/06/Ryman-Auditorium-1.jpg"
            },
            new Building
            {
                BuildingId = 23,
                Name = "Tennessee State Museum",
                Location = "Nashville, Tennessee, USA",
                YearBuilt = "1937",
                Description = "The Tennessee State Museum, located in Nashville, is one of the largest state museums in the United States. It offers exhibits on the history of Tennessee from prehistoric times to the present. The museum was originally opened in 1937 in the War Memorial Building and later moved to its current location in 1981. The museum's extensive collections include artifacts from the state's Native American history, Civil War memorabilia, and various historical documents and artworks. The museum underwent a major expansion and renovation in 2018, which included the construction of a new building with modern exhibit spaces, educational facilities, and improved accessibility for visitors.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 5, // Modern
                ImageURL = "https://hga.com/wp-content/uploads/2018/03/Tennessee-State-Museum-exterior-3-1.jpg"
            },
            new Building
            {
                BuildingId = 24,
                Name = "Flatiron Building",
                Location = "New York City, USA",
                YearBuilt = "1902",
                Description = "The Flatiron Building, originally the Fuller Building, is a triangular 22-story, 285-foot tall steel-framed landmarked building located at 175 Fifth Avenue in the Flatiron District neighborhood of the borough of Manhattan, New York City. It was designed by Chicago's Daniel Burnham in the Beaux-Arts style and was completed in 1902. The building sits on a triangular island block formed by Fifth Avenue, Broadway, and East 22nd Street, with 23rd Street grazing the triangle's northern (uptown) peak. As with numerous other wedge-shaped buildings, the name 'Flatiron' derives from its resemblance to a cast-iron clothes iron. The building underwent a major restoration in the early 1990s to preserve its historic façade and update the interior for modern office use.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 3, // Neoclassical (Beaux-Arts)
                ImageURL = "https://i.insider.com/653bc197356802a56be5c3b2?width=1136&format=jpeg"
            },
            new Building
            {
                BuildingId = 25,
                Name = "Chrysler Building",
                Location = "New York City, USA",
                YearBuilt = "1930",
                Description = "The Chrysler Building is an Art Deco skyscraper located on the East Side of Midtown Manhattan in New York City. Standing at 1,046 feet, it was the world's tallest building for 11 months before it was surpassed by the Empire State Building in 1931. Designed by architect William Van Alen for a project of Walter Chrysler, the building is renowned for its distinctive stainless steel cladding and its ornamentation based on Chrysler automobile designs. The building underwent a major renovation in 1978 to restore its original Art Deco elements and modernize its facilities. Additional renovations in the 2000s further enhanced the building's energy efficiency and upgraded its infrastructure.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 4, // Art Deco
                ImageURL = "https://imageio.forbes.com/specials-images/imageserve/6581c576d696b57bec66c63f/0x0.jpg?format=jpg&crop=1477,830,x0,y38,safe&height=900&width=1600&fit=bounds"
            },
            new Building
            {
                BuildingId = 26,
                Name = "Solomon R. Guggenheim Museum",
                Location = "New York City, USA",
                YearBuilt = "1959",
                Description = "The Solomon R. Guggenheim Museum, often referred to as The Guggenheim, is an art museum located at 1071 Fifth Avenue on the corner of East 89th Street in the Upper East Side neighborhood of Manhattan, New York City. Designed by Frank Lloyd Wright, the cylindrical building, wider at the top than at the bottom, was conceived as a 'temple of the spirit.' The unique design features a ramp gallery that spirals upwards in a long, continuous curve, offering visitors a new way to view the museum's collection of modern and contemporary art. The museum underwent a major restoration in 2008, which included repairing the building's façade, improving its infrastructure, and updating its exhibition spaces to enhance the visitor experience.",
                IsRegistered = true,
                UserId = 2,
                StyleId = 5, // Modern
                ImageURL = "https://www.guggenheim.org/wp-content/uploads/2016/04/architecture-srgm-exterior-flavin-16-9-ratio-web.jpg"
            },
            new Building
            {
                BuildingId = 27,
                Name = "Rockefeller Center",
                Location = "New York City, USA",
                YearBuilt = "1933",
                Description = "Rockefeller Center is a large complex consisting of 19 commercial buildings covering 22 acres between 48th Street and 51st Street in Midtown Manhattan, New York City. The 14 Art Deco buildings are located along Fifth Avenue between 48th and 51st streets. Built by the Rockefeller family, it is renowned for its Christmas tree lighting and ice skating rink. The complex was declared a National Historic Landmark in 1987. Rockefeller Center has undergone several renovations to maintain its iconic Art Deco architecture and improve its functionality for modern use. These renovations have included updating the building's mechanical systems, restoring the historic façade, and enhancing the public spaces to better serve visitors and tenants.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 4, // Art Deco
                ImageURL = "https://images.ctfassets.net/1aemqu6a6t65/1zYgCLtZoGVWBMRCCVTYDy/3ad232d153812365cb54b85a4e9bf69a/Rockefeller-Center-Tour-Manhattan-NYC-Courtesy.jpg?w=1200&h=800&q=75"
            },
            new Building
            {
                BuildingId = 28,
                Name = "Woolworth Building",
                Location = "New York City, USA",
                YearBuilt = "1913",
                Description = "The Woolworth Building is an early American skyscraper located at 233 Broadway in Manhattan, New York City. Designed by architect Cass Gilbert and completed in 1913, it was the tallest building in the world at the time of its completion, a title it held until 1930. The building's distinctive Gothic revival style earned it the nickname 'The Cathedral of Commerce.' The Woolworth Building has undergone several renovations, including a major restoration in the 1970s that preserved its historic interior and exterior while upgrading its mechanical systems. More recent renovations have focused on converting the upper floors into luxury residential units while maintaining the building's commercial and office spaces on the lower levels.",
                IsRegistered = true,
                UserId = 2,
                StyleId = 14, // Gothic Revival
                ImageURL = "https://media.tacdn.com/media/attractions-splice-spp-674x446/09/ea/a4/9b.jpg"
            },
            new Building
            {
                BuildingId = 29,
                Name = "Metropolitan Museum of Art",
                Location = "New York City, USA",
                YearBuilt = "1870",
                Description = "The Metropolitan Museum of Art, colloquially 'the Met,' is the largest art museum in the United States. With 6,479,548 visitors to its three locations in 2019, it was the fourth most visited art museum in the world. Its permanent collection contains over two million works, divided among 17 curatorial departments. The main building at 1000 Fifth Avenue, along the Museum Mile on the eastern edge of Central Park in Manhattan's Upper East Side, is by area one of the world's largest art museums. The Met has undergone numerous expansions and renovations since its opening, with significant additions in 1888, 1902, 1911, 1926, and more recently in 2016 with the opening of the Met Breuer. These projects have not only expanded the museum's exhibition space but also enhanced its facilities to support conservation and education programs.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 3, // Neoclassical
                ImageURL = "https://cdn.sanity.io/images/cctd4ker/production/b8a5e07c166342e1c7f6fe30b8c45d64fea69ea5-4096x2326.jpg?w=3840&q=75&fit=clip&auto=format"
            },
            new Building
            {
                BuildingId = 30,
                Name = "Tennessee State Capitol",
                Location = "Nashville, Tennessee, USA",
                YearBuilt = "1859",
                Description = "The Tennessee State Capitol, located in Nashville, is the home of the Tennessee General Assembly and the location of the governor's office. Designed by renowned architect William Strickland, the building was constructed between 1845 and 1859 and is one of the oldest working state capitol buildings in the United States. The Capitol is a National Historic Landmark and features a Greek Revival style. The building has undergone several restorations, including significant work in the 1950s and 1980s to address structural issues and preserve its historical integrity. Recent renovations have focused on modernizing the building's mechanical systems and improving accessibility while maintaining its historic character.",
                IsRegistered = true,
                UserId = 2,
                StyleId = 15, // Classical
                ImageURL = "https://cdn.britannica.com/80/149380-050-F696C48A/Tennessee-State-Capitol-Nashville.jpg"
            },
            new Building
            {
                BuildingId = 31,
                Name = "Transamerica Pyramid",
                Location = "San Francisco, California, USA",
                YearBuilt = "1972",
                Description = "The Transamerica Pyramid is a 48-story futurist skyscraper in San Francisco, California, and is the second tallest building in the city. Completed in 1972, the building was designed by architect William Pereira and is characterized by its unique pyramid shape. The building underwent a significant renovation in 1995 to update its mechanical systems and improve earthquake resistance. The Transamerica Pyramid remains an iconic symbol of San Francisco's skyline.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 5, // Modern
                ImageURL = "https://cdn.britannica.com/34/250234-050-913C1878/San-Francisco-California-Transamerica-Pyramid-building.jpg"
            },
            new Building
            {
                BuildingId = 32,
                Name = "Union Station",
                Location = "Washington, D.C., USA",
                YearBuilt = "1907",
                Description = "Union Station in Washington, D.C., designed by architect Daniel Burnham and completed in 1907, is a notable example of Beaux-Arts architecture. The station features a grand Great Hall with a coffered ceiling, gold leaf detailing, and large arched windows. Initially a critical transportation hub for visitors and military operations during both World Wars, the station fell into disrepair by the 1960s and was nearly demolished. A major restoration in the 1980s preserved its historical features while modernizing facilities, including the repair of the Great Hall’s ceiling and the addition of retail and dining spaces. Further rehabilitation projects in the 2010s addressed structural concerns and enhanced capacity and accessibility. Today, Union Station serves millions of travelers annually through Amtrak, MARC, and VRE commuter rail services, as well as local and intercity buses. It remains a functional transit hub and a historic landmark, reflecting early 20th-century architectural grandeur and historical significance.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 3, // Neoclassical (Beaux-Arts)
                ImageURL = "https://media.cntraveler.com/photos/55d660df37284fb1079d1ea6/16:9/w_2560,c_limit/union-station-hotel-nashville-exterior.jpg"
            },
            new Building
            {
                BuildingId = 33,
                Name = "Hearst Castle",
                Location = "San Simeon, California, USA",
                YearBuilt = "1919",
                Description = "Hearst Castle is a National Historic Landmark and California Historical Landmark located on the Central Coast of California. Designed by architect Julia Morgan for newspaper magnate William Randolph Hearst, the castle was built between 1919 and 1947. The estate includes a main house, guest houses, pools, and extensive gardens. Hearst Castle has been maintained as a museum since 1958, and it attracts millions of visitors each year. Restoration efforts have focused on preserving its opulent interiors and architectural features.",
                IsRegistered = true,
                UserId = 2,
                StyleId = 7, // Renaissance (Mediterranean Revival)
                ImageURL = "https://cdn.britannica.com/27/183127-050-B1360DCB/Hearst-Castle-California-San-Simeon-Julia-Morgan.jpg"
            },
            new Building
            {
                BuildingId = 34,
                Name = "Biltmore Estate",
                Location = "Asheville, North Carolina, USA",
                YearBuilt = "1895",
                Description = "The Biltmore Estate is a historic house museum and tourist attraction in Asheville, North Carolina. Built for George Washington Vanderbilt II and completed in 1895, it is the largest privately-owned house in the United States. The mansion features Châteauesque architecture and is surrounded by extensive gardens designed by Frederick Law Olmsted. The estate has undergone numerous renovations to preserve its historical integrity and accommodate visitors. It remains a popular destination for its architecture, gardens, and historical significance.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 8, // Victorian (Châteauesque)
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/c/cd/Biltmore_Estate%2C_Asheville%2C_North_Carolina.jpg"
            },
            new Building
            {
                BuildingId = 35,
                Name = "Fallingwater",
                Location = "Mill Run, Pennsylvania, USA",
                YearBuilt = "1937",
                Description = "Fallingwater is a house designed by architect Frank Lloyd Wright in 1935 in rural southwestern Pennsylvania. The house was built partly over a waterfall on Bear Run in the Mill Run section of Stewart Township, Fayette County. It is one of Wright's most famous works and was designated a National Historic Landmark in 1966. Fallingwater was listed among Smithsonian's Life List of 28 places 'to visit before you die.' The house has undergone several restorations to address structural issues and preserve its unique design.",
                IsRegistered = true,
                UserId = 2,
                StyleId = 5, // Modern
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/b/bc/Fallingwater3.jpg"
            },
            new Building
            {
                BuildingId = 36,
                Name = "Independence Hall",
                Location = "Philadelphia, Pennsylvania, USA",
                YearBuilt = "1753",
                Description = "Independence Hall is the building where both the United States Declaration of Independence and the United States Constitution were debated and adopted. It is now the centerpiece of the Independence National Historical Park in Philadelphia. The building was completed in 1753 as the Pennsylvania State House and has undergone numerous restorations to preserve its historical significance. It was designated a UNESCO World Heritage Site in 1979.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 10, // Colonial
                ImageURL = "https://www.nps.gov/npgallery/GetAsset/B6F0257A-155D-451F-67E68FF4C2857CBC/proxy/hires"
            },
            new Building
            {
               BuildingId = 37,
               Name = "Ponce City Market",
               Location = "Atlanta, Georgia, USA",
               YearBuilt = "1926",
               Description = "Ponce City Market is a historic building in Atlanta, Georgia, originally built in 1926 as a Sears, Roebuck & Co. retail store, warehouse, and regional office. The building was redeveloped into a mixed-use development with retail, office, and residential spaces. The market is now a popular destination, known for its food hall, rooftop amusement park, and vibrant community events. The building retains much of its original architectural charm while integrating modern amenities.",
               IsRegistered = true,
               UserId = 1,
               StyleId = 3, // Neoclassical
               ImageURL = "https://www.usatoday.com/gcdn/-mm-/9b672afbff70f4ed5282300f9ead266fd2f1b2ff/c=0-530-5753-3780/local/-/media/2017/02/16/USATODAY/USATODAY/636228441313700346-2.-Sarah-Dorio-.jpg"
            },
            new Building
            {
                BuildingId = 38,
                Name = "Monticello",
                Location = "Charlottesville, Virginia, USA",
                YearBuilt = "1772",
                Description = "Monticello was the primary plantation of Thomas Jefferson, the third President of the United States, who began designing and building Monticello at age 26 after inheriting land from his father. Located just outside Charlottesville, Virginia, the plantation was originally 5,000 acres, with Jefferson using the work of enslaved Africans for extensive cultivation of tobacco and mixed crops, later shifting from tobacco cultivation to wheat in response to changing markets. Monticello has been designated a UNESCO World Heritage Site and has undergone extensive restoration to preserve its historical significance.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 15, // Classical
                ImageURL = "https://assets.simpleviewinc.com/simpleview/image/upload/c_limit,q_75,w_1200/v1/crm/virginia/West-Front_Monticello-JLooney-26aug2013-0056_work_1ba264ab-5056-a36a-07fad3b0accc7d92.jpg"
            },
            new Building
            {
                BuildingId = 39,
                Name = "Smithsonian Institution Building",
                Location = "Washington, D.C., USA",
                YearBuilt = "1855",
                Description = "The Smithsonian Institution Building, commonly known as 'The Castle,' is a distinctive landmark in Washington, D.C., on the National Mall. The building was completed in 1855 and serves as the headquarters for the Smithsonian Institution. It was designed by architect James Renwick Jr. in the Norman style, featuring red Seneca sandstone. The Castle has undergone several restorations, including major work in the 1960s to address structural issues and improve accessibility. The building remains an iconic symbol of the Smithsonian and hosts administrative offices, a visitor center, and various exhibits.",
                IsRegistered = true,
                UserId = 2,
                StyleId = 14, // Gothic Revival
                ImageURL = "https://i.pinimg.com/originals/28/4c/83/284c83d9b427237f461b416ae224c6d3.jpg"
            },
            new Building
            {
                BuildingId = 40,
                Name = "California State Capitol",
                Location = "Sacramento, California, USA",
                YearBuilt = "1874",
                Description = "The California State Capitol is home to the government of California, located in Sacramento. Completed in 1874, the building houses the chambers of the California State Legislature. Its neoclassical architecture draws inspiration from the United States Capitol in Washington, D.C. The building underwent extensive renovations from 1975 to 1982 to address seismic concerns and preserve its historical features. It is both a working government building and a museum, open to visitors who can explore its historic chambers and exhibits on California history.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 3, // Neoclassical
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/5/5a/Sacramento%2C-California---State-Capitol.jpg"
            },
            new Building
            {
                BuildingId = 41,
                Name = "Golden Gate Bridge",
                Location = "San Francisco, California, USA",
                YearBuilt = "1937",
                Description = "The Golden Gate Bridge is a suspension bridge spanning the Golden Gate, the strait connecting San Francisco Bay and the Pacific Ocean. Completed in 1937, the bridge was the longest and tallest suspension bridge in the world at the time. It has undergone numerous maintenance and retrofit projects to ensure its safety and longevity, including seismic upgrades to withstand earthquakes. The bridge is an internationally recognized symbol of San Francisco and the United States.",
                IsRegistered = true,
                UserId = 2,
                StyleId = 10, // Colonial (as a category for historic landmarks)
                ImageURL = "https://static.toiimg.com/thumb/msid-44848107,width=1200,height=900/44848107.jpg"
            },
            new Building
            {
                BuildingId = 42,
                Name = "Empire State Plaza",
                Location = "Albany, New York, USA",
                YearBuilt = "1965-1976",
                Description = "The Empire State Plaza, also known as the South Mall, is a complex of several state government buildings in downtown Albany, New York. It was built between 1965 and 1976 at the behest of Governor Nelson Rockefeller and was designed by architect Wallace Harrison. The complex is known for its modern architecture, featuring a series of reflective pools, an art collection, and the distinctive Corning Tower. The plaza has been the subject of various renovations to maintain its infrastructure and enhance its public spaces.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 5, // Modern
                ImageURL = "https://empirestateplaza.ny.gov/sites/g/files/oee991/files/media/2019/06/ESP%2002%20%202016.jpg"
            },
            new Building
            {
                BuildingId = 43,
                Name = "Walt Disney Concert Hall",
                Location = "Los Angeles, California, USA",
                YearBuilt = "2003",
                Description = "The Walt Disney Concert Hall is a concert hall located in Los Angeles, California. Designed by Frank Gehry, the hall opened in 2003 and is home to the Los Angeles Philharmonic. Known for its striking stainless steel exterior and superior acoustics, the building has become an architectural landmark. The concert hall's construction was part of a larger revitalization effort in downtown Los Angeles, and it continues to draw visitors for both its design and performances.",
                IsRegistered = false,
                UserId = 1,
                StyleId = 5, // Modern
                ImageURL = "https://ucarecdn.com/ba8baa7b-7442-46ef-b7fd-079d31b8f907/"
            },
            new Building
            {
                BuildingId = 44,
                Name = "Graceland",
                Location = "Memphis, Tennessee, USA",
                YearBuilt = "1939",
                Description = "Graceland is the former home of Elvis Presley, located in Memphis, Tennessee. The mansion was built in 1939 and purchased by Presley in 1957. It is now a museum dedicated to the life and career of the King of Rock and Roll. Graceland has undergone numerous renovations to preserve its original features and accommodate the millions of fans who visit each year. It was designated a National Historic Landmark in 2006.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 8, // Victorian
                ImageURL = "https://people.com/thmb/9Y_z3LqYXuIqxPeUyh-162lBTD0=/4000x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(989x0:991x2)/graceland-3-57ec3be7857c46d7ac42c47e4b90c525.jpg"
            },
            new Building
            {
                BuildingId = 45,
                Name = "One World Trade Center",
                Location = "New York City, USA",
                YearBuilt = "2014",
                Description = "One World Trade Center, also known as the Freedom Tower, is the main building of the rebuilt World Trade Center complex in Lower Manhattan. It is the tallest building in the Western Hemisphere, standing at 1,776 feet. The building opened in 2014 and includes state-of-the-art sustainable design features. Its construction is a symbol of resilience and renewal following the September 11 attacks. The building is a key component of the new World Trade Center and a popular tourist attraction with its observation deck offering panoramic views of New York City.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 5, // Modern
                ImageURL = "https://visualhouse.com/wp-content/uploads/2023/10/SE001-3-2WTC-S010_Aerial-Classic-Skyline_R01-scaled.jpg"
            },
            new Building
            {
                BuildingId = 46,
                Name = "Smith Tower",
                Location = "Seattle, Washington, USA",
                YearBuilt = "1914",
                Description = "Smith Tower is a skyscraper in Pioneer Square in Seattle, Washington. Completed in 1914, it is one of the oldest skyscrapers in the city and was the tallest building west of the Mississippi River at the time of its completion. The building is named after its builder, firearm and typewriter magnate Lyman Cornelius Smith. The tower features a Chinese Room on its 35th floor, which was a gift from the Empress of China. Smith Tower has undergone significant renovations to maintain its historical charm and modernize its facilities, including seismic retrofitting and interior restorations.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 4, // Art Deco
                ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHhotND4PVf-oKsMm90U2HGVtIlFM_-6nGyA&s"
            },
            new Building
            {
                BuildingId = 47,
                Name = "Space Needle",
                Location = "Seattle, Washington, USA",
                YearBuilt = "1962",
                Description = "The Space Needle is an observation tower in Seattle, Washington, a landmark of the Pacific Northwest, and an icon of Seattle. It was built for the 1962 World's Fair, which drew over 2.3 million visitors. The tower is 605 feet high, and was the tallest structure west of the Mississippi River at the time of its completion. The Space Needle has undergone several renovations, including the addition of The Loupe, the world's first and only revolving glass floor, which offers visitors a unique perspective of the city below.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 5, // Modern
                ImageURL = "https://images.inc.com/uploaded_files/image/1920x1080/getty_180262211_372628.jpg"
            },
            new Building
            {
                BuildingId = 48,
                Name = "Hollywood Bowl",
                Location = "Los Angeles, California, USA",
                YearBuilt = "1922",
                Description = "The Hollywood Bowl is an amphitheater in the Hollywood Hills neighborhood of Los Angeles, California. It is known for its distinctive band shell, set against the backdrop of the Hollywood Hills and the famous Hollywood Sign. The Bowl opened in 1922 and has hosted performances by many of the world's greatest artists and musicians. The venue has undergone numerous renovations to enhance its acoustics and visitor experience, including updates to seating, stage facilities, and infrastructure.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 8, // Victorian (as an older style)
                ImageURL = "https://archello.s3.eu-central-1.amazonaws.com/images/2016/09/14/01-Hollywood-Bowl2.1506082370.5043.jpg"
            },
            new Building
            {
                BuildingId = 49,
                Name = "Brooklyn Bridge",
                Location = "New York City, USA",
                YearBuilt = "1883",
                Description = "The Brooklyn Bridge is a hybrid cable-stayed/suspension bridge in New York City. Completed in 1883, it connects the boroughs of Manhattan and Brooklyn, spanning the East River. Designed by John A. Roebling, the bridge was the longest suspension bridge in the world at the time of its completion. Over the years, it has undergone several renovations, including structural reinforcements and deck replacements to accommodate modern traffic loads. The bridge remains an iconic symbol of New York City and a National Historic Landmark.",
                IsRegistered = true,
                UserId = 1,
                StyleId = 10, // Colonial (as a category for historic landmarks)
                ImageURL = "https://cdn.britannica.com/80/115080-050-46BE2B70/Brooklyn-Bridge-East-River-New-York-City.jpg"
            },
            new Building
            {
                BuildingId = 50,
                Name = "One Vanderbilt",
                Location = "New York City, USA",
                YearBuilt = "2020",
                Description = "One Vanderbilt is a skyscraper in New York City, located next to Grand Central Terminal in Midtown Manhattan. It opened in 2020 and is one of the tallest buildings in the city, standing at 1,401 feet. The building features a mix of office spaces and an observation deck offering panoramic views of the city. One Vanderbilt is known for its modern design and sustainable features, including energy-efficient systems and materials. It was developed as part of a larger effort to revitalize the area around Grand Central Terminal.",
                IsRegistered = false,
                UserId = 2,
                StyleId = 5, // Modern
                ImageURL = "https://images.ctfassets.net/1aemqu6a6t65/3JLGCDXjGEKQj99cIiuvud/2eb328c086cbb0c6cf82ff212049414d/summit_exterior_a91efcdd-e85b-499c-8606929d6afb92a4_2801c287-9590-4001-b9d05090cfa796d4?w=1200&h=800&q=75"
            }
        };
    }
}    
