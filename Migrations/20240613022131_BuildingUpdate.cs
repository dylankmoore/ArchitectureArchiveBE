using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArchitectureArchiveBE.Migrations
{
    public partial class BuildingUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 1,
                column: "IsRegistered",
                value: false);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 14,
                column: "ImageURL",
                value: "https://www.worldhistory.org/uploads/images/3372.jpg");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 17,
                column: "ImageURL",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/Dawn_Charles_V_Palace_Alhambra_Granada_Andalusia_Spain.jpg/640px-Dawn_Charles_V_Palace_Alhambra_Granada_Andalusia_Spain.jpg");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 19,
                column: "ImageURL",
                value: "https://projects.iq.harvard.edu/sites/projects.iq.harvard.edu/files/styles/os_files_xxlarge/public/whoseculture/files/hagia_sophia_exterior.jpg?m=1607399097&itok=xge9nGpj");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 25,
                column: "ImageURL",
                value: "https://imageio.forbes.com/specials-images/imageserve/6581c576d696b57bec66c63f/0x0.jpg?format=jpg&crop=1477,830,x0,y38,safe&height=900&width=1600&fit=bounds");

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "BuildingId", "Description", "ImageURL", "IsRegistered", "Location", "Name", "StyleId", "UserId", "YearBuilt" },
                values: new object[,]
                {
                    { 31, "The Transamerica Pyramid is a 48-story futurist skyscraper in San Francisco, California, and is the second tallest building in the city. Completed in 1972, the building was designed by architect William Pereira and is characterized by its unique pyramid shape. The building underwent a significant renovation in 1995 to update its mechanical systems and improve earthquake resistance. The Transamerica Pyramid remains an iconic symbol of San Francisco's skyline.", "https://cdn.britannica.com/34/250234-050-913C1878/San-Francisco-California-Transamerica-Pyramid-building.jpg", false, "San Francisco, California, USA", "Transamerica Pyramid", 5, 2, "1972" },
                    { 32, "Union Station in Washington, D.C., designed by architect Daniel Burnham and completed in 1907, is a notable example of Beaux-Arts architecture. The station features a grand Great Hall with a coffered ceiling, gold leaf detailing, and large arched windows. Initially a critical transportation hub for visitors and military operations during both World Wars, the station fell into disrepair by the 1960s and was nearly demolished. A major restoration in the 1980s preserved its historical features while modernizing facilities, including the repair of the Great Hall’s ceiling and the addition of retail and dining spaces. Further rehabilitation projects in the 2010s addressed structural concerns and enhanced capacity and accessibility. Today, Union Station serves millions of travelers annually through Amtrak, MARC, and VRE commuter rail services, as well as local and intercity buses. It remains a functional transit hub and a historic landmark, reflecting early 20th-century architectural grandeur and historical significance.", "https://media.cntraveler.com/photos/55d660df37284fb1079d1ea6/16:9/w_2560,c_limit/union-station-hotel-nashville-exterior.jpg", true, "Washington, D.C., USA", "Union Station", 3, 1, "1907" },
                    { 33, "Hearst Castle is a National Historic Landmark and California Historical Landmark located on the Central Coast of California. Designed by architect Julia Morgan for newspaper magnate William Randolph Hearst, the castle was built between 1919 and 1947. The estate includes a main house, guest houses, pools, and extensive gardens. Hearst Castle has been maintained as a museum since 1958, and it attracts millions of visitors each year. Restoration efforts have focused on preserving its opulent interiors and architectural features.", "https://cdn.britannica.com/27/183127-050-B1360DCB/Hearst-Castle-California-San-Simeon-Julia-Morgan.jpg", true, "San Simeon, California, USA", "Hearst Castle", 7, 2, "1919" },
                    { 34, "The Biltmore Estate is a historic house museum and tourist attraction in Asheville, North Carolina. Built for George Washington Vanderbilt II and completed in 1895, it is the largest privately-owned house in the United States. The mansion features Châteauesque architecture and is surrounded by extensive gardens designed by Frederick Law Olmsted. The estate has undergone numerous renovations to preserve its historical integrity and accommodate visitors. It remains a popular destination for its architecture, gardens, and historical significance.", "https://upload.wikimedia.org/wikipedia/commons/c/cd/Biltmore_Estate%2C_Asheville%2C_North_Carolina.jpg", true, "Asheville, North Carolina, USA", "Biltmore Estate", 8, 1, "1895" },
                    { 35, "Fallingwater is a house designed by architect Frank Lloyd Wright in 1935 in rural southwestern Pennsylvania. The house was built partly over a waterfall on Bear Run in the Mill Run section of Stewart Township, Fayette County. It is one of Wright's most famous works and was designated a National Historic Landmark in 1966. Fallingwater was listed among Smithsonian's Life List of 28 places 'to visit before you die.' The house has undergone several restorations to address structural issues and preserve its unique design.", "https://upload.wikimedia.org/wikipedia/commons/b/bc/Fallingwater3.jpg", true, "Mill Run, Pennsylvania, USA", "Fallingwater", 5, 2, "1937" },
                    { 36, "Independence Hall is the building where both the United States Declaration of Independence and the United States Constitution were debated and adopted. It is now the centerpiece of the Independence National Historical Park in Philadelphia. The building was completed in 1753 as the Pennsylvania State House and has undergone numerous restorations to preserve its historical significance. It was designated a UNESCO World Heritage Site in 1979.", "https://www.nps.gov/npgallery/GetAsset/B6F0257A-155D-451F-67E68FF4C2857CBC/proxy/hires", true, "Philadelphia, Pennsylvania, USA", "Independence Hall", 10, 1, "1753" },
                    { 37, "Ponce City Market is a historic building in Atlanta, Georgia, originally built in 1926 as a Sears, Roebuck & Co. retail store, warehouse, and regional office. The building was redeveloped into a mixed-use development with retail, office, and residential spaces. The market is now a popular destination, known for its food hall, rooftop amusement park, and vibrant community events. The building retains much of its original architectural charm while integrating modern amenities.", "https://www.usatoday.com/gcdn/-mm-/9b672afbff70f4ed5282300f9ead266fd2f1b2ff/c=0-530-5753-3780/local/-/media/2017/02/16/USATODAY/USATODAY/636228441313700346-2.-Sarah-Dorio-.jpg", true, "Atlanta, Georgia, USA", "Ponce City Market", 3, 1, "1926" },
                    { 38, "Monticello was the primary plantation of Thomas Jefferson, the third President of the United States, who began designing and building Monticello at age 26 after inheriting land from his father. Located just outside Charlottesville, Virginia, the plantation was originally 5,000 acres, with Jefferson using the work of enslaved Africans for extensive cultivation of tobacco and mixed crops, later shifting from tobacco cultivation to wheat in response to changing markets. Monticello has been designated a UNESCO World Heritage Site and has undergone extensive restoration to preserve its historical significance.", "https://assets.simpleviewinc.com/simpleview/image/upload/c_limit,q_75,w_1200/v1/crm/virginia/West-Front_Monticello-JLooney-26aug2013-0056_work_1ba264ab-5056-a36a-07fad3b0accc7d92.jpg", true, "Charlottesville, Virginia, USA", "Monticello", 15, 1, "1772" },
                    { 39, "The Smithsonian Institution Building, commonly known as 'The Castle,' is a distinctive landmark in Washington, D.C., on the National Mall. The building was completed in 1855 and serves as the headquarters for the Smithsonian Institution. It was designed by architect James Renwick Jr. in the Norman style, featuring red Seneca sandstone. The Castle has undergone several restorations, including major work in the 1960s to address structural issues and improve accessibility. The building remains an iconic symbol of the Smithsonian and hosts administrative offices, a visitor center, and various exhibits.", "https://i.pinimg.com/originals/28/4c/83/284c83d9b427237f461b416ae224c6d3.jpg", true, "Washington, D.C., USA", "Smithsonian Institution Building", 14, 2, "1855" },
                    { 40, "The California State Capitol is home to the government of California, located in Sacramento. Completed in 1874, the building houses the chambers of the California State Legislature. Its neoclassical architecture draws inspiration from the United States Capitol in Washington, D.C. The building underwent extensive renovations from 1975 to 1982 to address seismic concerns and preserve its historical features. It is both a working government building and a museum, open to visitors who can explore its historic chambers and exhibits on California history.", "https://upload.wikimedia.org/wikipedia/commons/5/5a/Sacramento%2C-California---State-Capitol.jpg", true, "Sacramento, California, USA", "California State Capitol", 3, 1, "1874" },
                    { 41, "The Golden Gate Bridge is a suspension bridge spanning the Golden Gate, the strait connecting San Francisco Bay and the Pacific Ocean. Completed in 1937, the bridge was the longest and tallest suspension bridge in the world at the time. It has undergone numerous maintenance and retrofit projects to ensure its safety and longevity, including seismic upgrades to withstand earthquakes. The bridge is an internationally recognized symbol of San Francisco and the United States.", "https://upload.wikimedia.org/wikipedia/commons/b/bf/Golden_Gate_Bridge_as_seen_from_Battery_East.jpgg", true, "San Francisco, California, USA", "Golden Gate Bridge", 10, 2, "1937" },
                    { 42, "The Empire State Plaza, also known as the South Mall, is a complex of several state government buildings in downtown Albany, New York. It was built between 1965 and 1976 at the behest of Governor Nelson Rockefeller and was designed by architect Wallace Harrison. The complex is known for its modern architecture, featuring a series of reflective pools, an art collection, and the distinctive Corning Tower. The plaza has been the subject of various renovations to maintain its infrastructure and enhance its public spaces.", "https://empirestateplaza.ny.gov/sites/g/files/oee991/files/media/2019/06/ESP%2002%20%202016.jpg", false, "Albany, New York, USA", "Empire State Plaza", 5, 1, "1965-1976" },
                    { 43, "The Walt Disney Concert Hall is a concert hall located in Los Angeles, California. Designed by Frank Gehry, the hall opened in 2003 and is home to the Los Angeles Philharmonic. Known for its striking stainless steel exterior and superior acoustics, the building has become an architectural landmark. The concert hall's construction was part of a larger revitalization effort in downtown Los Angeles, and it continues to draw visitors for both its design and performances.", "https://ucarecdn.com/ba8baa7b-7442-46ef-b7fd-079d31b8f907/", false, "Los Angeles, California, USA", "Walt Disney Concert Hall", 5, 1, "2003" },
                    { 44, "Graceland is the former home of Elvis Presley, located in Memphis, Tennessee. The mansion was built in 1939 and purchased by Presley in 1957. It is now a museum dedicated to the life and career of the King of Rock and Roll. Graceland has undergone numerous renovations to preserve its original features and accommodate the millions of fans who visit each year. It was designated a National Historic Landmark in 2006.", "https://people.com/thmb/9Y_z3LqYXuIqxPeUyh-162lBTD0=/4000x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(989x0:991x2)/graceland-3-57ec3be7857c46d7ac42c47e4b90c525.jpg", true, "Memphis, Tennessee, USA", "Graceland", 8, 1, "1939" },
                    { 45, "One World Trade Center, also known as the Freedom Tower, is the main building of the rebuilt World Trade Center complex in Lower Manhattan. It is the tallest building in the Western Hemisphere, standing at 1,776 feet. The building opened in 2014 and includes state-of-the-art sustainable design features. Its construction is a symbol of resilience and renewal following the September 11 attacks. The building is a key component of the new World Trade Center and a popular tourist attraction with its observation deck offering panoramic views of New York City.", "https://visualhouse.com/wp-content/uploads/2023/10/SE001-3-2WTC-S010_Aerial-Classic-Skyline_R01-scaled.jpg", false, "New York City, USA", "One World Trade Center", 5, 2, "2014" },
                    { 46, "Smith Tower is a skyscraper in Pioneer Square in Seattle, Washington. Completed in 1914, it is one of the oldest skyscrapers in the city and was the tallest building west of the Mississippi River at the time of its completion. The building is named after its builder, firearm and typewriter magnate Lyman Cornelius Smith. The tower features a Chinese Room on its 35th floor, which was a gift from the Empress of China. Smith Tower has undergone significant renovations to maintain its historical charm and modernize its facilities, including seismic retrofitting and interior restorations.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHhotND4PVf-oKsMm90U2HGVtIlFM_-6nGyA&s", true, "Seattle, Washington, USA", "Smith Tower", 4, 1, "1914" },
                    { 47, "The Space Needle is an observation tower in Seattle, Washington, a landmark of the Pacific Northwest, and an icon of Seattle. It was built for the 1962 World's Fair, which drew over 2.3 million visitors. The tower is 605 feet high, and was the tallest structure west of the Mississippi River at the time of its completion. The Space Needle has undergone several renovations, including the addition of The Loupe, the world's first and only revolving glass floor, which offers visitors a unique perspective of the city below.", "https://images.inc.com/uploaded_files/image/1920x1080/getty_180262211_372628.jpg", false, "Seattle, Washington, USA", "Space Needle", 5, 2, "1962" },
                    { 48, "The Hollywood Bowl is an amphitheater in the Hollywood Hills neighborhood of Los Angeles, California. It is known for its distinctive band shell, set against the backdrop of the Hollywood Hills and the famous Hollywood Sign. The Bowl opened in 1922 and has hosted performances by many of the world's greatest artists and musicians. The venue has undergone numerous renovations to enhance its acoustics and visitor experience, including updates to seating, stage facilities, and infrastructure.", "https://www.discoverlosangeles.com/sites/default/files/styles/hero/public/images/2019-01/Hollywood%20Bowl%20%28Photo%20courtesy%20of%20Los%20Angeles%20Philharmonic%2C%20by%20Adam%20Latham%29.jpg", true, "Los Angeles, California, USA", "Hollywood Bowl", 8, 1, "1922" },
                    { 49, "The Brooklyn Bridge is a hybrid cable-stayed/suspension bridge in New York City. Completed in 1883, it connects the boroughs of Manhattan and Brooklyn, spanning the East River. Designed by John A. Roebling, the bridge was the longest suspension bridge in the world at the time of its completion. Over the years, it has undergone several renovations, including structural reinforcements and deck replacements to accommodate modern traffic loads. The bridge remains an iconic symbol of New York City and a National Historic Landmark.", "https://cdn.britannica.com/80/115080-050-46BE2B70/Brooklyn-Bridge-East-River-New-York-City.jpg", true, "New York City, USA", "Brooklyn Bridge", 10, 1, "1883" },
                    { 50, "One Vanderbilt is a skyscraper in New York City, located next to Grand Central Terminal in Midtown Manhattan. It opened in 2020 and is one of the tallest buildings in the city, standing at 1,401 feet. The building features a mix of office spaces and an observation deck offering panoramic views of the city. One Vanderbilt is known for its modern design and sustainable features, including energy-efficient systems and materials. It was developed as part of a larger effort to revitalize the area around Grand Central Terminal.", "https://images.ctfassets.net/1aemqu6a6t65/3JLGCDXjGEKQj99cIiuvud/2eb328c086cbb0c6cf82ff212049414d/summit_exterior_a91efcdd-e85b-499c-8606929d6afb92a4_2801c287-9590-4001-b9d05090cfa796d4?w=1200&h=800&q=75", false, "New York City, USA", "One Vanderbilt", 5, 2, "2020" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 1,
                column: "IsRegistered",
                value: true);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 14,
                column: "ImageURL",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ65cjJfLBLMt2NbajpkgCyMJ8QNoTyP3op5xySIzzf1Q&s");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 17,
                column: "ImageURL",
                value: "https://simple.wikipedia.org/wiki/Alhambra#/media/File:Dawn_Charles_V_Palace_Alhambra_Granada_Andalusia_Spain.jpg");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 19,
                column: "ImageURL",
                value: "https://upload.wikimedia.org/wikipedia/commons/a/a0/Hagia_Sophia_Mars_2013.jpg");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 25,
                column: "ImageURL",
                value: "https://upload.wikimedia.org/wikipedia/commons/9/94/Chrysler_Building_Midtown_Manhattan_New_York_City_2.jpghttps://chryslerbuilding.com/wp-content/uploads/2020/05/building-1-scaled.jpg");
        }
    }
}
