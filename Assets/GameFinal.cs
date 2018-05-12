public static class Poker
{
	public static string[] Game =
	{
		"H8 CK S2 H2 H6|C2 D8 DK SA C8",
		"DK DT HA H3 D4|C4 CQ H4 S6 H8",
		"C8 S2 CJ DQ S3|H5 S7 H8 S9 H7",
		"C6 HT HA H3 CT|SQ H5 CK CJ D2",
		"H2 D6 CK SA S5|D4 HJ SK HA CJ",
		"H2 H6 C7 H8 C2|HJ CQ C5 DK SA",
		"DJ C7 DA DQ H6|SJ DT SA CK C6",
		"C4 H6 S9 D2 S2|HA HQ HJ HT HK", 
		"C2 H3 S3 S5 D7|D8 C9 ST D2 SK",
		"C2 C8 C5 S2 HJ|SJ DA SA DT S5",
		"C6 S5 H5 S7 D2|C5 CA C7 DT S4",
		"SA C4 SK HJ C6|DJ DQ D4 S5 H4",
		"C2 C3 SK D9 C6|H4 H3 DA C8 SA",
		"HA H7 C5 DT CJ|SK S8 DQ DJ C9",
		"S5 DQ CK DJ H9|SJ S6 D4 S9 D6",
		"SQ DK S9 HK D5|DA CA C5 H4 SK",
		"S6 DA S2 S3 S5|ST HQ HK C2 D8",
		"H4 C3 S9 DK C7|D8 S6 S4 S8 S7",
		"D2 H9 S2 D6 HJ|HQ H4 D8 S7 H7",
		"H5 H2 DA HJ D9|CA DK D5 SJ H6",
		"DQ S2 H2 C2 HA|H4 D6 C6 S6 S3",
		"CJ SJ S2 ST S9|C9 D8 C3 SQ CA",
		"H5 SA D5 H4 C5|H6 S2 CT D2 DA",
		"CK D9 S4 S8 S6|DQ DJ DA D6 C6",
		"ST H2 C7 S6 CT|CK C3 SA D3 DK",
		"D5 C3 H8 C5 HJ|S4 D7 DT S8 S9",
		"C4 SK C7 S3 H4|H8 S9 C3 S2 CJ",
		"SQ HQ H6 D3 H3|CA H4 S3 S6 C9",
		"H4 CJ DK DA S9|C5 DJ CA SQ C3",
		"S7 HT H7 CQ H4|S9 CJ C2 D4 S4",
		"SK ST D2 CA DK|C5 HQ C7 S5 CT",
		"D4 CA H8 C8 S9|D5 HJ D8 SJ H6",
		"C9 HJ H5 HA DQ|CA D4 CK DK SK",
		"ST D5 C2 H9 S7|SA S3 CA D7 CJ",
		"C6 HJ SA S5 HK|DK HA D8 C8 S9",
		"C3 DT SJ H6 S8|S6 ST D5 D9 C4",
		"D2 S2 CQ SK D4|D3 H9 S9 H8 D6",
		"CT H5 C6 C7 H2|S7 DQ C9 H6 S3",
		"CK D4 H8 C6 CJ|S4 S2 D6 SK C9",
		"D4 ST D3 H5 C5|D5 C2 S8 D7 H8",
		"C8 SK CJ H8 ST|S5 H3 D4 H4 C5",
		"HA CA D8 S4 C9|SJ C8 CQ SK D9",
		"CT C6 SK D3 SA|C3 D6 HQ D4 SQ",
		"S9 HT CA H8 C5|H7 HJ H2 CQ S4",
		"CK S6 H4 D5 D7|D8 D2 S8 HJ DT",
		"C8 ST C5 H8 CT|CJ C6 CA H2 DJ",
		"D3 C8 SJ H7 DQ|C7 C3 C5 C6 C4", 
		"D2 DQ SJ S7 H7|ST D4 C4 S9 C2",
		"HQ C5 H2 S7 SQ|DA H5 H6 CJ D8",
		"S2 CJ SQ HA S6|S3 HT H6 C7 CA",
		"DQ C8 DK S6 CQ|CA HK H2 SJ C3",
		"SA H8 D3 H4 H6|HA HQ DT SQ D5",
		"C3 ST C7 HK DJ|SQ HA C4 SJ H3",
		"CQ D5 HA S4 DK|H8 DT S5 SK S9",
		"C7 S3 HJ CA H8|H9 S2 C5 HA D8",
		"C3 HA H5 D2 HQ|D9 C6 HJ H9 C8",
		"D2 CT S4 C8 SA|S3 CA SQ H5 DK",
		"DT S4 H2 D7 CA|ST D9 C3 DJ HK",
		"HQ DT ST SJ CK|C4 H7 SK HA C2",
		"D3 D9 C3 D6 H6|CT SA H5 C6 H7",
		"C5 C2 D5 SA CA|DJ H9 DT HA C9",
		"DK S2 HA C6 D8|SJ H3 HT C3 HK",
		"H6 HK HQ DQ CQ|D3 H5 H8 D8 D2",
		"H9 CQ CT D9 C9|SQ HJ H4 S6 S3",
		"H3 S2 SA D7 H7|D4 DQ C7 DA S8",
		"D4 S5 C5 HJ S2|H2 C7 ST C4 H3",
		"SK H9 S8 D2 H5|DA H8 S4 SJ D4",
		"D4 SJ DT CK H4|D6 S6 H7 D9 HK",
		"D3 S3 SA H3 H5|S2 S8 HK DA HQ",
		"S8 H4 C7 C5 D2|DA H2 C6 H5 HA",
		"S5 D4 D3 CJ D2|DQ DK DT DJ DA",
		"C5 DK SA D9 HJ|DQ DT H8 HK HA",
		"S8 S5 DA S3 S4|D5 HJ SQ C6 SK",
		"S5 H9 CQ HA CT|D3 DA D6 S4 C8",
		"D2 HA DK C8 H4|D7 C7 C4 CQ S9",
		"D9 SK S8 C6 D7|C4 HT H8 S9 C2",
		"C2 D4 DQ H8 S9|HT D8 SJ CQ DK",
		"H8 H9 D7 S3 H5|HA CJ S2 SK C3",
		"D4 ST H7 DJ C5|C3 SQ C9 DQ C4",
		"HQ DJ C8 HJ D7|CT CJ DK H2 SJ",
		"S9 C7 HK H5 S6|C2 C8 S7 DK CK",
		"CK DT S4 H5 S2|C8 DA HJ D2 D9",
		"S3 H8 DT S8 H9|S6 CQ C6 H6 DA",
		"D2 HT H4 CQ SQ|S5 C5 H5 S9 D5", 
		"SA HA C3 HQ S3|S9 D6 CT H2 S8",
		"CA H9 D9 CJ H8|D8 D4 DK HT H4",
		"C4 H8 H9 H2 S7|C8 D3 D2 C3 D7",
		"S7 DQ DJ DA S6|C7 HJ H7 D7 CA",
		"H4 DQ CA HT H6|C8 H2 D4 S3 D9",
		"C2 CT CJ HQ S9|H5 D3 S4 C3 ST",
		"SJ H4 H9 C8 D4|CQ CJ C7 HT H3",
		"SA DJ CK D9 S3|H8 SQ D4 S4 DT",
		"C2 S3 C3 H2 HQ|SQ SA H8 DK HK",
		"H8 DK CT D3 D4|D8 D7 H2 SK H4",
		"D6 H2 H5 SQ C2|S5 S8 C4 DT HT",
		"S6 S4 SK CQ HT|ST DJ SQ C9 S9",
		"S6 S2 SQ D4 S8|CA CT SJ H7 H2",
		"DA SJ H8 C9 H2|CK HJ C2 H4 D4",
		"S3 D6 C2 H4 SK|S7 HA D4 DA C3",
		"S9 D3 H8 DQ S8|H9 HQ DK D2 H5",
		"C4 D6 S2 S8 SK|DT S9 CJ H4 DA",
		"DJ D3 S3 CQ HJ|HA DK S5 SJ S8",
		"C6 D2 H4 HA HT|D5 C7 CA HJ SQ",
		"C6 SA D2 D8 C7|C3 HK ST D5 D3",
		"HT C2 H7 D3 D8|CT HQ H4 C3 DK",
		"S9 H9 S6 CQ HJ|S3 H2 C5 C9 H6",
		"H8 HK ST DA DK|S7 SA H3 S8 DJ",
		"DT H9 SJ H4 DK|DA H2 C3 C7 CK",
		"DA S6 H3 H6 C9|HA D5 S3 C4 D7",
		"H2 C4 D9 C9 C2|ST H6 DQ S4 C3",
		"CA H6 HA CJ DQ|S2 DJ D9 CT CK",
		"D2 C9 DK HK CQ|D5 CJ D3 C4 D4",
		"SQ S8 CT HQ S9|H8 H9 H4 C2 C5",
		"ST D4 S4 D3 C9|DK D9 HK H8 D6",
		"D6 S4 H8 CT HA|DQ DJ DA HJ D3",
		"S9 C3 S5 DA HJ|H7 C8 C4 C7 HQ",
		"D3 C7 DQ SJ C4|DA S8 SA H5 S3",
		"CJ HA D7 D2 DK|DA S7 H5 H7 SQ",
		"C2 HA SA S5 S4|H2 HK CJ S8 SJ",
		"C3 H3 CA H7 H9|SJ HA S7 S3 D4",
		"C2 D2 SQ S8 S7|H5 H6 C6 H8 D6",
		"DJ HA DK SK H6|HQ S7 H3 S6 ST",
		"S6 D6 H9 SQ C2|D4 S5 D5 HQ HJ",
		"H2 H8 DK SA C9|SK D2 D8 D9 CT",
		"CQ HQ C2 HK SJ|S2 S4 D4 D6 D8",
		"CA D5 S4 S8 D2|HT C7 C8 HQ CK",
		"D8 C9 D6 HT S7|H3 S8 HQ DJ C2",
		"S5 D9 H7 H6 C5|SQ SJ CJ C3 SK",
		"C4 D9 D5 C5 H5|DJ SJ DT CJ C7",
		"SJ CQ DA C2 D3|H4 C3 D4 SA C9",
		"CQ SK D4 H3 CJ|H2 D8 D9 S9 HT",
		"S9 ST SJ SK SQ|D5 C8 SA HQ HA", 
		"S4 S3 H4 C7 CJ|HA D2 CT S2 H9",
		"C8 SQ S3 CT H9|DJ SJ HJ H7 S7",
		"H8 C7 S2 H9 CJ|S3 HA H5 D2 DJ",
		"SQ CJ C7 S5 DA|HJ S3 HK C3 CT",
		"H4 CT S8 C3 C9|CJ SK ST CA SA",
		"C6 D5 HQ C2 H8|SK D2 C5 HT CT",
		"H6 C5 S8 D3 H3|S7 D8 HQ ST S2",
		"S8 SK D2 C7 D6|S5 HJ HQ HA DT",
		"DK D6 HT D7 H6|ST DT H5 CT S7",
		"S7 H8 HQ H5 C5|CT DJ SK D6 D3",
		"D9 C3 D6 C6 D3|S8 C2 H8 DA HJ",
		"S2 H2 CQ CT H9|C3 S9 CK C7 H6",
		"H6 C9 S3 CA C2|HA CQ SA CJ S6",
		"S3 HT SA DQ S5|S9 HA D2 DJ C3",
		"D8 HJ D3 DQ S7|S3 CJ D4 C5 CK",
		"S4 CK H7 CT DT|D2 D3 CQ C2 D5",
		"DA H6 DT DJ HJ|DQ CA D3 CT C4",
		"D9 DT SJ CT C5|C4 C6 HK S5 H4",
		"H4 SJ C2 CQ DK|HT C9 SK CJ H7",
		"S4 H6 D7 S6 C7|D2 HA CK DA S7",
		"H6 C3 C4 D8 HA|HK H8 D9 H3 DA",
		"S7 C5 D7 C8 H8|CT D3 DT H6 HA",
		"S7 D3 S9 SJ D9|DA D4 SQ CT CK",
		"HJ D5 D8 H5 DA|C8 CQ C9 CT CJ",
		"DA S6 C2 C9 DT|S7 C5 CQ C7 D3",
		"H3 SJ D4 H7 H9|DT DJ H6 SQ S4",
		"DT H9 S8 C6 DJ|D7 H3 HJ CA S6",
		"D6 D9 HQ C5 HT|S2 H7 C4 C8 D4",
		"HQ S4 S6 C8 H4|HT D6 DJ HA D2",
		"S4 SA HT H4 S7|C4 CK SQ H2 SK",
		"H2 S3 H3 CJ DJ|H4 HJ SQ H7 SK",
		"C6 D9 C2 CA HA|C5 DJ H4 D4 H5",
		"D9 S9 D3 SQ HA|H7 C3 HK H9 D6",
		"HA DQ D5 H5 CK|C9 H4 SA S5 HK",
		"CJ C3 SQ SK HJ|HK S9 D3 S2 D4",
		"D6 D3 S2 H9 D7|HK H8 D9 D5 DA",
		"H9 H7 C4 SA C2|C7 DT CJ H6 CQ",
		"S3 SQ SJ H8 H4|HQ S4 HJ D2 S7",
		"S8 H9 C5 H2 HA|S9 D3 CK CA HJ",
		"S3 CT D5 C8 HJ|HT S5 SQ D4 DJ",
		"S4 HA H6 SA C2|CA C7 DJ ST D5",
		"D4 C6 HQ H5 D5|H7 H4 SA D9 SQ",
		"DK CT HA DQ DA|H3 S9 H9 CQ C5",
		"HQ S4 CA S2 CJ|D4 D6 HK C4 SQ",
		"SK S6 D6 C7 CJ|D4 H7 H4 HA D2",
		"D6 DQ C6 C7 D7|C8 HQ H9 D9 CA",
		"S8 C3 S2 D8 S4|S5 D9 D7 CJ D6",
		"S7 C6 H9 DA C9|H4 HJ D9 H6 D2",
		"HJ D8 D7 H2 S2|D3 CJ DK S4 H6",
		"H5 C6 H3 S7 H7|CT HA CA C9 D8",
		"D7 DA S9 C8 DK|D3 C2 SA D9 D4",
		"D9 S6 S4 HA DQ|S2 CJ CK SQ C5",
		"S6 CQ C4 SJ S2|HT H6 D7 D9 HQ",
		"CK CT H6 HK H3|C8 D4 SA DT D5",
		"D9 S5 DQ D4 ST|S4 S7 DA S2 CA",
		"C4 H9 SJ S5 S2|DK D7 HQ S8 D8",
		"SQ D9 H2 D7 SK|HJ D6 SJ H9 HK",
		"D2 DK S2 CQ H6|DJ DQ S5 S7 SQ",
		"D9 CJ HQ D3 H8|SQ S6 D8 CA S7",
		"D4 S3 H5 SQ C9|HK DJ DK D7 C2",
		"D5 H4 C8 H6 H9|H2 D6 CT H7 S2",
		"C8 S5 D7 D3 C7|DJ S4 S3 H5 D5",
		"SQ H7 HK DT C8|CJ SA S6 D6 H6",
		"S2 HJ H2 H7 SA|S6 S3 D9 SJ D6",
		"SK SJ CQ C4 C2|DQ DT SA D5 D8",
		"D3 SA S4 C3 D8|C4 HK DJ SQ DT",
		"DJ D2 D9 HK C4|D4 D5 C6 D7 H7",
		"C5 CT C4 D2 SK|H2 C6 DQ S6 D6",
		"D9 H2 S4 H4 C2|CQ HJ C8 DQ C7",
		"D2 SJ H7 S5 HK|H4 DJ CA HJ S7",
		"C3 H8 D3 DT H3|DA D8 S5 H5 H6",
		"S2 S8 HJ DA DQ|H8 CT S3 ST DJ",
		"C3 D6 D4 CJ C2|H5 D3 D8 D5 DA",
		"HJ C6 D9 D2 CK|DQ C4 H9 H8 D5",
		"D2 CT D8 C9 SQ|S7 HT CK D3 D7",
		"D2 DQ C2 C5 C8|S2 C6 SJ S3 D8",
		"CT HA D3 DJ C4|HJ S5 S3 D9 H6",
		"H3 C3 DA S4 D8|CT H8 S8 H2 H9",
		"S7 CQ S2 HA C9|HQ S4 CK H9 S3",
		"D9 D3 S8 S2 S4|H2 CJ DJ H5 S7",
		"CK SQ S6 ST SJ|CQ S4 SK H9 HJ",
		"DA HJ H2 SQ C6|C5 DT D9 D6 CT",
		"C3 S4 C6 H4 DT|CJ D7 H8 S7 H5",
		"S8 C6 H8 C4 S6|C9 C8 H9 D4 SJ",
		"H6 H8 CT S6 H2|S8 DQ DA D4 D5",
		"C3 C2 DJ D9 D3|HT CQ D8 H6 H4",
		"CA S5 H7 C9 SA|H9 SK C3 H8 D2",
		"D2 D6 SQ C7 CT|DJ CA C5 H8 SJ",
		"CT C2 H4 HK D6|S4 SJ HQ S2 DA",
		"C6 C8 C2 C7 C5|CJ D4 D2 H3 H8",
		"C2 HA C5 H4 HK|CT S8 C7 HQ CA",
		"S9 S4 HA D8 S2|D6 CK S7 S3 H7",
		"H3 DJ HQ H8 HK|C5 SK D2 S8 H2",
		"S4 DQ C2 S2 HJ|SA C4 C5 S5 H9",
		"S4 D4 C7 ST H7|C8 H8 H5 D8 S8",
		"D2 CT SJ SK C3|DA D9 D5 C5 H7",
		"H2 CT D6 CK DJ|D9 DA C7 S2 S6",
		"HK H8 SA DT C4|C5 CA C2 DK C3",
		"DJ H3 SA C6 SJ|S6 H4 C5 CT SQ",
		"C3 CT D4 S6 H5|C2 D9 HT H8 D8",
		"H6 H3 C3 D2 D7|HT S3 D3 H8 S6",
		"D9 H2 S2 S4 CQ|SA SQ H6 SJ H9",
		"H3 H6 D3 DK CT|SA D2 C9 CA D9",
		"HK S2 S6 H3 CQ|H9 S7 C7 H4 HT",
		"H2 D6 S7 HA H3|H5 SQ CA SJ HK",
		"CK CJ SQ H2 H4|S8 S7 C9 CQ SJ",
		"S9 HT D6 C9 H4|D4 D2 H6 CT DA",
		"H6 DK D5 H2 HK|H8 D9 H3 CK H7",
		"SK D7 HJ H2 S4|C9 D8 HA HQ C5",
		"S5 D7 H5 H8 DQ|C2 HQ D2 HA C5",
		"CJ H4 H3 H8 SJ|HK D3 CQ H9 C7",
		"C6 C2 SQ C5 H7|H5 DQ HK D7 C4",
		"SJ HQ C9 DQ S3|HK DA S5 D3 H9",
		"HQ CA D8 HK D4|CK S8 CQ DA H6",
		"D6 SQ S5 D2 D9|H4 HQ H3 C7 D7",
		"H7 D5 CA H9 CT|HK C9 D6 SK H5",
		"D6 C7 S6 HT SA|S3 HQ S2 DA H7",
		"S6 CK DQ S7 CQ|D4 C8 C9 D8 H7",
		"S8 H6 C7 D6 SJ|HT S6 DQ HA SQ",
		"D3 S4 H8 C4 H9|SA S2 D9 DJ H6",
		"H9 HA S9 C5 CA|CK C9 DJ DQ C8",
		"SA S5 C9 H6 ST|H9 C2 CJ HA S4",
		"CQ S2 S6 DA CK|CA S5 H3 S8 HT",
		"DK D7 SQ ST HK|HT SK HQ S2 C2",
		"S2 S6 H7 DA CJ|HQ D9 H3 D5 SJ",
		"HA C6 DT ST C3|S4 DQ D5 HJ S8",
		"C7 CQ CK CA S9|S8 SJ C8 DJ D2",
		"H9 HK D2 HQ C4|D9 C5 H2 H5 S9",
		"DK D3 D6 D8 C4|CK S2 H2 D5 H5",
		"DK S6 H7 C3 SK|HT D8 S9 H9 D6",
		"H7 S3 CQ S5 DA|D5 H8 HT C7 HA",
		"C7 DJ HT D4 D5|C2 CJ D7 D8 H9",
		"S4 SK D4 D3 CJ|H5 S9 HQ H9 C4",
		"H3 D7 C7 S6 D3|SQ D2 H9 HK C5",
		"H2 H3 D9 SJ HA|D6 S9 ST HT S3",
		"C3 SK S7 DK S8|D2 D8 DT ST H2",
		"H9 H3 CQ D4 S2|H8 S5 DK CJ SJ",
		"D6 S6 SA H7 C5|ST C3 S3 DK HT",
		"CT S5 C2 D7 DA|H7 H5 CK H3 H6",
		"S5 D8 DT DJ S6|D2 D7 CQ H8 S9",
		"C9 S6 S9 H5 H2|S8 CJ H8 DA D9",
		"C3 H5 S3 H6 D5|H4 H9 S6 CA ST",
		"D2 S9 SQ D4 DA|H5 DQ H6 H2 C9",
		"C5 D4 DA DJ C9|C8 D7 DK DT S7",
		"DK CQ H2 ST DA|D2 C2 C7 DT H9",
		"H4 SK HK D2 S8|HQ S3 D8 H2 DQ",
		"D6 C9 S9 S5 D3|H9 H2 D2 HA C4",
		"S9 H7 C5 C2 SJ|D5 C7 SA CA DK",
		"C3 H6 S7 H8 C8|S6 D4 D9 DK HA",
		"HA ST CQ S4 DK|HT DJ C4 HQ H5",
		"S7 S8 C6 C2 C9|D8 DJ H9 CA D7",
		"SQ S9 C5 DA H9|D7 SJ C4 CQ C2",
		"H4 HQ H8 DA S6|HA SQ D9 DT D2",
		"C4 D6 C3 HK C7|HJ H5 HT D8 CT",
		"S2 D8 S5 D4 H5|C8 D7 C2 D9 DT",
		"SQ CQ C9 D5 S5|D4 H3 S6 HK DQ",
		"D9 H4 C3 S5 DK|CQ C9 S8 H5 H8",
		"S5 HA HJ SQ HK|H7 SA D8 H2 HT",
		"H2 ST C3 DK HT|SA D7 CQ S7 H8",
		"S4 CK CA DJ C7|CJ C4 HJ CT H6",
		"D3 H5 CJ SK HT|CA H9 H3 H6 S5",
		"HK HT DA H9 CK|CT CQ C2 S5 H8",
		"HQ H8 D9 C7 H2|CK HK D8 H3 S7",
		"C9 HQ SK D3 CJ|D7 S3 H6 HA H5",
		"SQ H2 D2 C3 S7|DT ST H8 H3 CQ",
		"ST D7 HA H2 CQ|C2 D9 DA C4 D5",
		"H5 DJ S2 H6 ST|SQ C6 D4 S8 DQ",
		"D6 D8 H9 H2 S7|CQ DT C5 S4 D3",
		"DA H3 S2 S8 S6|S3 SA SK D2 S5",
		"S3 C9 H8 S6 D8|DT CA C8 CK HQ",
		"C7 C8 ST H7 D8|DJ D6 H8 H6 CJ",
		"S7 ST D3 H9 S4|SQ SK CT HK S3",
		"SK SQ D2 C9 S7|HT C6 C7 H3 HA",
		"S7 H9 S2 HT H5|CT H2 S5 S4 H7",
		"HK DA S6 SA C4|H5 CJ H3 D3 H9",
		"HK H5 S5 HJ CT|SK DT S7 D2 HQ",
		"D4 H3 SJ S2 D7|CT DT HT CK S7",
		"SK D5 HK S7 HQ|SJ C4 C9 H3 CA",
		"SA D3 C5 H7 DK|CT D4 DJ H3 S2",
		"S4 S8 S3 HK D9|C3 CK D6 H7 DT",
		"CT D7 S2 S3 C9|C6 HQ CA D8 S4",
		"D4 H4 S5 CQ D3|H2 HJ S4 H6 S6",
		"CQ DT S2 DK C9|DQ C5 SJ C4 H2",
		"C9 H7 S8 SJ H2|H9 D8 D7 CT DK",
		"C2 D7 SJ HA CK|D5 H2 S7 S8 CA",
		"CQ D9 H2 S3 S6|C7 H4 SQ SA D6",
		"HJ H6 CQ H7 H3|D9 D5 DK S5 S2",
		"D5 S5 SA CJ C9|C2 H3 C7 H5 D7",
		"DT HT H4 SA D6|C4 CQ S3 HQ C8",
		"DT H2 C6 D2 DA|SQ C8 S8 CA CK",
		"S9 D9 H2 CA HT|C3 H4 C6 S8 S4",
		"SA ST H7 S5 C2|DA HQ CJ D6 DK",
		"C4 H5 HK D4 CT|D2 C6 DQ SJ DA",
		"H9 D3 D7 CT S3|HK SA H8 DK C7",
		"DA HT HQ C4 H2|ST H7 C8 SQ H6",
		"C9 SA DQ D9 D8|CQ H7 C6 DK ST",
		"S4 CT HT H8 S2|CJ D7 H3 SQ H6",
		"HT DQ DT H8 SJ|S7 C4 S8 SA HQ",
		"D2 H3 SA H6 S3|HQ DA D7 ST H4",
		"C6 HJ HK D3 DT|C7 SJ C8 HQ S2",
		"S2 S4 DK HJ DJ|S6 S3 D7 DA ST",
		"DA D6 S9 H6 DJ|H2 S6 C7 C8 SJ",
		"SA C5 SQ DK CA|HA CQ H3 D3 SK",
		"S9 H9 D8 C7 C3|CA S4 CJ D7 CT",
		"H8 SQ S7 S9 SK|H3 C5 H6 H7 C8",
		"C9 H5 CJ H7 C3|D4 C7 H8 S9 HA",
		"S2 HQ SQ D6 SA|ST CA C9 H8 HK",
		"C7 CQ CK C2 DK|C9 ST DT D9 H8",
		"H5 H8 CA HJ D3|CK C8 HT S4 H3",
		"SQ DQ ST C5 S4|D6 HT H9 H8 C4",
		"C8 DK S8 SJ HT|C2 S2 SA D8 D2",
		"S2 HA DK C7 D6|H4 SQ S9 SA S5",
		"D4 H9 C4 CJ C5|H4 HT D6 S8 D8",
		"H8 H2 DT S9 S8|C7 S3 C5 D5 D8",
		"DJ CJ C2 D3 H3|S7 SA HJ HK DQ",
		"D7 CA S3 H3 S5|C6 H2 HT D9 D8",
		"ST H8 C6 H2 HT|H5 S9 D4 SJ D8",
		"CJ DQ C4 H6 SQ|C2 DA DK S4 H4",
		"D6 S2 SQ HQ D9|SK C9 D3 S4 ST",
		"D3 HQ S7 C4 H6|S3 CJ C9 HJ DQ",
		"HK SJ C8 SK S5|HA S8 D6 S6 S3",
		"S7 H2 D4 S9 C8|S4 D3 HQ D7 CT",
		"S7 HK C2 H7 D7|ST D9 HJ S6 C9",
		"SA D5 S7 C5 DT|HQ D9 CT C3 H9",
		"D2 SJ S2 C7 S6|S4 HJ DQ D5 D4",
		"H3 S3 D4 CQ HK|D6 C5 C9 D5 S2",
		"D8 S8 D5 S3 D4|D6 C7 H9 H3 S7",
		"D3 D4 S2 H6 CK|SQ D9 DT DQ C7",
		"S5 CA HQ D3 CK|CT C7 H5 HK C8",
		"HJ HQ H5 D3 HK|S4 S9 H4 C8 D5",
		"H6 S5 D2 H9 CT|CJ ST H5 S9 C4",
		"C4 S3 DJ HJ C7|H4 C9 C8 C6 SJ",
		"HA C8 S8 S5 DA|H8 H4 C5 SJ D6",
		"S5 C4 DT H2 H4|HT HA S6 H8 S7",
		"S8 H2 C9 HT CT|DJ SK C6 D6 C2",
		"S9 DK S4 DA D2|SQ D7 HJ SK CA",
		"CA H9 DK CJ HK|SA D6 S3 CQ H5",
		"S9 C7 H9 C8 C5|S6 CA D8 C2 HT",
		"C3 S6 SJ CA H5|CQ DK CJ D9 HK",
		"C5 S6 HK D3 D6|S3 H4 CA HQ HT",
		"HQ SA SQ C9 SJ|C7 D8 D6 D7 ST",
		"CQ S7 S4 H3 CT|H9 HT H5 CK DJ",
		"DA HJ CJ SJ D3|H5 HQ SQ S7 C3",
		"C3 S6 C4 CJ H5|D4 S7 DK CA SJ",
		"H2 HA D8 C8 DA|C2 CQ HQ SJ D3",
		"SK DA H2 D6 S5|H8 H4 D8 SQ D4",
		"C8 H8 CT DT D4|D6 HJ SJ H6 H7",
		"C8 CK SA H6 H7|S3 H2 HK C3 DK",
		"C8 ST D5 S2 S6|DA H3 DQ D2 HK",
		"D2 SQ SK D3 D9|D4 ST H3 H8 D7",
		"S4 D6 C5 C7 CQ|CK CA S9 SK H2",
		"HT S7 S3 D7 HQ|CQ H9 SJ DT C8",
		"CA H7 CT D8 C6|S4 C9 H4 S7 HK",
		"H4 C8 H3 C6 SA|S2 C4 CQ H7 HK",
		"D2 HJ S9 C4 C6|C2 HQ D6 C5 H4",
		"D9 C7 CK HT H8|S5 HJ DJ S9 D6",
		"SA C6 C2 H4 D4|HK HA D2 D8 H5",
		"C7 HA S6 S9 H4|SK H6 HT SA C6",
		"D5 DT H8 H6 DJ|S7 DA S5 HK C6",
		"C3 S8 H3 CT SQ|DA H8 D9 D6 HJ",
		"CA S6 CJ C5 C7|C8 C4 S4 D2 DQ",
		"S7 H3 S5 CA S3|ST H2 DJ C6 S6",
		"D9 H3 S8 ST H7|C4 HK S2 H8 D3",
		"D7 D8 DJ HQ S4|S2 S3 CA H2 SK",
		"D9 S3 H5 H8 HA|D5 H2 S9 C8 C3",
		"S5 S4 D9 HK D6|H9 H4 CT DT D5",
		"S4 D7 H7 C3 C9|S9 HK SK H8 CJ",
		"S4 SA D8 HQ ST|S7 SQ CT H3 HT",
		"S7 D8 DQ S2 SJ|S4 CT C2 D6 S3",
		"S9 S4 H5 C5 CA|D9 CJ S6 ST HA",
		"SK CQ C4 D3 DK|C5 SQ HJ DQ HA",
		"D9 CK H5 DK S4|C7 DQ S7 SJ C2",
		"C4 DJ C5 S3 C2|H4 S2 S8 S4 D5",
		"S5 C7 CA C6 DJ|D7 H2 D5 D9 C2",
		"H5 D7 C4 H4 S2|S6 HQ SK ST S5",
		"CK H8 S7 SA C3|DJ DT HT D6 H3",
		"C4 CK D7 DA C3|DJ S8 D8 DQ SA",
		"ST HT C2 H3 HJ|D4 S4 H6 D6 DJ",
		"CT D6 CK D8 ST|DT C6 CJ HQ DJ",
		"DJ H6 DQ D5 D4|CQ H5 HQ C6 H2",
		"D9 H9 H2 DT SQ|C5 D7 DK SJ S6",
		"D6 DJ S8 DT C2|CJ HJ S9 HQ S3",
		"S8 SA D6 ST HK|S2 SK CA DK H2",
		"H3 D2 D8 S9 SK|H2 D3 HA DA S2",
		"CA HT ST H2 D7|D5 S4 DT DA H8",
		"H8 ST S2 HK D7|D4 SK SQ D9 DQ",
		"ST S7 C2 S5 H7|H4 S3 HJ S9 H8",
		"CQ ST HA C5 D5|D4 D8 H5 SK C3",
		"C5 C8 CQ C3 H4|SK C2 DQ D4 SJ",
		"HQ DK S2 DJ HA|C5 H8 SA SJ H3",
		"D4 C6 DK HQ DJ|HJ CQ S3 CK H8",
		"CT SK HQ H5 HJ|DA D3 CQ CA D6",
		"H2 SQ S8 H3 C4|HQ CA C6 C7 C5",
		"D9 H7 H8 C5 HT|CT HA D6 S5 CQ",
		"DK CJ DQ H4 S8|S4 S9 HK H8 C7",
		"C4 CJ D2 CQ S2|H9 C6 H2 S3 H3",
		"D4 C2 HA D5 CT|CQ D9 S3 ST H2",
		"S4 C7 HA SJ C8|S6 DQ C4 S5 S7",
		"H8 H6 CA H9 S2|S6 D5 H5 D9 HT",
		"S2 D9 H7 S8 SK|DQ HK DK C5 C8",
		"CJ H9 S9 S2 HA|H8 CK SK D5 C6",
		"CQ S7 D7 C2 DQ|DA S2 DK CA S5",
		"S2 H6 C7 C5 SK|D5 D7 S3 CQ S5",
		"CA S9 C3 S3 C8|HK H6 DJ D2 C7",
		"CK S5 D8 H3 CA|D2 S7 HJ HA D5",
		"DQ CJ CA D8 S7|H6 H8 H4 D7 D4",
		"S7 C3 CA HJ H5|SA S3 D3 S5 ST",
		"H7 SA S3 HQ DA|D9 DQ S2 H5 H3",
		"S6 C8 HJ HK D5|D3 SJ DK C3 H5",
		"H6 CQ SA C7 SK|CA D9 DA D3 HK",
		"HK S8 H3 DK H4|D6 HA D9 S4 H6",
		"DA CK SJ DJ C2|SA C9 S7 CT H6",
		"CQ DK S8 S6 SK|C4 HA SQ H9 ST",
		"C4 S4 S8 D9 S5|SA H4 H5 S2 S7",
		"C8 DJ H6 H4 D7|H7 D2 C3 S4 DA",
		"H9 D9 DJ H2 DQ|C8 CT D6 H6 SK",
		"DK C8 HK H9 D8|CQ D3 SK CA D6",
		"S3 D6 C4 C2 CQ|C6 H8 DQ HA D8",
		"S8 H7 HK S3 CK|SJ H2 SK DJ H3",
		"DT CJ C3 DA SJ|D2 S3 CQ H9 CA",
		"D7 C7 C3 CK D9|HQ DA CJ SK S9",
		"C7 S7 D9 CK CT|D5 S2 DK HQ DA",
		"S7 D6 SJ H3 H5|D7 H4 S4 S8 DT",
		"CQ ST S9 DA HQ|DT D6 C7 D2 S6",
		"D9 D6 S9 DQ S5|HK CJ HJ C4 CQ",
		"C3 D4 C8 C7 S4|CA HJ H9 S8 D3",
		"SQ D3 C4 H8 ST|DQ S5 C7 D6 C8",
		"S8 S6 C9 SA CT|SQ H2 D7 H4 C2",
		"H8 D2 DK S8 D7|S9 C7 D9 SJ S4",
		"S2 HT CJ C9 DJ|S7 SK D7 C8 C5",
		"CJ CA C7 S5 HK|D7 HA H3 H6 H4",
		"C3 C7 H2 D4 HJ|D3 D8 D2 CQ H5",
		"D8 S5 H9 ST SQ|S7 HT D9 C5 S8",
		"SK DQ ST SQ DA|H9 C8 D4 H7 DK",
		"C6 HQ H6 S4 H5|HT CJ S8 H2 S6",
		"D8 C9 H3 H5 CT|C5 S9 S4 D7 C8",
		"C5 H4 H3 C2 C3|H6 DJ HT CT H5",
		"S7 S2 SQ D5 SJ|HA HT DK H5 DT",
		"D2 C8 HK C4 S5|D4 HQ D5 CJ SA",
		"S2 S4 H8 D5 D8|HT D4 H6 HK C8",
		"DJ D6 C5 HK HT|HJ C8 C9 D7 H6",
		"H3 C9 C5 C6 S5|H5 SQ D4 CK SK",
		"C5 DA D2 C8 C4|SJ S3 SQ H9 H6",
		"D8 D7 CQ C4 HK|D5 SK HQ S4 DK",
		"SQ C9 CK D7 S7|DQ HQ S8 D3 DJ",
		"S3 CJ S4 S2 C4|H6 DQ C6 H5 S5",
		"D9 DT CA ST D3|C8 H4 DQ SQ D6",
		"D2 D3 H9 SK D5|H6 ST H7 DQ SQ",
		"DQ CQ DA C8 DT|H9 D8 ST C5 S2",
		"C8 S8 D9 D5 D4|HQ D2 S7 SK CA",
		"C4 S8 D3 DK D2|S7 S2 C6 D5 HT",
		"CA H4 HK D3 C2|H8 SA CK D2 C6",
		"HQ H5 D4 H9 SQ|HA H2 S9 D3 SJ",
		"DT C5 DK S8 ST|C7 D5 S6 SJ H7",
		"H9 S2 S8 C7 S4|DQ S3 H2 DK D2",
		"S6 CQ CJ SA H9|DK C8 C3 S5 CA",
		"SA DT D8 D3 C8|SQ D9 D4 DA H3",
		"S3 DQ CK HA C7|S9 H6 H2 H7 D9",
		"DQ C8 S8 S6 S5|SK S4 HT CQ C3",
		"S5 C8 S9 HJ H8|C6 CQ D7 D5 S7",
		"D2 SJ S3 SQ CA|CT H4 S2 C7 DJ",
		"H5 CQ D7 SK CT|DT D5 DJ S3 S5",
		"D5 DQ HK CT C5|C4 S8 S4 SQ H9",
		"D5 H3 CT D9 H8|C2 DA DT C7 D6",
		"D2 S7 D8 C8 H7|S3 C3 ST H4 D6",
		"CK H9 DJ C7 D4|C8 D9 DT S6 CA",
		"D6 CQ S5 H5 C3|C4 DK HT H3 H4",
		"H2 CA C8 DQ C4|C2 S8 C9 ST H8",
		"D4 H6 S4 C4 HA|S2 D8 S8 HK H8",
		"C5 S4 ST HT SQ|H6 D3 DQ CK C6",
		"D4 CJ S8 S5 C5|D5 SJ DA C9 DQ",
		"HQ S9 H4 ST S7|H2 D9 C8 H3 SA",
		"C6 S3 S8 DA CA|SJ C4 SK S5 H3",
		"CT C3 HJ H7 CQ|D2 S2 DJ CJ HT",
		"S2 C2 HK D3 ST|D9 SK C8 S6 H8",
		"CJ H8 H5 DK D6|DJ D5 S9 C3 SK",
		"DJ D4 S8 H3 C2|S7 HA D9 H6 SQ",
		"C2 S2 CJ SJ D4|C7 H9 C8 D9 D8",
		"DT S9 C5 CQ C3|C4 H8 H2 H3 SJ",
		"D6 C2 C7 CJ S2|C8 D2 SQ CT HJ",
		"S9 C6 D7 DK SJ|C9 H7 D2 HT DJ",
		"DK S2 SJ H7 D4|CT S5 DJ ST D5",
		"D9 S8 CT DK C8|H7 DT C2 HK H6",
		"S6 D4 ST C4 DA|S9 SK C8 D6 D9",
		"CQ CJ H4 S9 C9|SJ H8 DJ DK H6",
		"S3 DA SK D6 SJ|H9 H4 C3 D7 SA",
		"D7 HQ S3 S7 C3|DT CT ST D3 HJ",
		"D3 D9 S9 S7 D8|DA HA HK S5 D7",
		"HK S7 DT D9 H2|H4 SA DJ D7 CA",
		"C6 C3 C4 H7 D9|DA S3 S9 H4 ST",
		"CJ C2 D4 D2 D3|DT C3 H7 D8 C5",
		"CT ST CK H6 DA|C9 DJ DT D4 HQ",
		"H8 H5 S3 D8 DJ|S4 SJ D7 H7 C5",
		"H4 HK D8 DT D4|S4 DJ D7 C4 D9",
		"D2 H5 C2 HT HA|S8 HJ ST S9 SQ",
		"C3 H5 D6 ST H2|H3 H7 S5 HK DK",
		"C3 ST SK D2 S7|CT H5 H8 DT D4",
		"HQ D4 S2 D8 D3|H4 S7 DA SA D7",
		"DQ D9 CJ S9 S7|D2 HJ D3 DA C5",
		"H6 DA S2 D6 HK|S5 D3 CK S7 C7",
		"H2 CA D5 C4 C8|HJ C7 C2 C6 D6",
		"S9 CQ HQ SK D5|SQ D3 DK CJ S5",
		"C3 D5 C2 S8 S9|SJ SA CT S7 HJ",
		"H3 S5 C3 D9 D6|C4 D7 D5 C7 C9",
		"H4 S5 SQ DJ C5|S7 H9 CK SJ CT",
		"SK D6 CA H6 D3|C7 D8 H5 H9 SA",
		"S2 H3 D3 HT C7|S9 HK H5 HA DT",
		"D8 H7 SA S3 S9|H3 HK D7 C6 C2",
		"CT S2 H6 H5 S4|HK D3 DT S5 SQ",
		"ST C6 CK S9 D3|DT SK CA H7 CJ",
		"DJ HA DT ST D8|H4 C3 H8 HQ SK",
		"D7 S9 D8 ST SA|DJ S3 S6 D6 HK",
		"D5 CT H6 H5 C9|D9 D6 H7 SK H2",
		"C4 S5 S9 SA D5|D9 S3 CT HJ HK",
		"C2 HA DQ D6 D9|S3 H6 HJ CA C3",
		"HQ HA CK D5 D8|SQ DQ CT C4 SJ",
		"SA S4 SJ SQ CA|D9 HQ HA D5 D3",
		"D8 ST D6 H8 D3|C2 D4 S8 HT D7",
		"SQ DQ C3 CJ D6|SK D4 SJ HK H9",
		"H9 DJ S3 DQ C8|H8 H5 C6 S9 S5",
		"D3 C2 CJ DQ D8|H5 D5 DA H4 HT",
		"D7 SQ C7 DQ S8|CQ C9 D4 C5 D2",
		"HJ H3 CT C7 DJ|D2 HA S2 SJ C5",
		"ST H2 S2 HJ C9|HK CT DT S3 SJ",
		"SA H9 D6 CJ CT|D3 D7 H7 H3 H8",
		"D6 S9 CT H2 C4|CK S6 H8 DJ CQ",
		"S9 D3 CA H4 DT|CQ C7 SQ SJ S7",
		"HK HJ H5 H8 ST|HT D4 CA C4 H3",
		"S5 CK C9 DT H5|S2 D3 C4 C8 C7",
		"H8 HJ H5 D6 D7|C2 D8 D2 H3 SK",
		"S7 CK SA S6 H6|D8 C3 C2 HJ D2",
		"D4 C7 C5 C4 S6|C9 H8 CJ S3 D8",
		"C9 H3 C5 H6 H8|DJ C2 HK CA H2",
		"DJ S4 CA SK SA|CK H4 SQ H7 DA",
		"S6 H8 DA C6 DT|S3 DK CT S9 H2",
		"H7 DQ D8 DA H5|D3 DJ SA S5 H3",
		"C5 CA HJ ST C3|DA H6 DT C2 C9",
		"CK CT DJ D8 DQ|D6 S8 S5 C4 DK",
		"D8 D7 S4 CK S9|H6 SJ HA SQ S2",
		"S6 CJ C5 D3 D9|SQ CT DQ C4 CK",
		"C3 S3 D8 CJ C9|H9 S5 CA D4 DQ",
		"DT C5 S5 DK D5|D7 D3 C3 C8 H9",
		"ST C5 S5 S3 D3|S8 H6 H7 H3 C2",
		"C8 D7 H3 SK D4|C2 CT S6 D3 S2",
		"DT SQ HT DQ CQ|DJ H4 S9 C8 S3",
		"CQ D7 HA HQ C7|CK H9 HT S5 S8",
		"CJ DA SJ S3 HJ|HT DJ H8 S6 C4",
		"HA D7 S3 S4 DJ|DA HJ H8 CT S7",
		"C5 HT HA DK S2|CT C8 D2 SA S3",
		"D8 D6 DQ DK CQ|SQ S5 S9 H2 S8",
		"H3 C7 C8 H2 C9|HJ C2 H4 H6 S7",
		"CK SK HJ DQ H6|S5 C8 S6 C7 S3",
		"DK S9 H8 H7 S3|C3 D3 SA CJ HT",
		"C9 HJ D4 CT S5|HQ CQ H7 DA ST",
		"H8 S7 S8 S3 H3|SJ S5 ST DQ C7",
		"DQ D5 C3 HQ H9|C8 DK ST C5 HA",
		"C8 CK D3 SQ S8|H5 D9 DK D6 S7",
		"DK CA D2 DJ S7|C5 D5 S3 HT S4",
		"C4 C9 SK S7 S3|S8 S4 DJ D3 DA",
		"H7 C4 H4 DK D3|DJ HA DT C8 S7",
		"DA HJ C3 DQ D2|C5 C4 H2 DT H5",
		"C4 H8 S5 D2 S2|SQ HA D7 CT D9",
		"CA C2 D3 S4 S7|S2 ST C9 CJ C8",
		"HQ S6 S8 S9 H6|DJ SA HA H8 D3",
		"S6 C5 C3 C2 H6|C4 DA H3 H7 D3",
		"D8 S3 CK D3 ST|SQ C6 S9 C9 D4",
		"CA DT DK S3 C3|CJ DJ DQ SQ S4",
		"S7 D8 CJ H5 H7|SJ D2 DA CK S5",
		"S6 S2 CJ H9 S3|DA D8 D7 CQ SQ",
		"D4 H9 S5 C9 D6|CQ SA HJ HA CA",
		"SA H7 H8 H6 SJ|D4 SK CK HK D9",
		"HK D6 HT HA HJ|H2 DK C4 C7 D2",
		"D7 H4 HQ C6 S5|DQ D3 HT DJ HA",
		"DK D4 D8 CT D5|DA S8 HJ S9 C3",
		"DJ HK S5 SK DT|C6 CT C5 D9 H7",
		"DA D8 S9 S5 CK|H2 HA CT C5 HQ",
		"DJ C6 HK SK DT|H8 D4 D7 S5 HJ",
		"S5 D8 H4 CQ CT|DA S8 HJ DT CK",
		"HK C5 H9 CQ D5|CA HQ DQ C4 SK",
		"S8 D6 D8 HJ DQ|HK C9 SQ HT H6",
		"S6 HQ DQ D7 S3|D9 D6 S2 D3 CQ",
		"CJ S9 H9 C9 CQ|CT S5 SJ C6 ST",
		"S5 C9 D2 S3 D9|HK H4 H9 S8 C6",
		"S8 D7 DT SA H7|C3 CA ST HJ H5",
		"SJ CK DQ C6 H8|SA HQ S7 S4 S2",
		"D6 D9 D2 C9 S2|C3 CT S7 D7 CK",
		"D6 S5 C7 CT SJ|SA DJ H4 S3 D4",
		"H3 HT C5 HJ H4|H2 H8 DA CJ S5",
		"D9 H3 D3 SJ DJ|C4 D8 D7 DK S7",
		"C6 C5 S2 SA D3|CJ D7 HJ S9 D9",
		"C3 S3 ST C9 DT|D4 C6 DQ H7 S7",
		"HT C5 H9 H8 D7|C3 C6 D3 H7 HJ",
		"C3 HK S2 H7 SK|D4 HT H8 H4 ST",
		"H6 DT HK D8 CT|D9 S8 CK S4 S3",
		"CQ D6 S3 D2 CT|C7 D5 H2 C2 S4",
		"HT H2 DJ H9 S3|D8 DK C2 SK H3",
		"S6 C9 SQ D7 HK|DJ H8 ST H6 C8",
		"H9 HT S8 CQ DK|DJ H4 HQ S9 H6",
		"C9 H8 S4 H9 C8|H2 SA SK ST CQ",
		"CA H9 D3 SJ DJ|S5 D8 D6 H2 S3",
		"CT DQ S9 D3 S5|DT S8 SJ C6 C4",
		"C9 D8 C5 C7 D3|DT HT H5 C6 C2",
		"D9 CQ H8 S4 CK|D8 D6 D7 SA DJ",
		"H8 HK ST CA D2|H2 DA S2 C2 H5",
		"D8 S9 D3 HA D6|H3 CK C4 C2 SA",
		"S3 S9 C7 H6 D4|S5 D2 S7 HT SK",
		"DJ D9 S4 DK HT|D5 H6 SQ S8 D8",
		"SK HQ C7 H3 DK|DQ CT H9 SJ C8",
		"CA D5 HK C9 CJ|H8 SJ HT SA CK",
		"H9 SA H5 H7 C5|S9 CT C3 S6 DK",
		"CA S3 S9 SQ CJ|S2 SA C5 D3 S4",
		"S9 H9 SJ D2 DT|DQ CJ C5 HK ST",
		"C6 H6 DA CK D3|HK D7 S8 HQ HT",
		"C8 D6 D7 H8 S3|D4 SQ C2 D2 H3",
		"D5 SA C4 S7 HQ|DJ CK H7 C2 DK",
		"HK SK C6 S9 CK|S6 S3 C4 DT C5",
		"D2 D8 C7 C3 SA|D4 SQ H4 S5 HK",
		"C3 DJ S9 D9 S2|HA H4 S7 C2 C5",
		"C5 H7 H2 D2 C2|D6 SK H5 H8 HJ",
		"C2 CA CT HQ D9|D2 D7 S4 C3 D3",
		"S5 ST D9 C3 CA|H9 D3 H7 DA H6",
		"S4 HK CA CQ CJ|SK ST C6 DQ H6",
		"D7 S9 H8 SJ HA|C3 D8 S5 CQ D5",
		"D5 C8 SJ D9 HJ|S2 C9 C5 H6 SA",
		"S2 C3 D9 HJ HQ|CJ H8 SQ D7 H4",
		"SK SA S7 S2 D8|C7 CQ SJ HA H7",
		"SJ D7 S3 CA C9|CT S2 H5 C7 HT",
		"C8 D2 DA HK DQ|S6 HQ C5 D3 H4",
		"C7 CT DA D9 DJ|H3 H5 S7 D8 CA",
		"DT D6 HK D8 D2|C2 DJ HT CJ C4",
		"S6 C5 CQ D8 DT|H2 SK D6 S4 DQ",
		"C6 HA DA S8 C9|DT S7 SK D6 C8",
		"DQ CJ H6 C2 S3|C7 DK SJ HQ D6",
		"DJ H5 CK C4 C9|S4 CA H2 SA C7",
		"C6 CK D4 DQ HT|H6 C7 S6 D5 D2",
		"HJ DJ S4 CA S9|H6 D2 CJ H5 H8",
		"DQ H9 S6 SQ H3|C9 HQ SK DJ DT",
		"DT SK H4 D3 D4|CQ SJ H7 H9 DK",
		"S9 S5 H4 S8 S7|D2 D4 D7 H3 DJ",
		"D7 SA S9 SK HQ|S4 DT HJ H9 CA",
		"S9 CT C5 S6 CQ|DK D6 C4 D8 C6",
		"H6 S2 HK H5 HQ|D7 SA CT S5 C7",
		"DT SA HQ C4 C2|D9 H2 CJ CA S5",
		"HA D7 C9 HJ HK|S4 C6 DQ SK D9",
		"SJ S8 S3 C6 SK|DA H4 C8 D9 SQ",
		"CT H9 C9 HK SJ|CJ D2 H6 HJ SQ",
		"S8 D3 DA S5 SA|S6 DK ST SJ C9",
		"SJ CK H7 DT CA|D9 CQ CT H9 S3",
		"DQ CA C5 C2 D3|DK S4 CJ DA HA",
		"DA C8 S9 D8 DK|D4 H5 S4 SA HQ",
		"C6 S4 DA H3 DT|C2 DQ HJ H4 H9",
		"C7 HK S9 C3 D8|SA C9 C4 HQ D2",
		"CQ D5 CT C9 C7|H4 SK H8 SA H7",
		"S7 D7 D5 H6 DJ|SJ S9 H9 D6 C6",
		"D2 H3 DJ H8 CT|D5 D9 D8 C9 HJ",
		"D7 C5 H4 S8 CK|SK D3 S4 S5 C6",
		"SQ CQ DJ H7 S9|HQ HJ D3 D8 HT",
		"CQ D9 S9 D6 C6|H8 S8 C8 H4 CJ",
		"H2 SK CQ DA H8|S5 H7 HK S7 C9",
		"H7 D2 C3 H8 H2|S5 H4 S8 SA C6",
		"S2 SA S3 DT S8|HT CQ H9 CJ C9",
		"H9 S2 H3 C9 D8|DJ D5 C7 HK CA",
		"CJ CK S4 HJ S7|S8 C4 D7 H9 SA",
		"S3 HJ D5 CJ H8|DK H2 D2 C6 DQ",
		"HA ST H6 C7 S9|H7 DT C3 D3 H3",
		"DQ HJ S9 D3 H8|S2 S7 S4 D6 C3",
		"SK SA D4 S8 H4|H6 D3 H8 HQ H7",
		"H6 DQ S8 C5 C8|C9 DK SA HQ H5",
		"DJ S2 C4 DQ D4|D3 C7 H7 DA HA",
		"HT CQ C7 C5 H2|S9 C2 C9 DJ SK",
		"S6 H6 S4 SA H8|ST CK C7 D3 C9",
		"H2 CQ D7 H5 D3|H8 S3 DQ S4 D9",
		"DK D8 S4 S3 H4|CK DJ C4 HT D7",
		"D4 H2 D8 C4 D7|CQ D2 S3 DK DQ",
		"D8 C3 H4 HQ DT|D9 HK HJ DQ H3",
		"SK HK S9 S8 D4|H4 HQ DT H6 D7",
		"S9 DT C3 ST H3|HQ S7 H9 C7 SJ",
		"S5 S2 S9 ST HJ|H2 HK CA H9 D3",
		"DT S7 C3 S2 H8|C9 C2 H7 D2 C7",
		"S5 DA C5 C7 C4|DQ D2 H4 DT H9",
		"D3 S6 H3 HJ C4|S2 H9 S8 SQ HQ",
		"D8 S8 SQ DK D4|CQ C3 SA D7 C4",
		"H7 C6 S7 H2 S6|DQ DT S3 H5 HK",
		"H9 H8 S5 D8 S8|CK D2 C2 D5 S6",
		"HQ SK SJ S2 HJ|D7 CK S8 S9 CJ",
		"SQ H3 CT D9 CA|D5 C7 SA H7 H4",
		"S6 D4 ST S4 CA|H6 C4 HA H7 CT",
		"H2 HJ C4 C8 H8|CK S7 D9 HT DT",
		"S8 HQ S3 S7 S6|SK S5 DJ SJ H3",
		"S8 CT H9 SA ST|C3 S4 DQ H2 DK",
		"DJ SJ C9 S8 D9|S7 H2 SQ C6 D8",
		"D5 D4 C9 CK D2|S5 SK C3 HJ C4",
		"S5 D7 DT HT H2|H9 S8 D2 CJ CT",
		"H5 D2 CK SJ H2|C3 HK HQ CJ D9",
		"C5 S4 D2 H7 HJ|H8 H5 SA S7 D4",
		"DQ S2 SK D3 D6|C9 C3 S4 DT S5",
		"H4 H7 ST CA H5|S2 S6 DJ H8 CJ",
		"HQ CQ D7 S2 D5|S6 HT D3 C9 H7",
		"D7 CJ S2 SQ HJ|S9 HK H2 D9 HQ",
		"H2 D7 H6 H5 D6|H4 CQ C5 SA C7",
		"D6 S4 DJ S5 SQ|C9 S9 D8 C2 D4",
		"DJ HK ST S5 C6|HQ S2 H5 DT D5",
		"D5 DA D3 SA S6|HQ HK ST CQ HT",
		"C5 SQ DT SK H4|SJ DK C8 D2 S9",
		"ST D5 H6 CJ D7|D6 H2 H7 C4 CQ",
		"C2 CT H5 H3 CA|S7 DT CQ C9 C8",
		"SA CA C6 C7 D2|H4 S6 DA H6 HJ",
		"D3 C5 S9 ST S6|S4 DT HQ H9 C4",
		"CJ D6 C2 H7 H8|D4 DJ ST S9 HJ",
		"H8 C4 SK CA D9|C7 D7 D8 S5 H4",
		"S5 C8 H9 D3 S8|DK CQ SJ HT H4",
		"H4 SQ D2 S5 S8|D3 HK C6 H7 D7",
		"H2 S2 HQ DT C3|DA C8 H9 C4 S8",
		"D7 D8 DJ H6 HQ|CA SA D9 S2 H2",
		"S9 H9 HQ H5 HK|C3 S4 H2 ST SQ",
		"DA SK S2 CJ DK|D2 HQ HK H8 H2",
		"HJ S4 S2 SQ DJ|D3 S8 S6 DT HK",
		"SA HA S2 S6 H5|C9 DT S3 H7 D9",
		"C2 DJ H5 CQ D2|DK DT H2 H7 S5",
		"DA C3 S9 D8 H4|H7 H6 S4 SA CT",
		"D8 C9 D3 S5 H2|C6 S9 C5 DT CK",
		"S8 D8 HA H4 CT|D7 H7 D2 SA C4",
		"HA C2 D7 S9 CA|DT C8 DQ S5 D2",
		"S4 CK HK D6 C3|H8 CQ C4 H2 C9",
		"DA D4 CK C8 C4|C5 DQ D5 HA SQ",
		"D5 H6 HK CA CT|S4 ST HT D8 C3",
		"D8 HT HJ D3 S4|DQ HQ CQ DT SJ",
		"HJ H8 H4 C2 CA|C4 D6 S2 C7 HQ",
		"SK SJ HK D2 S7|C2 S9 DT D9 C7",
		"SQ H7 C5 DA SK|C4 D5 D7 C6 D4",
		"S5 H6 DJ D4 SA|CT S6 C9 D9 CA",
		"SA H7 S9 C7 C9|CQ S8 C2 S6 S2",
		"CQ D6 SA H6 ST|CA H9 CT S7 D7",
		"ST D2 S6 C3 S5|H5 CK S4 DK SK",
		"H2 D9 DA DQ C6|D3 H9 H3 DJ S3",
		"HA HK CJ D7 HQ|CA S9 S5 SJ H4",
		"SA D5 D7 C5 C9|C6 DK C7 D3 DT",
		"CJ D9 H2 C4 C3|C8 CQ SA HK HT",
		"HT H9 HQ D2 S4|H4 H3 C9 D5 DJ",
		"HK CJ D3 S8 D7|DQ D9 SK CA SA",
		"S5 C2 CA D6 HK|ST S6 DA S7 DT",
		"ST D9 H5 HJ S3|HK HA C3 D7 H6",
		"S3 C2 DQ D3 H7|S9 D5 SK ST DT",
		"C9 HT D2 H8 D8|C5 SK DQ CQ SA",
		"H8 HQ HA S2 S5|C4 HJ C7 H2 SK",
		"CA DQ HQ CJ D2|CQ S9 DJ DT H6",
		"H9 CJ D8 HJ D4|C9 HA D5 C8 C4",
		"D3 SQ CK S6 D9|H9 C9 SK S3 D4",
		"D7 CA DT H8 S4|C6 H9 ST D8 CJ",
		"C6 SJ H7 H2 C3|H9 C5 D5 C8 HJ",
		"C5 D3 DQ SA HK|D7 CK C4 CT H7",
		"H4 SK DJ S9 H7|S7 HT CT C8 H6",
		"H6 S3 D2 H5 H9|CJ D5 CT S9 S2",
		"C6 DJ S7 C2 CK|H2 D9 H5 S6 HK",
		"D6 C5 D8 DT H6|C6 S5 S8 H7 D4",
		"S4 D4 S3 SK C3|C8 H8 S8 DJ DT",
		"CJ C8 C9 S5 H6|S6 D8 D9 H4 D4",
		"H7 D9 SK CK H8|H5 HA CJ S8 CA",
		"H6 HT CK C6 C2|S7 SQ SJ C8 D7",
		"DA C2 HQ S7 H7|H2 HA H8 DT C6",
		"D2 CJ S5 C6 CQ|H7 D3 C3 S9 S8",
		"D7 D6 C8 H8 HJ|DQ S5 ST H6 DA",
		"D2 D3 CA SK C7|CT DQ C4 C3 SQ",
		"C9 HA D5 H7 S2|CA H9 C4 CK D4",
		"CQ H2 H3 C5 C6|D2 S4 D9 SA C4",
		"SK CA H9 C3 CT|S6 DT H5 S2 D4",
		"H8 D3 C5 H2 S6|C3 C2 D4 CT C4",
		"CT H9 C2 HJ SK|HA D7 H3 DJ D2",
		"H2 CA C4 HQ S9|H3 DK DQ ST H5",
		"S8 C9 D6 C6 H2|C3 C8 CA HQ DK",
		"D8 CT ST D6 H3|H7 H2 S2 S7 D7",
		"DT D6 H6 HQ S5|CJ S2 SJ DA S6",
		"HT D5 C6 H4 D4|DJ C2 C4 DT S4",
		"D6 HJ S2 CT D3|C3 SK C9 DJ H4",
		"S2 SA DJ D7 C3|DA S4 H5 H8 H2",
		"C4 C8 CJ DT S8|HQ C5 H5 CA S5",
		"S9 HK CT DT S2|HJ H4 H8 S8 DA",
		"H4 S7 S3 D8 DT|CJ D9 D4 D3 D7",
		"C7 D2 H9 H5 SQ|DT D7 HQ SJ C5",
		"S7 DT S9 H3 HQ|HA H7 DA HJ D8",
		"H7 C9 CJ H9 S5|D6 SJ ST SA S3",
		"DA SK H6 D5 D2|CT S9 H7 SA HA",
		"HA HJ SJ HK D8|CQ C2 C9 D6 H2",
		"D7 S6 H6 SK DJ|D2 DQ HQ H3 HJ",
		"H7 H3 C6 CQ D5|D3 C7 H4 H2 D2",
		"S8 CQ C6 D6 H8|DT D9 H2 C8 SK",
		"H3 C3 H9 SQ C8|D4 CK D6 C9 S4",
		"H3 C6 C4 D8 HT|DQ C8 S2 H5 CK",
		"D5 D4 H9 S6 DJ|DA HJ C7 S7 S4",
		"C5 S6 D3 S4 C6|HJ CJ DJ S8 DA",
		"CT H5 ST H3 C9|C4 D7 S2 C5 D9",
		"D5 D9 D2 SK S8|D6 DJ C9 D8 CA",
		"C5 D7 DQ CJ CK|DA S8 D6 H6 D9",
		"C7 CT S2 C4 S6|S9 HJ H7 S7 D9",
		"DJ S5 C6 CJ C3|CA H6 H7 HQ D5",
		"S2 C5 CT S8 SQ|ST H9 D9 H3 HA",
		"S5 H3 D3 ST C5|CQ S2 H6 H7 D8",
		"C8 H5 D9 HA CK|SQ H3 C5 S3 CQ",
		"H3 H8 S9 HQ H5|D8 DJ HT H9 C3",
		"C9 DA C3 C4 CK|HT CJ H3 H4 CT",
		"S7 S8 C8 D5 D2|DA DT HQ SJ DQ",
		"S7 CT C4 H3 CQ|HT D4 S2 DA D3",
		"C9 DJ H6 H3 C4|CJ D3 C6 H9 D4",
		"SA H9 HA C8 H7|S7 DJ CA CK D7",
		"HJ SK H5 S2 H2|C6 HA C8 D3 SQ",
		"S7 CA CJ HT D5|SJ DJ S5 C8 CK",
		"H2 H9 D2 C2 D7|CA CK C5 D8 HK",
		"S8 DK H2 D6 SQ|H7 CJ S2 CT S9",
		"H9 CK C7 SJ D6|SA S8 D5 SK DT",
		"C5 SK S2 C2 C6|DQ CT D5 C4 HJ",
		"DA C2 SA CQ H5|H7 HK SQ C8 HA",
		"DK SQ S6 S2 DA|HA H9 CT H3 C5",
		"H7 D9 HQ C6 H8|C4 S4 DQ CA SJ",
		"H5 D9 ST H3 HQ|H4 CK SQ DA S7",
		"CA S8 S6 DK H7|HJ CJ C9 CT DQ",
		"CK H9 SA H8 CA|SJ H4 DK H7 DQ",
		"C7 S7 ST DA H9|SK CT S3 CQ DJ",
		"HQ CT C4 DJ D6|CK DQ SJ H3 C7",
		"S8 HJ D9 HK C9|C8 S5 DQ C7 DJ",
		"D5 SJ S6 CT DA|H7 DK H5 S4 H2",
		"CJ H6 CA C2 S9|DQ S3 C5 HJ S4",
		"H5 HA C4 H8 H6|C5 CT CK SK SJ",
		"D2 CJ S6 D3 S7|CA H8 C2 HQ S4",
		"D9 C8 SJ HA HK|C5 D8 D7 H2 S2",
		"H5 S3 H9 C8 CJ|DT CT DQ C6 S2",
		"H9 C7 C6 HK C3|S3 D3 C4 H4 S2",
		"H8 ST HK SK S2|H9 S9 C8 D6 C9",
		"C6 CJ DJ S8 C3|S7 HJ CK S3 HA",
		"C6 SA D2 HQ SQ|DA CK S7 H3 D7",
		"C8 H8 D7 CK C9|HA C4 CJ S7 D4",
		"DJ HQ S4 SQ DK|D8 S3 HJ S7 D3",
		"HA S8 HQ DT D4|H4 DQ CQ S2 H7",
		"H4 SQ HT S2 C3|SA S8 C4 C2 D3",
		"CA S3 H8 D2 D6|C3 D8 C7 C2 SJ",
		"C2 D9 C4 D6 CQ|C8 HJ S3 C7 DQ",
		"C5 D6 S9 CQ DQ|C7 DA HJ SA D7",
		"S4 DK C6 CQ C8|HQ D3 S7 C4 SK",
		"DT H2 C5 S8 HT|H5 S5 SJ S6 H3",
		"S9 D8 D9 H8 CJ|DA H4 S3 DT HQ",
		"C3 S3 CQ D2 S8|H7 CA HT SJ H6",
		"D8 DJ ST C4 C9|DA D2 H3 C7 SA",
		"C2 S4 SJ H4 HK|D6 DA D9 C4 C6",
		"SK D8 C5 C9 S4|H9 H4 CA H2 S2",
		"H8 HA HT S8 S4|SA C2 D7 CK D5",
		"C8 C3 C9 D9 D5|D7 S2 CQ SJ HJ",
		"HQ S4 SK DT H3|D9 CQ S7 S8 H8",
		"H2 S4 SQ DK SK|C3 S6 S5 S8 D5",
		"HQ DK DQ S2 D3|S5 HK D7 C8 SJ",
		"C3 CQ D8 H5 CK|S2 S5 SQ S8 S9",
		"DA C8 H5 D4 S3|D2 H7 D3 H3 CJ",
		"H4 CA S4 H3 C7|SQ C9 SJ CQ H2",
		"C7 S9 SK HQ C5|C6 D9 DQ DJ H6",
		"C4 H9 ST C6 S3|DT D5 HK S6 SQ",
		"HK DQ S9 D2 D8|DT HT H2 CJ D4",
		"H2 ST SJ DT C3|D3 D2 DQ H4 SQ",
		"S7 CJ D9 H2 CQ|S3 D4 C4 CA CK",
		"H2 D7 DK DT H9|S4 SQ C8 D2 HT",
		"D5 CQ DJ SQ D4|S9 C3 HT H7 DT",
		"DK H2 C4 HA C2|CT DA HK H9 DJ",
		"DQ D8 ST HQ C9|SK H6 H4 SA S5",
		"C4 C5 H4 H5 H7|D7 CJ S7 C6 HQ",
		"DT S4 D4 D9 HQ|D3 H4 C5 C6 SQ",
		"C7 H4 H7 C2 H6|HJ CA C5 C6 CJ",
		"H6 C3 ST SQ D7|D3 C4 H4 H8 HQ",
		"CK CA SQ S7 S4|S9 H4 CQ DQ S3",
		"S4 S3 HQ CQ H2|H5 HA SQ D6 D9",
		"CK C2 C9 H3 HK|SK DJ DK D9 D3",
		"S4 C2 H7 S3 C5|D6 D3 D9 H8 CJ",
		"DT DA ST D5 D2|HT H2 C9 S9 H6",
		"DT DQ S6 H4 DJ|S9 CT D3 D8 H3",
		"H6 S3 SQ HT ST|C4 C7 H4 D3 S6",
		"S5 S2 S4 CK CT|H8 D6 D9 DK SA",
		"C7 D4 S5 H9 H3|SQ CJ SA HT D9",
		"H7 S5 D9 H9 H3|HA SJ CA DQ S8",
		"CJ SA SK C5 D4|S5 D6 S8 HJ H6",
		"S9 C7 SK D5 ST|C2 CJ S3 D4 SQ",
		"S5 D5 H5 HQ C5|HA CA D6 DT SJ",
		"H6 ST DT HT HA|CT SQ DA SK D4",
		"HA S9 DT D2 S4|S8 D9 CT H4 C8",
		"H7 S6 D5 S9 D4|D7 H4 C5 HK H9",
		"H4 S2 S9 CJ S7|CQ H2 SA D4 HJ",
		"HQ CJ C9 D9 SQ|H3 H6 DJ S2 HT",
		"H5 D2 C2 HK C6|SJ CA H8 S8 ST",
		"S5 S2 CJ HK D9|HA H7 CQ CT C2",
		"C3 SJ D7 C6 C7|D5 DQ D6 HJ DK",
		"C8 D9 SQ DK C9|H9 H7 D2 CT HK",
		"D9 DK D2 H4 HQ|S9 S6 C6 D7 CA",
		"HQ H7 D5 D9 H5|SA DT S9 C3 D6",
		"CK S7 D3 H9 DQ|CJ CQ C3 S2 HK",
		"HK H9 DQ H5 C4|H8 C8 H2 CA C7",
		"SJ S8 DJ H3 C3|C8 S9 HQ C6 C4",
		"H8 S2 ST S3 C6|C7 HT SA C9 C3",
		"CQ SJ HK S4 D6|C2 S6 D5 S8 D2",
		"S9 D2 C7 S8 D3|CJ HJ HA S4 HQ",
		"C3 C2 SA H3 H7|CA S6 D6 C7 D4",
		"H7 HQ D4 H6 D2|C4 DQ SA S6 C7",
		"H6 ST SA HQ H3|H4 DA S6 D9 C3",
		"D3 CJ H9 H2 D6|DA H6 C5 D2 DT",
		"ST SQ D7 C9 CT|D4 S2 H8 CA SJ",
		"DJ S8 C9 S6 C5|C4 SK D7 S9 H7",
		"D3 D7 D2 H8 DK|SJ DQ HA C5 D5",
		"H3 HK ST H2 C7|CQ D6 S5 CT SQ",
		"H3 D9 S9 H7 SK|D3 C7 D7 HJ S7",
		"HQ S7 H6 ST DT|D2 CQ D7 CA H7",
		"D4 C4 HJ D8 H8|S6 H6 H5 C9 C2",
		"SJ C9 DK C8 D2|D4 S6 H9 SK D3",
		"D5 D8 H5 C2 H2|H7 S3 SA S9 ST",
		"H2 CJ D3 HJ H3|DJ H9 H4 C4 S4",
		"DK S4 S5 D7 DQ|HT D6 H3 HA CT",
		"D2 H9 HQ CT D9|C6 HA C2 DQ S5",
		"H9 D2 H2 D6 C3|SA CK HT DT S4",
		"DK H3 ST H2 C2|CJ H6 CQ S6 C7",
		"DJ S9 D8 CJ SJ|DA S4 SA HA D9",
		"HA S2 D2 HQ HT|DQ DA C9 S3 CT",
		"H3 HK HT D4 CJ|D7 HQ S9 D8 S5",
		"HT SA CA D4 DQ|C6 H3 H8 S5 SQ",
		"SQ D7 H8 S6 H9|DJ S4 CK C4 H4",
		"S5 ST SJ H6 H3|D7 C9 H4 HJ C4",
		"C2 D7 S3 C6 S7|H6 CT S6 DT D4",
		"C6 D6 H4 H7 CT|SJ D2 S2 H8 D3",
		"H3 C3 S3 CQ DJ|D2 D8 H2 HQ C7",
		"DQ HT D9 C9 SQ|C4 H7 D2 DJ DT",
		"CA CJ S4 D9 S6|CK C4 HT SJ H6",
		"DA D8 D7 S5 CT|DQ D6 S9 HT SK",
		"C4 CT C2 S7 S8|C3 S2 C7 H7 CK",
		"D4 C6 H7 H9 HA|DJ D9 DK H5 D7",
		"DT SJ D4 C7 D8|HA DA SA D9 S9",
		"C8 H5 S9 DK H3|S2 DQ D5 H6 CT",
		"D7 D6 H4 S8 CA|S7 D5 S6 C6 DA",
		"C2 S6 CJ C7 SK|HJ S3 DJ HQ S9",
		"S6 H5 HJ H6 C8|D5 S7 SA CK S8",
		"HA DK H9 C9 D6|SK C5 D2 C7 S8",
		"H4 S2 H6 H9 C9|S4 S3 H3 D4 H5",
		"C8 SJ HJ S9 SA|S6 CT HA CQ C7",
		"C4 DT D5 SA C5|H8 HA C9 C8 DJ",
		"C2 DT S6 DK SA|S5 SQ CQ H7 S9",
		"S5 DA HA DJ S7|D6 CA H2 SJ H5",
		"HT DK S7 D9 CA|DT D3 SA HJ S5",
		"HT C2 H6 D7 D9|D4 DK S6 DJ D3",
		"SJ S5 HK D7 HA|HJ D3 H6 H7 H4",
		"C3 CK S3 D8 CQ|S2 H8 ST C5 H4",
		"C8 CA D9 S6 S3|S8 DA HK D3 ST",
		"S6 DA CA S3 H5|D2 C8 H6 HQ HK",
		"S4 S9 SA SK C9|D3 D6 DT DK H6",
		"D5 CQ HA S8 C4|S6 CA D2 C6 S4",
		"HT CQ S3 HK C3|H7 S6 H3 D5 D3",
		"SQ D5 C2 H9 H6|S3 H8 C6 CK S7",
		"S4 HK D6 SJ C4|H2 C3 S7 SA S6",
		"CJ SJ C4 H3 DK|S5 DA CQ D4 S8",
		"C5 D6 HK CQ D8|S3 D7 C8 D5 D4",
		"D7 SQ HJ C2 S8|S2 CK D4 DQ C4",
		"DJ H9 D7 H8 C2|CQ C9 D5 H5 C4",
		"H7 D9 D7 D2 S9|C4 CA H4 S4 S2",
		"DT C7 C3 HQ CJ|H2 D2 H7 D3 HK",
		"C6 H6 S3 S6 D9|HK DJ C5 D4 HT",
		"H4 HJ C6 H7 HQ|D5 D4 C4 S3 H3",
		"D2 C3 DT SQ H3|HQ S4 SJ HK H2",
		"D5 C6 D6 SK D4|DK C8 C7 S2 DA",
		"H2 H9 CA CJ D7|HJ CQ S2 HK C6",
		"H4 C6 C4 CQ DJ|S3 SA D2 C5 S9",
		"H2 S8 C5 SA CJ|S9 C3 H5 ST H7",
		"SJ DK CK DJ C5|C6 D3 DT H2 SA",
		"D2 HK D9 S4 C9|CQ CA SA H5 HA",
		"H9 S2 DJ CK S4|HA HK H2 H6 H4",
		"H6 C8 S5 SK HA|S9 SA C2 ST D8",
		"C8 HK H8 HJ HQ|SJ H4 DK S5 DQ",
		"C4 D7 D8 C6 SQ|CJ S2 C8 SK H8",
		"DT DQ HQ S4 SA|DK C5 H4 CK CQ",
	};
}
