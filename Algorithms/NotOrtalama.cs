namespace Algorithms;

public class NotOrtalama
{
	public void ort()
	{
		int mat, fen, tr, cog;

		Console.Write("Mat notun: ");
		mat = Convert.ToInt16(Console.ReadLine());

		Console.Write("Fen notun: ");
		fen = Convert.ToInt16(Console.ReadLine());

		Console.Write("Türkçe notun: ");
		tr = Convert.ToInt16(Console.ReadLine());

		Console.Write("Coğrafya notun: ");
		cog = Convert.ToInt16(Console.ReadLine());

		int toplam = mat + fen + tr + cog;
		double ort = toplam / 4.0;
		string sonuc = (ort >= 50) ? "sınıfı geçtiniz" : "sınıfta kaldınız";

		Console.Write("Not ortalamanız: {0}, {1}", ort, sonuc);

	}
}