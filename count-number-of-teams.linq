<Query Kind="Program" />

void Main()
{
	int[] arr = System.Text.Json.JsonSerializer.Deserialize<int[]>(@"[2999,2994,2991,2988,2987,2986,2984,2982,2979,2977,2974,2973,2969,2966,2961,2960,2952,2945,2943,2941,2940,2939,2937,2936,2935,2931,2924,2918,2917,2916,2912,2911,2909,2907,2905,2904,2901,2899,2893,2892,2889,2887,2886,2885,2884,2882,2872,2866,2862,2860,2854,2852,2848,2847,2844,2843,2838,2837,2834,2818,2817,2816,2813,2805,2801,2793,2791,2790,2788,2781,2780,2773,2771,2766,2765,2762,2758,2756,2755,2754,2746,2745,2742,2737,2736,2733,2732,2730,2729,2725,2724,2723,2719,2717,2716,2714,2713,2712,2706,2705,2700,2694,2690,2686,2681,2677,2672,2667,2665,2661,2656,2655,2653,2648,2644,2636,2635,2634,2631,2629,2626,2623,2618,2616,2615,2613,2610,2609,2608,2607,2605,2604,2603,2600,2599,2595,2594,2592,2590,2588,2583,2577,2574,2569,2564,2562,2559,2558,2556,2555,2547,2536,2535,2534,2531,2528,2526,2524,2522,2519,2518,2516,2515,2513,2511,2507,2505,2502,2501,2497,2489,2487,2486,2483,2482,2479,2475,2467,2466,2465,2464,2462,2456,2455,2451,2450,2448,2447,2443,2440,2433,2426,2422,2421,2416,2409,2408,2398,2397,2389,2385,2381,2380,2378,2377,2376,2375,2374,2373,2372,2368,2364,2361,2353,2349,2346,2337,2331,2329,2328,2326,2325,2324,2322,2320,2313,2312,2309,2307,2303,2298,2295,2292,2290,2288,2283,2282,2281,2273,2271,2270,2268,2267,2265,2263,2262,2253,2252,2247,2244,2243,2236,2235,2232,2227,2226,2225,2220,2217,2215,2210,2209,2206,2203,2202,2200,2199,2197,2196,2183,2182,2181,2179,2171,2169,2168,2165,2162,2156,2154,2152,2150,2146,2145,2144,2141,2137,2136,2135,2132,2131,2129,2128,2127,2126,2120,2118,2116,2107,2106,2099,2098,2097,2094,2093,2092,2089,2087,2086,2077,2065,2063,2062,2059,2058,2054,2048,2047,2044,2042,2037,2032,2026,2025,2023,2021,2020,2016,2013,2010,2009,2008,2006,1998,1997,1996,1995,1992,1991,1989,1988,1986,1981,1976,1975,1968,1967,1966,1964,1962,1960,1959,1958,1957,1951,1945,1943,1940,1938,1935,1930,1927,1926,1917,1915,1911,1910,1900,1896,1889,1888,1887,1884,1882,1881,1880,1878,1875,1874,1872,1871,1870,1868,1867,1866,1865,1864,1861,1859,1857,1856,1847,1846,1844,1842,1841,1840,1833,1830,1828,1826,1818,1816,1814,1813,1810,1804,1803,1800,1799,1798,1797,1796,1790,1789,1788,1787,1783,1781,1777,1773,1768,1766,1765,1764,1760,1759,1758,1757,1756,1752,1748,1746,1738,1737,1734,1733,1731,1727,1724,1723,1718,1716,1713,1712,1711,1708,1705,1702,1690,1689,1688,1679,1678,1677,1674,1669,1667,1666,1656,1655,1651,1649,1647,1646,1643,1641,1640,1638,1637,1635,1633,1631,1630,1625,1623,1622,1613,1609,1608,1603,1602,1596,1595,1593,1592,1587,1586,1580,1575,1570,1569,1568,1564,1556,1555,1554,1553,1552,1550,1548,1544,1541,1538,1536,1535,1533,1529,1525,1520,1515,1513,1507,1504,1487,1484,1482,1480,1472,1469,1467,1466,1460,1456,1455,1448,1447,1445,1443,1440,1435,1433,1432,1430,1425,1424,1423,1410,1406,1403,1402,1398,1397,1395,1394,1392,1389,1386,1382,1380,1374,1369,1367,1366,1361,1358,1355,1354,1347,1340,1338,1333,1332,1331,1325,1324,1323,1322,1320,1319,1313,1311,1310,1304,1302,1300,1299,1293,1292,1291,1284,1280,1278,1275,1270,1268,1267,1265,1263,1260,1256,1255,1250,1249,1246,1237,1231,1229,1228,1225,1222,1221,1220,1215,1214,1213,1212,1211,1205,1204,1190,1188,1186,1185,1176,1173,1169,1164,1163,1162,1158,1157,1152,1150,1148,1147,1144,1142,1140,1137,1136,1134,1132,1125,1121,1118,1116,1115,1111,1108,1106,1105,1104,1103,1100,1097,1095,1093,1092,1090,1088,1087,1086,1084,1082,1072,1065,1063,1058,1057,1056,1054,1050,1046,1043,1042,1041,1040,1035,1030,1029,1019,1018,1017,1016,1015,1009,1007,1001,999,998,995,993,991,984,983,981,979,977,975,974,973,972,971,968,947,946,942,938,937,936,929,928,925,919,918,917,913,909,905,903,901,893,889,887,883,874,869,868,857,855,853,847,844,841,837,836,832,831,830,829,827,821,816,813,810,807,803,802,800,798,794,790,788,787,786,785,784,777,775,772,770,767,764,759,756,750,746,743,742,740,736,732,729,728,721,720,719,715,714,710,708,705,701,700,693,691,687,686,679,676,675,670,663,661,660,657,655,654,653,651,649,646,643,640,638,637,633,627,623,622,617,616,615,613,610,609,605,603,602,601,600,599,595,591,590,589,584,580,579,574,571,565,564,562,554,553,551,548,547,546,545,540,534,526,525,524,522,519,509,507,501,500,496,495,493,491,488,485,483,482,480,474,472,471,462,460,459,458,457,452,450,449,447,442,441,440,436,435,429,428,425,424,423,422,418,414,413,410,407,405,404,401,399,397,396,393,390,389,387,381,378,377,376,372,369,363,362,359,357,356,354,349,348,343,342,338,337,336,329,326,319,314,313,307,302,294,293,291,286,280,264,262,258,256,255,254,250,248,247,242,236,234,229,225,223,222,221,215,213,211,209,201,199,198,197,195,193,188,185,181,177,168,164,163,151,143,142,140,139,136,133,129,126,123,119,114,111,109,102,93,84,83,82,77,74,72,71,70,69,62,57,55,51,50,47,44,43,36,32,31,25,24,19,17,16,14,11,7,1]");
	Solution s = new();
	//s.NumTeams(new[] { 2, 5, 3, 4, 1 }).Dump();
	s.NumTeams(arr).Dump();
}

public class Solution
{
	public int NumTeams(int[] rating)
	{
		int teams = 0;
		for (int j = 0; j < rating.Length; j++)
		{
			int leftSmaller = 0, rightLarger = 0;
			int leftLarger = 0, rightSmaller = 0;
			for (int i = 0; i < j; i++)
			{
				if (rating[i] < rating[j])
				{
					leftSmaller++;
				}
				else if (rating[i] > rating[j])
				{
					leftLarger++;
				}
			}
			
			for (int k = j + 1; k < rating.Length; k++)
			{
				if (rating[j] < rating[k])
				{
					rightLarger++;
				}
				else if (rating[j] > rating[k])
				{
					rightSmaller++;
				}
			}
			
			teams += leftSmaller * rightLarger + leftLarger * rightSmaller;
		}
		
		return teams;
	}

	// getting time limit exceeded after N was increased from 200 to 1000.
	public static int BruteForce(int[] rating)
	{
		int teams = 0;
		for (int i = 0; i < rating.Length; i++)
		{
			for (int j = 0; j < i; j++)
			{
				for (int k = 0; k < j; k++)
				{
					if ((rating[i] > rating[j] && rating[j] > rating[k])
						|| (rating[i] < rating[j] && rating[j] < rating[k]))
					{
						teams += 1;
					}
				}
			}
		}

		return teams;
	}
}
