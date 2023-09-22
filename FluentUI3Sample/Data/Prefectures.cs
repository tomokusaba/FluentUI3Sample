namespace FluentUI3Sample.Data
{
    public class Prefectures
    {
        public List<Prefecture> pref = new();

        public Prefectures()
        {
            pref.Add(new Prefecture("北海道", "札幌市", 5267762, "北海道"));
            pref.Add(new Prefecture("青森県", "青森市", 1227305, "東北"));
            pref.Add(new Prefecture("岩手県", "盛岡市", 1279594, "東北"));
            pref.Add(new Prefecture("宮城県", "仙台市", 2333899, "東北"));
            pref.Add(new Prefecture("秋田県", "秋田市", 966192, "東北"));
            pref.Add(new Prefecture("山形県", "山形市", 1123891, "東北"));
            pref.Add(new Prefecture("福島県", "福島市", 1848071, "東北"));
            pref.Add(new Prefecture("茨城県", "水戸市", 2863141, "関東"));
            pref.Add(new Prefecture("栃木県", "宇都宮市", 1946075, "関東"));
            pref.Add(new Prefecture("群馬県", "前橋市", 1973115, "関東"));
            pref.Add(new Prefecture("埼玉県", "さいたま市", 7266534, "関東"));
            pref.Add(new Prefecture("千葉県", "千葉市", 6222666, "関東"));
            pref.Add(new Prefecture("東京都", "新宿区", 13515271, "関東"));
            pref.Add(new Prefecture("神奈川県", "横浜市", 9163080, "関東"));
            pref.Add(new Prefecture("新潟県", "新潟市", 2221099, "中部"));
            pref.Add(new Prefecture("富山県", "富山市", 1042993, "中部"));
            pref.Add(new Prefecture("石川県", "金沢市", 1154008, "中部"));
            pref.Add(new Prefecture("福井県", "福井市", 767943, "中部"));
            pref.Add(new Prefecture("山梨県", "甲府市", 810579, "中部"));
            pref.Add(new Prefecture("長野県", "長野市", 2098804, "中部"));
            pref.Add(new Prefecture("岐阜県", "岐阜市", 1968733, "中部"));
            pref.Add(new Prefecture("静岡県", "静岡市", 3653099, "中部"));
            pref.Add(new Prefecture("愛知県", "名古屋市", 7483128, "中部"));
            pref.Add(new Prefecture("三重県", "津市", 1815865, "近畿"));
            pref.Add(new Prefecture("滋賀県", "大津市", 1412916, "近畿"));
            pref.Add(new Prefecture("京都府", "京都市", 2585889, "近畿"));
            pref.Add(new Prefecture("大阪府", "大阪市", 8824566, "近畿"));
            pref.Add(new Prefecture("兵庫県", "神戸市", 5534800, "近畿"));
            pref.Add(new Prefecture("奈良県", "奈良市", 1331335, "近畿"));
            pref.Add(new Prefecture("和歌山県", "和歌山市", 925000, "近畿"));
            pref.Add(new Prefecture("鳥取県", "鳥取市", 555634, "中国"));
            pref.Add(new Prefecture("島根県", "松江市", 685649, "中国"));
            pref.Add(new Prefecture("岡山県", "岡山市", 1914039, "中国"));
            pref.Add(new Prefecture("広島県", "広島市", 2843990, "中国"));
            pref.Add(new Prefecture("山口県", "山口市", 1355492, "中国"));
            pref.Add(new Prefecture("徳島県", "徳島市", 728633, "四国"));
            pref.Add(new Prefecture("香川県", "高松市", 956069, "四国"));
            pref.Add(new Prefecture("愛媛県", "松山市", 1350158, "四国"));
            pref.Add(new Prefecture("高知県", "高知市", 697112, "四国"));
            pref.Add(new Prefecture("福岡県", "福岡市", 5101556, "九州"));
            pref.Add(new Prefecture("佐賀県", "佐賀市", 824456, "九州"));
            pref.Add(new Prefecture("長崎県", "長崎市", 1368811, "九州"));
            pref.Add(new Prefecture("熊本県", "熊本市", 1740088, "九州"));
            pref.Add(new Prefecture("大分県", "大分市", 1123110, "九州"));
            pref.Add(new Prefecture("宮崎県", "宮崎市", 1074349, "九州"));
            pref.Add(new Prefecture("鹿児島県", "鹿児島市", 1619596, "九州"));
            pref.Add(new Prefecture("沖縄県", "那覇市", 1433566, "沖縄"));


        }

        public List<Prefecture> GetPrefectures()
        {
            return pref;
        }

        public Prefectures GetPrefecture(string name)
        {
            return (Prefectures)pref.Where(x => x.Name.Contains(name));
        }
    }
}
