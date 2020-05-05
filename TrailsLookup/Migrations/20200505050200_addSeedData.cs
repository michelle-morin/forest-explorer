using Microsoft.EntityFrameworkCore.Migrations;

namespace TrailsLookup.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trails",
                columns: new[] { "TrailId", "FirstAdjoiningSegment1", "FirstAdjoiningSegment2", "FirstAdjoiningSegment3", "FirstAdjoiningSegment4", "GeoObjNumber", "Miles", "Name", "SecondAdjoiningSegment1", "SecondAdjoiningSegment2", "SecondAdjoiningSegment3", "SecondAdjoiningSegment4", "Surface", "Type" },
                values: new object[,]
                {
                    { 1, 1, null, null, null, 86, 0.46732678999999999, "Wildwood Trail", 1326, 686, 1995, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 208, 615, 1008, null, null, 1082, 0.36204857000000001, "Tolinda Trail", 1089, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 207, 0, null, null, null, 1224, 0.35324745000000002, "NW Springville Road", 2115, null, null, null, "asphalt", "on-street trail shared by bikes, pedestrians, and vehicles" },
                    { 206, 1564, null, null, null, 2115, 0.11231007, "Springville Road", 1224, null, null, null, "gravel", "Trail/Path (>20 ft.)" },
                    { 205, 2115, null, null, null, 1564, 0.29645216000000002, "Springville Road", 636, 645, 1107, null, "gravel", "Trail/Path (>20 ft.)" },
                    { 204, 1107, 2495, null, null, 615, 0.028358870000000001, "Leif Erikson Drive", 1082, 1008, null, null, "gravel", "Maintenance Road" },
                    { 203, 2495, 615, null, null, 1107, 0.80686237999999999, "Leif Erikson Drive", 645, 636, 1564, null, "gravel", "Maintenance Road" },
                    { 202, 1090, null, null, null, 2495, 0.0892482, "Water Line Trail", 1107, 615, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 201, 890, 1256, 1009, null, 1090, 0.26020434999999997, "Water Line Trail", 2495, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 200, 1986, null, null, null, 1256, 0.33834174, "Water Line Trail", 890, 1090, 1009, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 199, 0, null, null, null, 1986, 0.072870229999999994, "Water Line Trail", 1256, null, null, null, "gravel", "Trail/Path (6-12 ft.)" },
                    { 198, 676, 645, 1558, null, 890, 1.5218384300000001, "Wildwood Trail", 1256, 1009, 1090, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 197, 636, 1564, 1107, null, 645, 0.36793975000000001, "Springville Road", 890, 676, 1558, null, "gravel", "Trail/Path (>20 ft.)" },
                    { 196, 646, 648, null, null, 636, 0.37527102000000001, "Leif Erikson Drive", 1564, 1107, 645, null, "gravel", "Maintenance Road" },
                    { 195, 1559, 566, null, null, 676, 0.32682984999999998, "Springville Road", 1558, 645, 890, null, "gravel", "Trail/Path (>20 ft.)" },
                    { 194, 1557, null, null, null, 1558, 0.22950665000000001, "Wildwood Trail", 676, 890, 645, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 209, 1082, null, null, null, 1089, 0.36644645999999997, "Tolinda Trail", 0, null, null, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 193, 1558, null, null, null, 1557, 0.54090316000000005, "Wildwood Trail", 649, 1566, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 210, 1256, 890, 1090, null, 1009, 0.56511718, "Wildwood Trail", 1531, 1537, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 212, 1008, 1749, null, null, 1750, 0.026157139999999999, "Leif Erikson trailhead parking area", 24, 1536, null, null, "gravel bike/ped/vehicle share", "Maintenance Road" },
                    { 227, 1223, 532, null, null, 711, 0.32141841999999998, "Wildwood Trail", 349, 533, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 226, 1516, 1373, null, null, 1223, 0.17570015, "Firelane 8", 711, 532, null, null, "soil", "Firelane" },
                    { 225, 2501, null, null, null, 2492, 0.21395221, "Firelane 9", 1748, 1536, 534, null, "soil", "Firelane" },
                    { 224, 1081, null, null, null, 2501, 0.14559164999999999, "Firelane 9", 2492, null, null, null, "soil", "Firelane" },
                    { 223, 1517, null, null, null, 1081, 0.16404352, "Firelane 9", 2501, null, null, null, "soil", "Firelane" },
                    { 222, 1998, null, null, null, 1517, 0.030904299999999999, "Firelane 9", 1081, null, null, null, "soil", "Firelane" },
                    { 221, 0, null, null, null, 1998, 0.09199367, "NW Mackay Ave.", 1517, null, null, null, "asphalt", "Trail/Path (6-12 ft.)" },
                    { 220, 1538, 1532, null, null, 564, 0.0046465999999999999, "Wildwood Trail", 349, 1373, null, null, "asphalt", "on-street trail, road shoulder" },
                    { 219, 1537, 24, null, null, 1538, 0.02375008, "Cannon trail", 564, 1532, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 218, 1531, null, null, null, 1532, 0.019817060000000001, "Wildwood Trail", 564, 1538, null, null, "asphalt", "on-street trail, road shoulder" },
                    { 217, 1532, null, null, null, 1531, 0.053264319999999997, "Wildwood Trail", 1009, 1537, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 216, 24, 1538, null, null, 1537, 0.020529849999999999, "Cannon Trail", 1531, 1009, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 215, 1750, 1536, null, null, 24, 0.27320843, "Cannon trail", 1537, 1538, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 214, 24, 1750, null, null, 1536, 0.016746480000000001, "Leif Erikson trailhead parking area", 1748, 2492, 534, null, "gravel bike/ped/vehicle share", "Maintenance Road" },
                    { 213, 1008, 1750, null, null, 1749, 0.042011029999999998, "Leif Erikson trailhead parking area", 1748, 1747, null, null, "gravel bike/ped/vehicle share", "Maintenance Road" },
                    { 211, 615, 1082, null, null, 1008, 0.99624097, "Leif Erikson Drive", 1749, 1750, null, null, "gravel", "Maintenance Road" },
                    { 228, 1223, 711, null, null, 532, 0.41411579999999998, "Wildwood Trail", 1328, 505, 1327, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 192, 673, 1559, null, null, 649, 0.26054873000000001, "Hardesty Trail", 1566, 1557, null, null, "gravel", "Trail/Path (1-3 ft.)" },
                    { 190, 1565, 648, null, null, 1566, 0.037605020000000003, "Wildwood Trail", 649, 1557, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 170, 2120, null, null, null, 2041, 0.30452618999999997, "Firelane 7A", 0, null, null, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 169, 2042, null, null, null, 2120, 0.063328010000000004, "Firelane 7A", 2041, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 168, 668, 1570, 1576, null, 2042, 0.22436332, "Firelane 7A", 2120, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 167, 1577, 1575, null, null, 1576, 0.28568726, "Leif Erikson Drive", 1570, 668, 2042, null, "gravel", "Maintenance Road" },
                    { 166, 0, null, null, null, 566, 0.21714843, "Springville Road", 1559, 676, null, null, "gravel", "Trail/Path (>20 ft.)" },
                    { 165, 673, 649, null, null, 1559, 0.11845094, "Firelane 7", 566, 676, null, null, "gravel", "Firelane" },
                    { 164, 423, 680, null, null, 673, 0.060414839999999997, "Firelane 7", 1559, 649, null, null, "soil", "Firelane" },
                    { 163, 2494, null, null, null, 1575, 0.090201569999999995, "Oil Line access", 1577, 1576, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 162, 396, 2493, 675, null, 2494, 0.067841589999999993, "Oil Line access", 1575, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 161, 681, null, null, null, 2493, 0.081267619999999999, "Oil Line Road", 396, 675, 2494, null, "soil", "Maintenance Road" },
                    { 160, 424, 670, null, null, 681, 0.25617670999999997, "Oil Line Road", 2493, null, null, null, "soil", "Maintenance Road" },
                    { 159, 423, 672, null, null, 424, 0.28632444000000001, "Firelane 7", 670, 681, null, null, "soil", "Firelane" },
                    { 158, 680, 673, null, null, 423, 0.18037420000000001, "Firelane 7", 424, 672, null, null, "soil", "Firelane" },
                    { 157, 1464, 396, null, null, 680, 0.22555673000000001, "Trillium trail", 423, 673, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 156, 1464, 680, null, null, 396, 0.84125183999999997, "Wildwood Trail", 2494, 2493, 675, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 171, 2042, 1576, 1570, null, 668, 0.051772239999999997, "Leif Erikson Drive", 669, 1571, null, null, "gravel", "Maintenance Road" },
                    { 191, 1565, 1566, null, null, 648, 0.26106886000000001, "Hardesty Trail", 646, 636, null, null, "gravel", "Trail/Path (1-3 ft.)" },
                    { 172, 2042, 1576, 668, null, 1570, 0.040619370000000002, "Firelane 7A", 669, 1569, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 174, 1570, 669, null, null, 1569, 0.057642199999999998, "Firelane 7A", 1568, 1567, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 189, 568, 671, 672, null, 1565, 0.75723320999999999, "Wildwood Trail", 1566, 648, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 188, 931, 1572, 568, null, 646, 0.55199299000000002, "Leif Erikson Drive", 648, 636, null, null, "gravel", "Maintenance Road" },
                    { 187, 0, null, null, null, 640, 0.14702116000000001, "Ridge Trail", 639, 931, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 186, 0, null, null, null, 643, 0.063938380000000003, "Ridge Trail", 639, null, null, null, "asphalt", "Trail/Path (5-6 ft.)" },
                    { 185, 931, 640, null, null, 639, 0.12023737, "Ridge Trail", 643, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 184, 646, 568, 1572, null, 931, 0.46846303, "Ridge Trail", 639, 640, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 183, 668, 669, null, null, 1571, 0.087441720000000001, "Leif Erikson Drive", 1567, 1572, null, null, "gravel", "Maintenance Road" },
                    { 182, 1568, 1569, null, null, 1567, 0.11087677999999999, "Leif-Firelane 7A Connector", 1571, 1572, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 181, 1571, 1567, null, null, 1572, 0.41819003999999999, "Leif Erikson Drive", 931, 646, 568, null, "gravel", "Maintenance Road" },
                    { 180, 1565, 672, 671, null, 568, 0.29311984000000002, "Ridge Trail", 646, 931, 1572, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 179, 568, 671, 1565, null, 672, 0.43397790000000003, "Ridge Trail", 424, 423, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 178, 1568, 675, 670, null, 671, 0.90530124000000001, "Wildwood Trail", 568, 1565, 672, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 177, 671, 1568, 675, null, 670, 0.32631599, "Firelane 7A", 681, 424, null, null, "soil", "Firelane" },
                    { 176, 2494, 396, 2493, null, 675, 0.53002707000000004, "Wildwood Trail", 670, 671, 1568, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 175, 1569, 1567, null, null, 1568, 0.12961364, "Firelane 7A", 675, 670, 671, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 173, 668, 1571, null, null, 669, 0.047358079999999997, "Leif-Firelane 7A Connector", 1570, 1569, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 229, 0, null, null, null, 1985, 0.38356544999999997, "Newton Road", 1328, 708, 560, null, "gravel", "Maintenance Road" },
                    { 230, 1985, 708, 560, null, 1328, 0.1499373, "Firelane 10", 532, 1327, 505, null, "soil", "Firelane" },
                    { 231, 505, 1328, 532, null, 1327, 0.10375415, "Firelane 10", 1325, 182, null, null, "soil", "Firelane" },
                    { 285, 0, null, null, null, 1981, 0.0071846999999999996, "Firelane 15 Parking", 1980, 87, null, null, "gravel", "Firelane" },
                    { 284, 1981, 87, null, null, 1980, 0.097449010000000003, "Dunbar - Firelane 15 connector", 0, null, null, null, "chips", "Trail/Path (6-12 ft.)" },
                    { 283, 173, null, null, null, 87, 0.22207445000000001, "Firelane 15", 1980, 1981, null, null, "soil", "Firelane" },
                    { 282, 174, 2496, null, null, 173, 0.42225015999999999, "Firelane 15", 87, null, null, null, "soil", "Firelane" },
                    { 281, 499, 228, 1399, null, 174, 0.32193421999999999, "Firelane 15", 173, 2496, null, null, "soil", "Firelane" },
                    { 280, 0, null, null, null, 31, 0.29995915000000001, "NW Harborton Dr.", 2080, null, null, null, "asphalt", "on-street trail" },
                    { 279, 1614, null, null, null, 2080, 0.076224860000000005, "NW Creston Rd.", 31, null, null, null, "gravel", "on-street trail" },
                    { 278, 137, null, null, null, 1614, 0.13802494000000001, "NW Creston Rd.", 2080, null, null, null, "gravel", "on-street trail" },
                    { 277, 228, 229, null, null, 137, 0.99390860000000003, "Firelane 12", 1614, 0, null, null, "soil", "Firelane" },
                    { 276, 229, 137, null, null, 228, 0.38437293, "Firelane 15", 499, 174, 1399, null, "soil", "Firelane" },
                    { 275, 465, 524, null, null, 229, 0.50782579000000005, "Firelane 12", 228, 137, null, null, "soil", "Firelane" },
                    { 274, 1984, 497, 524, null, 499, 0.86747114999999997, "Wildwood Trail", 174, 1399, 228, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 273, 1476, 1491, null, null, 465, 0.37211000999999999, "BPA Road", 229, 524, null, null, "soil", "Maintenance Road" },
                    { 272, 1, null, null, null, 138, 0.19412468999999999, "Firelane 13A", 1475, 1476, null, null, "soil", "Firelane" },
                    { 271, 1, null, null, null, 1475, 0.11842046000000001, "Firelane 13", 138, 1476, null, null, "soil", "Firelane" },
                    { 286, 174, 173, null, null, 2496, 0.12805226, "Kielhorn Meadow access", 518, null, null, null, "gravel", "Maintenance Road" },
                    { 270, 1475, 138, null, null, 1476, 0.50776909999999997, "Firelane 13", 465, 1491, null, null, "soil", "Firelane" },
                    { 287, 2496, null, null, null, 518, 0.33257384000000001, "Kielhorn Meadow access", 1983, 1982, null, null, "gravel", "Maintenance Road" },
                    { 289, 1982, 518, null, null, 1983, 0.04420383, "Kielhorn Meadow access", 0, null, null, null, "gravel", "Trail/Path (6-12 ft.)" },
                    { 304, 1607, 1604, null, null, 1605, 0.01431928, "Wildwood-Holman Connector Trail", 1246, 1603, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 303, 1608, 1606, null, null, 1607, 0.033381290000000001, "Wildwood-Holman Connector Trail", 1605, 1604, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 302, 1490, null, null, null, 1494, 0.13585952000000001, "BPA offshoot", 2153, 1491, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 301, 1505, 1506, null, null, 1504, 0.1141219, "NW Vaughn Connector", 779, 1503, null, null, "gravel", "Trail/Path (1-3 ft.)" },
                    { 300, 0, null, null, null, 1505, 0.019057709999999999, "NW Vaughn Park Entrance", 1506, 1504, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 299, 0, null, null, null, 1506, 0.011595299999999999, "NW Vaughn Staircase", 1505, 1504, null, null, "staircase", "Trail/Path (1-3 ft.)" },
                    { 298, 1373, 1223, null, null, 1516, 0.38300698999999999, "NW Germantown Road", 0, null, null, null, "road shoulder", "on-street trail" },
                    { 297, 564, 349, null, null, 1373, 0.12658683000000001, "NW  Germantown Road", 1516, 1223, null, null, "road shoulder", "on-street trail" },
                    { 296, 533, 711, null, null, 349, 0.03036691, "NW Germantown Road", 564, 1373, null, null, "road shoulder", "on-street trail" },
                    { 295, 534, 528, null, null, 533, 0.21516679999999999, "NW Germantown Road", 349, 711, null, null, "road shoulder", "on-street trail" },
                    { 294, 1748, 1536, 2492, null, 534, 0.057084379999999997, "NW Germantown Road", 528, 533, null, null, "road shoulder", "on-street trail" },
                    { 293, 1747, 1749, null, null, 1748, 0.028370320000000001, "NW Germantown Road", 2492, 1536, 534, null, "road shoulder", "on-street trail" },
                    { 292, 0, 1556, 1089, null, 1747, 0.89533328000000001, "NW Germantown Road", 1749, 1748, null, null, "road shoulder", "on-street trail" },
                    { 291, 0, null, null, null, 1556, 0.36432717999999997, "NW Germantown Road", 0, 1089, 1747, null, "road shoulder", "on-street trail" },
                    { 290, 228, 499, 174, null, 1399, 1.7609194399999999, "Wildwood Trail", 0, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 288, 0, null, null, null, 1982, 0.0307026, "Kielhorn Meadow access", 1983, 518, null, null, "gravel", "Trail/Path (6-12 ft.)" },
                    { 269, 2153, 1494, null, null, 1491, 0.28425233, "BPA Road", 1476, 465, null, null, "soil", "Firelane" },
                    { 268, 1, null, null, null, 1493, 0.090223639999999994, "BPA offshoot", 1492, 2153, null, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 267, 1491, 1494, null, null, 2153, 0.028860750000000001, "BPA Road", 1492, 1493, null, null, "soil", "Firelane" },
                    { 246, 1513, 1515, null, null, 1514, 0.37061653, "Newton Road", 710, 492, 497, null, "soil", "Firelane" },
                    { 245, 1515, 709, null, null, 710, 0.38770777000000001, "Wildwood Trail", 1514, 497, 492, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 244, 1513, 1514, null, null, 1515, 0.13717609, "Newton-Wildwood Connector Trail", 709, 710, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 243, 708, 505, null, null, 709, 0.32103436000000002, "Wildwood Trail", 1515, 710, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 242, 560, null, null, null, 1513, 0.20363096999999999, "Newton Road", 1514, 1515, null, null, "soil", "Firelane" },
                    { 241, 1513, null, null, null, 560, 0.01323298, "Newton Road", 1985, 1328, 708, null, "gravel", "Maintenance Road" },
                    { 240, 1328, 1985, 560, null, 708, 0.080335779999999996, "Access Trail", 505, 709, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 239, 532, 1328, 1327, null, 505, 0.14796101, "Wildwood Trail", 708, 709, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 238, 2500, null, null, null, 528, 0.41129179999999999, "Firelane 10", 534, 533, null, null, "soil", "Firelane" },
                    { 237, 2499, null, null, null, 2500, 0.095414410000000005, "Firelane 10", 528, null, null, null, "soil", "Firelane" },
                    { 236, 1324, 1999, null, null, 2499, 0.11739349, "Firelane 10", 2500, null, null, null, "soil", "Firelane" },
                    { 235, 0, null, null, null, 1999, 0.53130973000000004, "Linnton Trail", 2499, 1324, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 234, 182, 1325, null, null, 1324, 0.35695216000000002, "Firelane 10", 2499, 1999, null, null, "soil", "Firelane" },
                    { 233, 1327, 1325, null, null, 182, 0.25083022999999999, "Kaizer Trail", 1325, 1324, null, null, "soil", "Firelane" },
                    { 232, 1327, 182, null, null, 1325, 0.16096684999999999, "Firelane 10", 182, 1324, null, null, "soil", "Firelane" },
                    { 247, 492, 710, 1514, null, 497, 1.0964944599999999, "Wildwood Trail", 1984, 499, 524, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 248, 497, 524, 499, null, 1984, 0.45875842999999999, "BPA Road", 0, null, null, null, "soil", "Firelane" },
                    { 249, 497, 1984, 499, null, 524, 0.25943560999999998, "BPA Road", 229, 465, null, null, "soil", "Firelane" },
                    { 250, 710, 1514, 497, null, 492, 0.54326653000000003, "Newton Road", 493, null, null, null, "soil", "Firelane" },
                    { 266, 1486, 1487, null, null, 1490, 0.097406950000000006, "BPA offshoot", 1494, null, null, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 265, 1487, 1490, null, null, 1486, 0.022887930000000001, "BPA offshoot", 1, null, null, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 264, 1488, 1489, 1485, null, 1487, 0.055328200000000001, "BPA offshoot", 1486, 1490, null, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 263, 1, null, null, null, 1489, 0.03497828, "BPA offshoot", 1485, 1488, 1487, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 262, 1485, 1489, 1487, null, 1488, 0.047265349999999998, "BPA offshoot", 1, null, null, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 261, 1482, 1492, null, null, 1485, 0.13572386, "BPA offshoot", 1489, 1488, 1487, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 260, 1482, 1485, null, null, 1492, 0.27512625000000002, "BPA Road", 1493, 2153, null, null, "soil", "Firelane" },
                    { 155, 210, 712, null, null, 1464, 0.36685142999999998, "Wildwood Trail", 680, 396, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 259, 1484, 1483, null, null, 1482, 0.062337379999999998, "BPA Road", 1485, 1492, null, null, "gravel", "Firelane" },
                    { 257, 2000, 140, null, null, 1483, 0.23454021999999999, "BPA Road", 1484, 1482, null, null, "gravel", "Firelane" },
                    { 256, 0, null, null, null, 2000, 0.053475219999999997, "BPA Road", 140, 1483, null, null, "gravel", "Firelane" },
                    { 255, 258, null, null, null, 140, 0.12130291, "Newton Road", 1483, 2000, null, null, "soil", "Firelane" },
                    { 254, 2498, null, null, null, 258, 0.33312675000000003, "Newton Road", 140, null, null, null, "Trail/Path (6-12 ft.)", "soil" },
                    { 253, 2497, null, null, null, 2498, 0.078929319999999997, "Newton Road", 258, null, null, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 252, 493, null, null, null, 2497, 0.063335760000000005, "Newton Road", 2498, null, null, null, "soil", "Firelane" }
                });

            migrationBuilder.InsertData(
                table: "Trails",
                columns: new[] { "TrailId", "FirstAdjoiningSegment1", "FirstAdjoiningSegment2", "FirstAdjoiningSegment3", "FirstAdjoiningSegment4", "GeoObjNumber", "Miles", "Name", "SecondAdjoiningSegment1", "SecondAdjoiningSegment2", "SecondAdjoiningSegment3", "SecondAdjoiningSegment4", "Surface", "Type" },
                values: new object[,]
                {
                    { 251, 492, null, null, null, 493, 0.14736862000000001, "Newton Road", 2497, null, null, null, "soil", "Firelane" },
                    { 258, 1, null, null, null, 1484, 0.071031960000000005, "BPA offshoot", 1482, 1483, null, null, "soil", "Trail/Path (6-12 ft.)" },
                    { 154, 712, 713, null, null, 1577, 0.50471948, "Leif Erikson Drive", 1575, 1576, null, null, "gravel", "Maintenance Road" },
                    { 153, 713, 1577, null, null, 712, 0.29800069000000001, "Wiregate Trail", 1464, 210, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 152, 591, 718, 739, null, 210, 1.5125184300000001, "Wildwood Trail", 712, 1464, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 55, 198, 1602, null, null, 1240, 0.11680467999999999, "Leif Erikson Drive", 1238, null, null, null, "asphalt", "Maintenance Road" },
                    { 54, 1245, 598, 1236, null, 662, 0.57503515999999999, "Dogwood Trail", 1235, 203, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 53, 202, 1991, null, null, 203, 0.047688649999999999, "Dogwood Trail", 662, 1235, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 52, 202, 433, 198, null, 1245, 0.60222160000000002, "Wildwood Trail", 662, 1236, 598, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 51, 0, null, null, null, 1991, 0.035981689999999997, "Dogwood Trail", 202, 203, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 50, 433, 198, 1245, null, 202, 0.28352036000000003, "Wild Cherry Trail", 1991, 203, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 49, 0, null, null, null, 1241, 0.066142000000000006, "Leif Erikson Drive", 1242, null, null, null, "gravel", "Maintenance Road" },
                    { 48, 1602, 1244, null, null, 1242, 0.24201157000000001, "Leif Erikson Drive", 1241, null, null, null, "gravel", "Maintenance Road" },
                    { 47, 0, null, null, null, 1243, 0.054297779999999997, "Water Tank Access Road", 2116, null, null, null, "gravel", "Maintenance Road" },
                    { 46, 1243, null, null, null, 2116, 0.084195660000000005, "Water Tank Access Road", 1244, null, null, null, "gravel", "Maintenance Road" },
                    { 45, 1602, 1242, null, null, 1244, 0.11561303000000001, "Water Tank Access Road", 2116, null, null, null, "gravel", "Maintenance Road" },
                    { 44, 198, 1240, null, null, 1602, 0.06087513, "Leif Erikson Drive", 1242, 1244, null, null, "asphalt", "Maintenance Road" },
                    { 43, 433, 202, 1245, null, 198, 0.55437194000000001, "Wild Cherry Trail", 1602, 1240, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 42, 1992, 29, null, null, 433, 0.39197175000000001, "Wildwood Trail", 198, 202, 1245, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 41, 0, null, null, null, 1992, 0.22513996999999999, "Birch Trail", 29, 433, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 56, 1240, null, null, null, 1238, 0.48264452000000002, "Leif Erikson Drive", 1236, 1237, null, null, "gravel", "Maintenance Road" },
                    { 40, 28, null, null, null, 29, 0.59599535000000003, "Wildwood Trail", 433, 1992, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 57, 1237, 1238, null, null, 1236, 0.34018696999999998, "Dogwood Trail", 1245, 662, 598, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 59, 662, 203, null, null, 1235, 0.16341654, "Keil Trail", 1990, 2490, 598, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 74, 1528, null, null, null, 1600, 0.15081365999999999, "Firelane 1", 1529, 778, 439, null, "gravel", "Firelane" },
                    { 73, 1600, null, null, null, 1528, 0.096082310000000004, "Firelane 1", 1530, 1601, null, null, "gravel", "Firelane" },
                    { 72, 1530, 1528, null, null, 1601, 0.085032179999999999, "Firelane 1", 411, null, null, null, "gravel", "Firelane" },
                    { 71, 1529, 1234, null, null, 1530, 0.050602519999999998, "Morak Trail", 1601, 1528, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 70, 778, 439, 1600, null, 1529, 0.49442398999999998, "Wildwood Trail", 1234, 1530, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 69, 764, 557, null, null, 778, 0.072135729999999995, "Firelane 1", 1529, 1600, 439, null, "gravel", "Firelane" },
                    { 68, 2018, 293, null, null, 764, 0.44527873000000001, "Firelane 1", 778, 557, null, null, "soil", "Firelane" },
                    { 67, 2018, 764, null, null, 292, 0.025876929999999999, "Leif Erikson Drive", 293, 752, null, null, "gravel", "Maintenance Road" },
                    { 66, 758, null, null, null, 2018, 1.45099493, "Leif Erikson Drive", 292, 764, null, null, "gravel", "Maintenance Road" },
                    { 65, 1237, 596, null, null, 758, 0.10812296, "Leif Erikson Drive", 2018, null, null, null, "gravel", "Maintenance Road" },
                    { 64, 2490, 596, null, null, 1234, 1.18883867, "Wildwood Trail", 1529, 1530, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 63, 758, 1237, null, null, 596, 0.88500533000000003, "Alder Trail", 1234, 2490, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 62, 1238, 1236, null, null, 1237, 0.55845188999999995, "Leif Erikson Drive", 758, 596, null, null, "gravel", "Maintenance Road" },
                    { 61, 1990, 1235, 598, null, 2490, 0.29336942999999999, "Wildwood Trail", 596, 1234, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 60, 0, null, null, null, 1990, 0.010490029999999999, "NW 53rd Site Trail", 1235, 598, 2490, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 58, 1236, 1245, 662, null, 598, 0.70626933000000003, "Wildwood Trail", 1235, 990, 2490, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 39, 1612, null, null, null, 28, 0.27041279000000001, "Wildwood Trail", 29, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 38, 1997, 1613, null, null, 1612, 0.23331774999999999, "Wildwood Trail", 28, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 37, 0, null, null, null, 1997, 0.22176588, "Aspen Trail", 1613, 1612, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 16, 2029, 2030, null, null, 2031, 0.23858776000000001, "Cumberland Trail", 2033, 2036, null, null, "soil", "Trail/Path (3 ft.)" },
                    { 15, 2029, 2031, null, null, 2030, 0.16555095, "Tunnel Trail", 0, null, null, null, "soil", "Trail/Path (3 ft.)" },
                    { 14, 0, null, null, null, 2029, 0.16648545000000001, "Cumberland Trail", 2030, 2031, null, null, "soil", "Trail/Path (3 ft.)" },
                    { 13, 2035, 2038, 2039, null, 2034, 0.52644760000000002, "Upper Macleay Trail", 2032, 2033, null, null, "soil", "Trail/Path (3 ft.)" },
                    { 12, 2035, 2037, null, null, 2036, 0.10070133000000001, "Wildwood Trail", 2031, 2033, null, null, "soil", "Trail/Path (3 ft.)" },
                    { 11, 2038, 2039, 2034, null, 2035, 0.085141999999999995, "Wildwood Trail", 2036, 2037, null, null, "soil", "Trail/Path (3 ft.)" },
                    { 10, 0, 2038, null, null, 2037, 0.28158196000000002, "	Macleay Trail", 2035, 2036, null, null, "soil", "Trail/Path (3 ft.)" },
                    { 9, 2035, 2039, 2034, null, 2038, 0.27132799000000002, "Upper Macleay Trail", 0, 2037, null, null, "soil", "Trail/Path (3 ft.)" },
                    { 8, 818, null, null, null, 2039, 0.40829461, "Wildwood Trail", 2034, 2035, 2038, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 7, 819, null, null, null, 818, 0.024750189999999998, "Wildwood Trail", 2039, null, null, null, "asphalt", "Pittock parking lot" },
                    { 6, 1994, 686, null, null, 819, 0.30433139999999997, "Wildwood Trail", 818, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 5, 0, null, null, null, 1994, 0.10869500999999999, "Valle Vista", 686, 819, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 4, 1326, 86, 1995, null, 686, 0.13392011000000001, "Wildwood Trail", 819, 1994, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 3, 1, null, null, null, 1326, 0.11308045999999999, "Verde Vista", 86, 1995, 686, null, "gravel", "Maintenance Road" },
                    { 2, 0, null, null, null, 1995, 0.13484988000000001, "Verde Vista", 86, 1326, 686, null, "gravel", "Maintenance Road" },
                    { 17, 2036, 2031, null, null, 2033, 0.44311381, "Wildwood Trail", 2032, 2034, null, null, "soil", "Trail/Path (3 ft.)" },
                    { 18, 2033, 2034, null, null, 2032, 0.048565450000000003, "Wildwood Trail", 1502, null, null, null, "soil", "Trail/Path (3 ft.)" },
                    { 19, 2032, null, null, null, 1502, 0.1027945, "Wildwood Trail", 96, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 20, 1502, null, null, null, 96, 0.43238406000000001, "Wildwood Trail", 783, 1606, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 36, 1611, null, null, null, 1613, 0.33731371999999998, "Wildwood Trail", 1997, 1612, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 35, 1246, 1608, 1609, null, 1611, 0.095388840000000003, "Wildwood Trail", 1613, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 34, 0, null, null, null, 1993, 0.078438820000000006, "Holman Ln.", 27, null, null, null, "gravel", "Firelane" },
                    { 33, 204, null, null, null, 27, 0.049541429999999997, "Holman Ln.", 1993, null, null, null, "gravel", "Firelane" },
                    { 32, 1610, null, null, null, 204, 0.045430989999999997, "Holman Ln.", 27, null, null, null, "gravel", "Firelane" },
                    { 31, 1609, null, null, null, 1610, 0.54599750000000002, "Holman Ln.", 204, null, null, null, "soil", "Firelane" },
                    { 30, 1611, 1246, 1608, null, 1609, 0.04098628, "Holman Ln.", 1610, null, null, null, "soil", "Firelane" },
                    { 75, 778, 1600, 1529, null, 439, 0.63983327000000001, "Wildwood Trail", 559, 593, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 29, 0, null, null, null, 1996, 0.056823529999999997, "Holman Ln.", 1603, 1604, null, null, "gravel", "Firelane" },
                    { 27, 1609, 1608, 1611, null, 1246, 0.024644869999999999, "Holman Ln.", 1603, 1605, null, null, "soil", "Firelane" },
                    { 26, 1606, 1607, null, null, 1608, 0.019464039999999998, "Wildwood Trail", 1609, 1246, 1611, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 25, 96, 783, null, null, 1606, 0.40909169000000001, "Wildwood Trail", 1608, 1607, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 24, 779, null, null, null, 603, 0.01590053, "Lower Macleay Trail", 0, null, null, null, "asphalt", "Trail/Path (5-6 ft.)" },
                    { 23, 1503, 1504, null, null, 779, 0.044650629999999997, "Lower Macleay Trail", 603, null, null, null, "asphalt", "Trail/Path (5-6 ft.)" },
                    { 22, 783, null, null, null, 1503, 0.14994898000000001, "Lower Macleay Trail", 779, 1504, null, null, "asphalt", "Trail/Path (5-6 ft.)" },
                    { 21, 96, 1606, null, null, 783, 0.65503394999999998, "Lower Macleay Trail", 1503, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 28, 1246, 1605, null, null, 1603, 0.048541910000000001, "Holman Ln.", 1996, 1604, null, null, "gravel", "Firelane" },
                    { 305, 1996, 1603, null, null, 1604, 0.04760926, "Wildwood-Holman Connector Trail", 1605, 1607, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 76, 439, 559, null, null, 593, 0.035860400000000001, "Nature-Wildwood Tye Trail", 557, 558, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 78, 593, 439, null, null, 559, 0.29684527999999999, "Wildwood Trail", 26, 291, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 132, 223, 716, null, null, 714, 0.01126861, "Saltzman Road", 659, 222, 715, null, "chipseal", "Maintenance Road" },
                    { 131, 1578, 221, null, null, 716, 0.24259565999999999, "Leif Erikson Drive", 223, 714, null, null, "gravel", "Maintenance Road" },
                    { 130, 731, 715, null, null, 1578, 0.42131677000000001, "Maple Trail", 221, 716, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 129, 731, 1578, null, null, 715, 0.16738723999999999, "Quarry Trail", 659, 222, 714, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 128, 656, 730, 659, null, 731, 0.72687345000000003, "Maple Trail", 1578, 715, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 127, 656, 730, 731, null, 659, 0.83154342000000003, "Saltzman Road", 222, 714, 715, null, "chipseal", "Maintenance Road" },
                    { 126, 741, 222, null, null, 745, 0.22954837, "Leif Erikson Drive", 326, 326, 742, null, "gravel", "Maintenance Road" },
                    { 125, 430, 428, null, null, 741, 0.21157095000000001, "Cleator Trail", 745, 222, null, null, "soil", "Maintenance Road" },
                    { 124, 327, 753, null, null, 430, 0.71022454000000002, "Wildwood Trail", 741, 428, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 123, 656, 659, 731, null, 730, 0.47493969000000003, "Maple Trail", 325, 1594, 426, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 122, 732, 1584, null, null, 656, 0.46997332000000003, "Saltzman Road", 730, 659, 731, null, "chipseal", "Maintenance Road" },
                    { 121, 1585, 1584, null, null, 1583, 0.034474640000000001, "Firelane 4", 1, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 120, 1584, 1583, null, null, 1585, 0.01594696, "Firelane 4", 1, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 119, 732, 656, null, null, 1584, 0.033796449999999999, "Firelane 4", 1585, 1583, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 118, 0, null, null, null, 732, 0.75002820000000003, "Saltzman Road", 1584, 656, null, null, "asphalt", "on-street trail" },
                    { 133, 659, 714, 715, null, 222, 0.73170162000000005, "Leif Erikson Drive", 745, 741, null, null, "gravel", "Maintenance Road" },
                    { 117, 326, 745, null, null, 742, 0.11614132000000001, "Leif Erikson Drive", 744, 426, null, null, "gravel", "Maintenance Road" },
                    { 134, 714, 716, null, null, 223, 0.52513094999999999, "Saltzman Road", 1598, 592, 718, null, "gravel", "Maintenance Road" },
                    { 136, 223, 1598, 718, null, 592, 1.0108090700000001, "Saltzman Road", 740, 737, null, null, "gravel", "Maintenance Road" },
                    { 151, 738, 221, null, null, 713, 0.53025279999999997, "Leif Erikson Drive", 1577, 712, null, null, "gravel", "Maintenance Road" },
                    { 150, 736, null, null, null, 737, 0.10866321, "Saltzmann Rd. / Powerline Area Path", 740, 592, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 149, 737, null, null, null, 736, 0.045500430000000001, "Saltzmann Rd. / Powerline Area Path", 421, 743, null, null, "gravel", "Maintenance Road" },
                    { 148, 736, 743, null, null, 421, 0.24319993000000001, "Firelane 5", 740, 420, null, null, "gravel", "Firelane" },
                    { 147, 735, null, null, null, 743, 0.010051579999999999, "Firelane 5", 421, 736, null, null, "gravel", "Firelane" },
                    { 146, 591, 378, null, null, 735, 0.13999099000000001, "Firelane 5", 743, null, null, null, "gravel", "Firelane" },
                    { 145, 1, null, null, null, 378, 0.074351360000000005, "Firelane 5 offshoot", 591, 735, null, null, "soil", "Firelane" },
                    { 144, 739, 718, 210, null, 591, 0.45896807000000001, "Firelane 5", 378, 735, null, null, "soil", "Firelane" },
                    { 143, 738, null, null, null, 739, 0.14708895, "Firelane 5 extension", 718, 591, 210, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 142, 591, 210, 739, null, 718, 0.68574356999999997, "WildWood Trail", 592, 1598, 223, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 141, 739, null, null, null, 738, 0.12650525000000001, "Firelane 5 extension", 221, 713, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 140, 1578, 716, null, null, 221, 0.16082117000000001, "Leif Erikson Drive", 713, 738, null, null, "gravel", "Maintenance Road" },
                    { 139, 741, 430, null, null, 428, 0.16671379, "Wildwood Trail", 1598, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 138, 0, null, null, null, 420, 0.10954181, "Saltzman Road", 740, 421, null, null, "gravel", "Maintenance Road" },
                    { 137, 592, 737, null, null, 740, 0.11469905, "Saltzman Road", 420, 421, null, null, "gravel", "Maintenance Road" },
                    { 135, 592, 718, 223, null, 1598, 0.34223369999999997, "Wildwood Trail", 428, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 116, 327, 1180, null, null, 326, 0.070958960000000001, "Firelane 4", 742, 745, null, null, "soil", "Firelane" },
                    { 115, 1, null, null, null, 1180, 0.087542519999999999, "Firelane 4", 327, 326, null, null, "soil", "Firelane" },
                    { 114, 753, 430, null, null, 327, 0.071611579999999994, "Firelane 4", 1180, 326, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 93, 569, 771, null, null, 772, 0.065297809999999998, "Maple-Wildwood Tye Trail", 219, 765, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 92, 770, 765, null, null, 771, 0.61934131999999997, "Wildwood Trail", 772, 569, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 91, 770, 771, null, null, 765, 0.49182420999999998, "Maple Trail", 772, 219, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 90, 1989, 26, 677, null, 770, 0.093035129999999994, "Wildwood Trail", 765, 771, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 89, 290, 763, null, null, 677, 0.44818542, "Firelane 2", 26, 1989, 770, null, "soil", "Firelane" },
                    { 88, 775, 291, null, null, 290, 0.27489214000000001, "Leif Erikson Drive", 677, 763, null, null, "gravel", "Maintenance Road" },
                    { 87, 2019, null, null, null, 1539, 0.14883088999999999, "Firelane 1", 0, null, null, null, "soil", "Firelane" },
                    { 86, 752, null, null, null, 2019, 0.94831215999999996, "Firelane 1", 1539, null, null, null, "soil", "Firelane" },
                    { 85, 292, 293, null, null, 752, 0.35352985999999997, "Firelane 1", 2019, null, null, null, "soil", "Firelane" },
                    { 84, 775, 558, null, null, 293, 0.35421944, "Leif Erikson Drive", 292, 752, null, null, "gravel", "Maintenance Road" },
                    { 83, 0, null, null, null, 1989, 0.57113563000000001, "Firelane 2", 26, 770, 677, null, "soil", "Firelane" },
                    { 82, 290, 291, null, null, 775, 0.018656369999999999, "Leif Erikson Drive", 558, 293, null, null, "gravel", "Maintenance Road" },
                    { 81, 593, 557, null, null, 558, 0.27972991000000003, "Nature Trail", 775, 293, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 80, 559, 291, null, null, 26, 0.61155398999999999, "Wildwood Trail", 770, 1989, 677, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 79, 559, 26, null, null, 291, 0.49651057999999998, "Chestnut Trail", 775, 290, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 94, 771, 772, null, null, 569, 0.19236279000000001, "Wildwood Trail", 1574, 353, 767, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 95, 765, 772, null, null, 219, 0.33727014999999999, "Maple Trail", 763, 759, 757, 1586, "soil", "Trail/Path (1-3 ft.)" },
                    { 96, 290, 677, null, null, 763, 0.52029957999999998, "Leif Erikson Drive", 219, 1586, 757, 759, "gravel", "Maintenance Road" },
                    { 97, 763, 219, 1586, 757, 759, 0.38106448999999998, "Maple Trail", 750, 1594, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 113, 756, 353, null, null, 753, 0.51859409000000001, "Wildwood Trail", 430, 327, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 112, 750, 755, null, null, 744, 0.51834694999999997, "Leif Erikson Drive", 426, 742, null, null, "gravel", "Maintenance Road" },
                    { 111, 325, 1594, 730, null, 426, 0.20283799, "Firelane 4", 744, 742, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 110, 1, null, null, null, 325, 0.18240898, "Firelane 4", 1594, 426, 730, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 109, 750, 759, null, null, 1594, 0.59074037999999995, "Maple Trail", 426, 730, 325, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 108, 755, 744, null, null, 750, 0.12877278, "Koenig Trail", 759, 1594, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 107, 756, 757, null, null, 755, 0.059716440000000003, "Leif Erikson Drive", 750, 744, null, null, "gravel", "Maintenance Road" },
                    { 77, 593, 558, null, null, 557, 0.61824590000000001, "Nature Trail", 778, 764, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 106, 753, 353, null, null, 756, 0.13537510999999999, "Koenig Trail", 757, 755, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 104, 759, 763, 219, 1586, 757, 0.32440627999999999, "Leif Erikson Drive", 756, 755, null, null, "gravel", "Maintenance Road" }
                });

            migrationBuilder.InsertData(
                table: "Trails",
                columns: new[] { "TrailId", "FirstAdjoiningSegment1", "FirstAdjoiningSegment2", "FirstAdjoiningSegment3", "FirstAdjoiningSegment4", "GeoObjNumber", "Miles", "Name", "SecondAdjoiningSegment1", "SecondAdjoiningSegment2", "SecondAdjoiningSegment3", "SecondAdjoiningSegment4", "Surface", "Type" },
                values: new object[,]
                {
                    { 103, 1573, null, null, null, 1586, 0.16211133, "Firelane 3", 757, 759, 763, 219, "gravel", "Firelane" },
                    { 102, 1574, null, null, null, 1573, 0.094913639999999994, "Firelane 3", 1586, null, null, null, "gravel", "Firelane" },
                    { 101, 767, 569, 353, null, 1574, 0.050435889999999997, "Firelane 3", 1573, null, null, null, "gravel", "Firelane" },
                    { 100, 0, null, null, null, 1988, 0.092128810000000005, "Firelane 3", 2491, null, null, null, "asphalt", "Firelane" },
                    { 99, 767, null, null, null, 2491, 0.21604438000000001, "Firelane 3", 1988, null, null, null, "soil", "Firelane" },
                    { 98, 2491, null, null, null, 767, 0.35196586000000002, "Firelane 3", 569, 1574, 353, null, "soil", "Firelane" },
                    { 105, 767, 569, 1574, null, 353, 0.57435753000000001, "Wildwood Trail", 756, 753, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 306, 1610, null, null, null, 411, 0.22541699000000001, "Forest Lane", 0, null, null, null, "gravel", "Trail/Path (6-12 ft.)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 306);
        }
    }
}
