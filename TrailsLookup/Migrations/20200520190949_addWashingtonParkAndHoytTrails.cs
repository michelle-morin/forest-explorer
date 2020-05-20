using Microsoft.EntityFrameworkCore.Migrations;

namespace TrailsLookup.Migrations
{
    public partial class addWashingtonParkAndHoytTrails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trails",
                columns: new[] { "TrailId", "FirstAdjoiningSegment1", "FirstAdjoiningSegment2", "FirstAdjoiningSegment3", "FirstAdjoiningSegment4", "GeoObjNumber", "Miles", "Name", "SecondAdjoiningSegment1", "SecondAdjoiningSegment2", "SecondAdjoiningSegment3", "SecondAdjoiningSegment4", "Surface", "Type" },
                values: new object[,]
                {
                    { 307, 86, 446, null, null, 934, 0.11685542, "White Pine Trail", 844, 83, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 424, 693, 155, null, null, 691, 0.083634970000000003, "Oak Trail", 250, 958, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 425, 2486, 249, null, null, 958, 0.13618858, "Wildwood Trail", 250, 691, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 426, 958, 691, null, null, 250, 0.16231356999999999, "Wildwood Trail", 697, 952, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 427, 952, 250, null, null, 697, 0.076519329999999997, "Beech Trail", 853, 979, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 428, 697, 979, null, null, 853, 0.12092197, "Magnolia Trail", 392, 383, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 429, 853, 697, null, null, 979, 0.11798971, "Beech Trail", 383, 856, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 430, 853, 392, null, null, 383, 0.069393159999999995, "Site Trail (HA)", 979, 856, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 431, 979, 383, null, null, 856, 0.057388620000000001, "Beech Trail", 858, 155, 156, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 432, 853, 383, null, null, 392, 0.16818408000000001, "Magnolia Trail", 984, 212, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 433, 392, 212, null, null, 984, 0.023321729999999999, "Wildwood Trail", 874, 983, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 434, 0, null, null, null, 389, 0.06477231, "Site Trail (HA)", 380, 860, null, null, "gravel", "Maintenance Road" },
                    { 435, 874, 984, 981, null, 983, 0.11572512, "Overlook Trail", 380, 859, 382, 391, "chipseal", "pedestrian path" },
                    { 436, 871, 982, 983, null, 981, 0.052348810000000003, "Holly Loop", 391, 382, 859, 380, "gravel", "pedestrian path" },
                    { 437, 984, 983, null, null, 874, 0.027609720000000001, "Wildwood Trail", 2482, 131, 904, null, "chipseal", "Trail/Path (5-6 ft.)" },
                    { 438, 874, 2482, 131, null, 904, 0.032634910000000003, "Wildwood Trail", 873, 871, null, null, "chipseal", "Trail/Path (5-6 ft.)" },
                    { 439, 873, 904, null, null, 871, 0.011429099999999999, "Holly Loop", 981, 982, null, null, "gravel", "pedestrian path" },
                    { 440, 871, 981, null, null, 982, 0.044348169999999999, "Holly Loop", 391, 985, null, null, "gravel", "pedestrian path" },
                    { 441, 982, 985, 981, null, 391, 0.034587880000000001, "Holly Loop", 382, 859, 380, 983, "gravel", "pedestrian path" },
                    { 442, 391, 982, null, null, 985, 0.041766739999999997, "Site Trail (HA)", 873, 133, 872, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 423, 0, null, null, null, 693, 0.02034532, "Site Trail (HA)", 155, 691, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 443, 985, 872, 133, null, 873, 0.055577960000000003, "Wildwood Trail", 871, 904, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 422, 977, 169, null, null, 159, 0.011586590000000001, "Site Trail (HA)", 318, 316, null, null, "asphalt", "walkway" },
                    { 420, 155, 856, 858, null, 156, 0.081486719999999999, "Oak Trail", 977, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 401, 973, 255, null, null, 321, 0.093643770000000001, "Site Trail (HA)", 320, 854, 168, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 402, 973, 976, null, null, 319, 0.040940959999999998, "Fir Trail", 320, 318, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 403, 321, 854, 168, null, 320, 0.0096992599999999995, "Fir Trail", 319, 318, null, null, "asphalt", "pedestrian path" },
                    { 404, 319, 320, null, null, 318, 0.032977239999999998, "Site Trail (HA)", 159, 316, null, null, "asphalt", "pedestrian path" },
                    { 405, 382, null, null, null, 854, 0.035491160000000001, "Site Trail (HA)", 320, 321, 168, null, "gravel", "pedestrian path" },
                    { 406, 854, 391, null, null, 382, 0.02361624, "Site Trail (HA)", 859, 380, 983, 981, "concrete", "pedestrian path" },
                    { 407, 318, 159, null, null, 316, 0.0058547399999999998, "Site Trail (HA)", 2072, 317, null, null, "concrete", "walkway" },
                    { 408, 859, 163, null, null, 2072, 0.0091398499999999997, "Site Trail (HA)", 317, 316, null, null, "concrete", "walkway" },
                    { 409, 2072, 316, null, null, 317, 0.01214749, "Site Trail (HA)", 162, null, null, null, "concrete", "walkway" },
                    { 410, 317, null, null, null, 162, 0.01041771, "Site Trail (HA)", 170, 163, null, null, "concrete", "walkway" },
                    { 411, 859, 2072, null, null, 163, 0.0093283299999999993, "Site Trail (HA)", 162, 170, null, null, "concrete", "walkway" },
                    { 412, 2072, 163, 380, null, 859, 0.040477039999999999, "Site Trail (HA)", 382, 391, 981, 983, "concrete", "walkway" },
                    { 413, 163, 162, null, null, 170, 0.020526840000000001, "Site Trail (HA)", 169, 857, null, null, "asphalt", "walkway" },
                    { 414, 169, 170, null, null, 857, 0.0093766500000000003, "Site Trail (HA)", 858, 860, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 415, 977, 159, null, null, 169, 0.064713720000000002, "Site Trail (HA)", 170, 857, null, null, "asphalt", "pedestrian path" },
                    { 416, 859, 382, 391, 981, 380, 0.0067201300000000004, "Site Trail (HA)", 983, 389, 860, null, "concrete", "walkway" },
                    { 417, 380, 389, null, null, 860, 0.029464770000000001, "Beech Trail", 857, 858, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 418, 857, 860, null, null, 858, 0.050251480000000001, "Beech Trail", 856, 155, 156, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 419, 858, 856, 156, null, 155, 0.089647690000000002, "Oak Trail", 693, 691, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 421, 159, 169, null, null, 977, 0.0086526799999999994, "Oak Trail", 156, null, null, null, "gravel", "connecting trail" },
                    { 400, 255, 321, null, null, 973, 0.037837000000000003, "Spruce Trail", 976, 319, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 444, 133, 873, 985, null, 872, 0.034868000000000003, "Wildwood Trail", 217, 214, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 446, 904, 874, 2482, null, 131, 0.091941190000000006, "Overlook Trail", 106, 132, 2483, null, "chipseal", "pedestrian path" },
                    { 470, 368, 883, 373, null, 884, 0.056310640000000002, "Hawthorn Trail", 577, 374, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 471, 1000, 888, null, null, 583, 0.076943609999999996, "Maple Trail (HA)", 2342, 368, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 472, 373, 884, 883, null, 368, 0.14410902, "Wildwood Trail", 2342, 583, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 473, 368, 373, 884, null, 883, 0.18844432999999999, "Wildwood Trail", 908, 212, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 474, 909, 908, null, null, 577, 0.019654850000000001, "Hawthorn Trail", 884, 374, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 475, 577, 909, null, null, 908, 0.051811169999999997, "Site Trail (HA)", 883, 212, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 476, 908, 577, null, null, 909, 0.033187689999999999, "Hawthorn Trail", 2482, 2483, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 477, 984, 392, null, null, 212, 0.02394961, "Wildwood Trail", 883, 908, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 478, 583, 368, null, null, 2342, 0.41487659999999998, "Wildwood Trail", 2343, 365, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 479, 2342, 365, null, null, 2343, 0.23608203, "MAC Trail", 2550, 2551, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 480, 0, null, null, null, 2551, 0.02864452, "MAC connector trail", 2550, 2343, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 481, 2551, 2343, null, null, 2550, 0.24536162, "MAC Trail", 2552, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 482, 2343, 2342, null, null, 365, 0.56883019000000001, "Wildwood Trail", 952, 570, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 483, 250, 697, null, null, 952, 0.25851016999999998, "Wildwood Trail", 365, 570, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 484, 365, 952, null, null, 570, 0.17920344999999999, "Japanese Garden Trail", 850, 848, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 485, 0, null, null, null, 850, 0.078616549999999993, "Fairview Trail", 570, 848, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 486, 850, 570, null, null, 848, 0.059498059999999998, "Fairview Trail", 1, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 487, 2550, null, null, null, 2552, 0.050301520000000002, "MAC Trail", 2553, 2554, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 488, 0, null, null, null, 2553, 0.043407599999999998, "MAC connector trail", 2552, 2554, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 469, 884, 577, null, null, 374, 0.069418900000000006, "Site Trail (HA)", 588, 373, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 445, 217, 910, null, null, 912, 0.11469919000000001, "Maple Trail (HA)", 875, 877, 370, 366, "soil", "Trail/Path (1-3 ft.)" },
                    { 468, 588, 374, null, null, 373, 0.059468989999999999, "Hawthorn Trail", 368, 883, 884, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 466, 372, 370, 997, null, 589, 0.040811569999999998, "Walnut Trail", 588, 888, 996, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 447, 131, 874, 904, null, 2482, 0.026936080000000001, "Hawthorn Trail", 2483, 909, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 448, 2482, 909, null, null, 2483, 0.010818110000000001, "Overlook Trail", 106, 132, 131, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 449, 2483, 131, 106, null, 132, 0.014207880000000001, "Overlook Trail", 580, 133, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 450, 132, 133, null, null, 580, 0.042527509999999998, "Site Trail (HA)", 989, 875, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 451, 2483, 131, 132, null, 106, 0.10256231, "Overlook Trail", 877, 989, null, null, "chipseal", "pedestrian path" },
                    { 452, 877, 106, null, null, 989, 0.0067028399999999998, "Overlook Trail", 580, 875, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 453, 989, 106, null, null, 877, 0.12396833, "Overlook Trail", 875, 912, 370, 366, "chipseal", "pedestrian path" },
                    { 454, 989, 580, null, null, 875, 0.024342320000000001, "Overlook Trail", 912, 877, 370, 366, "soil", "Trail/Path (1-3 ft.)" },
                    { 455, 912, 875, 877, 370, 366, 0.035180349999999999, "Overlook Trail", 372, 2484, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 456, 0, 367, null, null, 2484, 0.01007159, "Overlook Trail", 366, 372, null, null, "chipseal", "pedestrian path" },
                    { 457, 0, 2484, null, null, 367, 0.011468809999999999, "Site Trail (HA)", 881, null, null, null, "chipseal", "pedestrian path" },
                    { 458, 367, null, null, null, 881, 0.01855149, "Site Trail (HA)", 882, null, null, null, "concrete", "pedestrian path" },
                    { 459, 881, null, null, null, 882, 0.014237619999999999, "Site Trail (HA)", 375, 371, 880, null, "chipseal", "pedestrian path" },
                    { 460, 2484, 366, null, null, 372, 0.071206690000000003, "Overlook Trail", 370, 589, 997, null, "chipseal", "pedestrian path" },
                    { 461, 366, 912, 875, 877, 370, 0.070100949999999995, "Maple Trail (HA)", 372, 997, 589, null, "chipseal", "pedestrian path" },
                    { 462, 372, 370, 589, null, 997, 0.070279140000000004, "Maple Trail (HA)", 996, 1000, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 463, 997, 1000, null, null, 996, 0.039638060000000003, "Hawthorn Trail", 589, 588, 888, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 464, 996, 997, null, null, 1000, 0.18235156999999999, "Maple Trail (HA)", 888, 583, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 465, 1000, 583, null, null, 888, 0.16204806999999999, "Walnut Trail", 996, 588, 589, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 467, 373, 374, null, null, 588, 0.026985450000000001, "Hawthorn Trail", 888, 996, 589, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 399, 2486, 958, null, null, 249, 0.12837933000000001, "Fir Trail Loop", 976, 246, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 398, 254, 695, null, null, 255, 0.025580909999999998, "Spruce Trail", 973, 321, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 397, 1, null, null, null, 695, 0.03214214, "Site Trail (HA)", 254, 255, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 331, 65, 995, null, null, 66, 0.07334222, "Site Trail (HA)", 1519, 1010, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 332, 65, 66, null, null, 995, 0.01868651, "Site Trail (HA)", 590, 369, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 333, 1012, 65, null, null, 993, 0.0055215799999999999, "SW Knight Blvd.", 990, 991, null, null, "sidewalk", "on-street trail" },
                    { 334, 993, 990, null, null, 991, 0.019374860000000001, "Site Trail (HA)", 586, null, null, null, "concrete", "staircase" },
                    { 335, 991, null, null, null, 586, 0.036774269999999998, "Vietnam Veterans Memorial", 590, 585, null, null, "concrete", "pedestrian path" },
                    { 336, 586, 585, null, null, 590, 0.10901157, "Vietnam Veterans Memorial", 369, 995, null, null, "concrete", "pedestrian path" },
                    { 337, 586, 590, null, null, 585, 0.097508540000000005, "Vietnam Veterans Memorial", 584, null, null, null, "concrete", "pedestrian path" },
                    { 338, 995, 590, null, null, 369, 0.12027345, "Vietnam Veterans Memorial", 885, null, null, null, "concrete", "pedestrian path" },
                    { 339, 585, null, null, null, 584, 0.01026344, "Site Trail (HA)", 376, 371, null, null, "concrete", "pedestrian path" },
                    { 340, 993, 991, null, null, 990, 0.039684740000000003, "SW Knight Blvd.", 375, 376, null, null, "sidewalk", "on-street trail" },
                    { 341, 584, 371, null, null, 376, 0.031269119999999997, "Site Trail (HA)", 990, 375, null, null, "concrete", "pedestrian path" },
                    { 342, 990, 376, null, null, 375, 0.035100220000000001, "SW Knight Blvd.", 882, 880, 371, null, "sidewalk", "on-street trail" },
                    { 343, 375, 882, 880, null, 371, 0.048426400000000001, "Site Trail (HA)", 376, 584, null, null, "concrete", "pedestrian path" },
                    { 344, 882, 375, 371, null, 880, 0.051167190000000001, "Wildwood Trail", 576, 885, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 345, 576, 880, null, null, 885, 0.057504609999999998, "Site Trail (HA)", 369, null, null, null, "gravel", "pedestrian path" },
                    { 346, 885, 880, null, null, 576, 0.017195599999999998, "Wildwood Trail", 910, 581, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 347, 576, 910, null, null, 581, 0.040076220000000003, "Wildwood Trail", 878, 2478, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 348, 581, 2478, null, null, 878, 0.056897749999999997, "Marquam Trail", 1010, 879, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 349, 581, 878, null, null, 2478, 0.023924129999999998, "Wildwood Trail", 988, 2480, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 330, 993, 1012, null, null, 65, 0.049361339999999997, "Site Trail (HA)", 995, 66, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 350, 2478, 2480, null, null, 988, 0.034530110000000003, "Wildwood Trail", 879, 911, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 329, 798, null, null, null, 1012, 0.28482494000000003, "SW Knight Blvd.", 993, 65, null, null, "sidewalk", "on-street trail" },
                    { 327, 2481, null, null, null, 322, 0.026794930000000002, "Marquam Trail", 798, null, null, null, "sidewalk", "on-street trail" },
                    { 308, 934, 844, null, null, 83, 0.1404957, "White Pine Trail", 845, 840, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 309, 83, 934, null, null, 844, 0.031896679999999997, "Site Trail (HA)", 362, 845, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 310, 844, 362, null, null, 845, 0.053462629999999997, "Bristlecone Pine Trail", 840, 83, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 311, 845, 83, null, null, 840, 0.0086341300000000003, "White Pine Trail", 870, 698, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 312, 870, 840, null, null, 698, 0.21958828999999999, "White Pine Trail", 696, 851, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 313, 698, 696, null, null, 851, 0.061074450000000002, "White Pine Trail", 978, 157, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 314, 978, 851, null, null, 157, 0.01247009, "White Pine Trail", 165, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 315, 157, null, null, null, 165, 0.030202139999999999, "White Pine Trail", 164, 167, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 316, 165, 164, null, null, 167, 0.02107268, "White Pine Trail", 855, 379, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 317, 167, 855, null, null, 379, 0.052693610000000002, "White Pine Trail", 381, 393, 215, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 318, 393, 381, 379, null, 215, 0.093819, "White Pine Trail", 2485, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 319, 215, null, null, null, 2485, 0.060629820000000001, "Site Trail (HA)", 214, 2479, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 320, 214, 2485, null, null, 2479, 0.02552372, "Wildwood Trail", 2480, 911, null, null, "gravel", "Trail/Path (5-6 ft.)" },
                    { 321, 2480, 2479, null, null, 911, 0.034884869999999998, "Wildwood Trail", 879, 988, null, null, "gravel", "Trail/Path (5-6 ft.)" },
                    { 322, 911, 988, null, null, 879, 0.031274469999999999, "Site Trail (HA)", 878, 1010, null, null, "gravel", "Trail/Path (5-6 ft.)" },
                    { 323, 879, 878, null, null, 1010, 0.18399314, "Marquam Trail", 1519, 66, null, null, "gravel", "Trail/Path (5-6 ft.)" },
                    { 324, 66, 1010, null, null, 1519, 0.18059238999999999, "Marquam Trail", 1520, 2481, null, null, "gravel", "Trail/Path (5-6 ft.)" },
                    { 325, 1519, 1520, null, null, 2481, 0.1158155, "Marquam Trail", 322, null, null, null, "gravel", "Trail/Path (5-6 ft.)" },
                    { 326, 1, null, null, null, 1520, 0.03694629, "Old Marquam Trail", 1519, 2481, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 328, 322, null, null, null, 798, 0.21232583999999999, "SW Zoo Rd.", 1012, null, null, null, "sidewalk", "on-street trail" },
                    { 351, 2478, 988, null, null, 2480, 0.053292369999999999, "Site Trail (HA)", 911, 2479, null, null, "surface unknown", "Trail/Path (1-3 ft.)" },
                    { 352, 581, 576, null, null, 910, 0.032845970000000002, "Maple Trail (HA)", 912, 217, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 353, 910, 912, null, null, 217, 0.034121310000000002, "Site Trail (HA)", 872, 214, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 378, 869, 242, null, null, 870, 0.039324060000000001, "Bristlecone Pine Trail", 840, 698, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 379, 844, 845, null, null, 362, 0.14463292999999999, "Bristlecone Pine Trail", 2489, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 380, 362, null, null, null, 2489, 0.030862339999999999, "Site Trail (HA)", 956, 251, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 381, 2489, 956, null, null, 251, 0.040343440000000001, "Creek Trail", 252, 969, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 382, 699, 252, null, null, 363, 0.061830240000000002, "Redwood Trail", 364, 954, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 383, 363, 364, null, null, 954, 0.060879530000000001, "Redwood Trail", 448, 447, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 384, 446, 447, null, null, 956, 0.098326250000000004, "Creek Trail", 2489, 251, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 385, 86, 934, null, null, 446, 0.094165009999999993, "Wildwood Trail", 447, 956, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 386, 446, 956, null, null, 447, 0.080269809999999997, "Wildwood Trail", 954, 448, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 387, 954, 447, null, null, 448, 0.11221963, "Wildwood Trail", 942, 839, null, null, "soil", "Trail/Path (1-3 ft.)" }
                });

            migrationBuilder.InsertData(
                table: "Trails",
                columns: new[] { "TrailId", "FirstAdjoiningSegment1", "FirstAdjoiningSegment2", "FirstAdjoiningSegment3", "FirstAdjoiningSegment4", "GeoObjNumber", "Miles", "Name", "SecondAdjoiningSegment1", "SecondAdjoiningSegment2", "SecondAdjoiningSegment3", "SecondAdjoiningSegment4", "Surface", "Type" },
                values: new object[,]
                {
                    { 388, 448, 942, null, null, 839, 0.12023295000000001, "Wildwood Trail", 2486, 2487, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 389, 448, 839, null, null, 942, 0.078762230000000003, "Spruce Trail", 2487, 246, 245, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 390, 839, 2486, null, null, 2487, 0.011264140000000001, "Fir Trail Loop", 942, 245, 246, null, "surface unknown", "pedestrian path" },
                    { 391, 954, 363, null, null, 364, 0.089275850000000004, "Site Trail (HA)", 245, 254, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 392, 942, 2487, 246, null, 245, 0.090083330000000003, "Spruce Trail", 364, 254, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 393, 839, 2487, null, null, 2486, 0.023881179999999998, "Wildwood Trail", 249, 958, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 394, 245, 2487, 942, null, 246, 0.14909502999999999, "Fir Trail Loop", 249, 976, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 395, 364, 245, null, null, 254, 0.077573349999999999, "Spruce Trail", 695, 255, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 396, 246, 249, null, null, 976, 0.037554230000000001, "Fir Trail", 319, 973, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 377, 1, null, null, null, 869, 0.01007331, "Bristlecone Pine Trail", 242, 870, null, null, "asphalt", "pedestrian path" },
                    { 376, 241, 248, null, null, 242, 0.045439359999999998, "Bristlecone Pine Trail", 869, 870, null, null, "asphalt", "pedestrian path" },
                    { 375, 1, null, null, null, 241, 0.01063307, "Bristlecone Pine Trail", 248, 242, null, null, "asphalt", "pedestrian path" },
                    { 374, 253, 247, null, null, 248, 0.098556980000000002, "Bristlecone Pine Trail", 241, 242, null, null, "asphalt", "pedestrian path" },
                    { 354, 217, 872, null, null, 214, 0.11685532999999999, "Wildwood Trail", 2479, 2485, null, null, "gravel", "Trail/Path (5-6 ft.)" },
                    { 355, 1, null, null, null, 393, 0.07608152, "Maintenance Road (HA)", 215, 381, 379, null, "gravel", "Maintenance Road" },
                    { 356, 215, 393, 379, null, 381, 0.051509970000000002, "Maintenance Road (HA)", 385, 855, null, null, "gravel", "Maintenance Road" },
                    { 357, 381, 385, null, null, 855, 0.01196259, "Fir Trail", 379, 167, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 358, 381, 855, null, null, 385, 0.081743940000000001, "Fir Trail", 168, 158, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 359, 385, 158, null, null, 168, 0.039810060000000001, "Fir Trail", 854, 320, 321, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 360, 385, 168, null, null, 158, 0.083794599999999997, "Redwood Trail", 852, 154, 164, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 361, 158, 852, 154, null, 164, 0.03112009, "Fir Trail", 167, 165, null, null, "gravel", "Maintenance Road" },
                    { 362, 0, null, null, null, 852, 0.022020100000000001, "Fir Trail", 158, 164, 154, null, "gravel", "Maintenance Road" },
                    { 489, 2553, 2552, null, null, 2554, 0.30380940000000001, "MAC Trail", 2555, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 363, 972, 699, null, null, 154, 0.10303841, "Redwood Trail", 852, 158, 164, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 365, 972, 154, null, null, 699, 0.099082539999999997, "Redwood Trail", 252, 363, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 366, 699, 363, null, null, 252, 0.024875169999999999, "Site Trail (HA)", 251, 969, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 367, 252, 251, null, null, 969, 0.089424649999999994, "Creek Trail", 2488, null, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 368, 969, null, null, null, 2488, 0.011854709999999999, "Bristlecone Pine Trail", 978, 247, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 369, 978, 2488, null, null, 247, 0.11201295999999999, "Bristlecone Pine Trail", 253, 248, null, null, "asphalt", "pedestrian path" },
                    { 370, 247, 248, null, null, 253, 0.042640669999999999, "Bristlecone Pine Trail", 694, 692, null, null, "asphalt", "pedestrian path" },
                    { 371, 692, 253, null, null, 694, 0.044347570000000003, "Bristlecone Pine Trail", 692, 696, null, null, "asphalt", "pedestrian path" },
                    { 372, 253, 694, null, null, 692, 0.026310279999999998, "Bristlecone Pine Trail", 696, 694, null, null, "asphalt", "pedestrian path" },
                    { 373, 851, 698, null, null, 696, 0.0066352299999999998, "Bristlecone Pine Trail", 692, 694, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 364, 1, null, null, null, 972, 0.03842098, "Site Trail (HA)", 154, 699, null, null, "soil", "Trail/Path (1-3 ft.)" },
                    { 490, 2554, null, null, null, 2555, 0.092397099999999996, "MAC Firelane Connector", 0, null, null, null, "soil", "Firelane" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Trails",
                keyColumn: "TrailId",
                keyValue: 490);
        }
    }
}
